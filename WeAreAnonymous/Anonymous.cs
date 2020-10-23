using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Collections.ObjectModel;
using System.IO;
using System.Diagnostics;

namespace WeAreAnonymous
{
    public partial class Anonymous : Form
    {
        public Anonymous()
        {
            InitializeComponent();
        }

        private void TestTTS_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speechSynth = new SpeechSynthesizer();
            ReadOnlyCollection<InstalledVoice> voices = speechSynth.GetInstalledVoices();
            foreach(InstalledVoice voice in voices)
            {
                if(voice.VoiceInfo.Name.ToLower().Contains("david") || voice.VoiceInfo.Name.ToLower().Contains("sam"))
                {
                    speechSynth.SelectVoice(voice.VoiceInfo.Name);
                    break;
                }
            }
            Prompt prompt = new Prompt(TTS.Text);
            speechSynth.SpeakAsync(prompt);
        }

        private void CreateVideo_Click(object sender, EventArgs e)
        {
            CreateVideo.Enabled = false;
            Directory.SetCurrentDirectory(Path.GetDirectoryName(Application.ExecutablePath));

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "We Are Legion.mp4";
            sfd.DefaultExt = "mp4";
            sfd.Filter = "MPEG-4 Videos|*.mp4";
            sfd.ShowDialog();

            string outputPath = sfd.FileName;

            SpeechSynthesizer speechSynth = new SpeechSynthesizer();
            ReadOnlyCollection<InstalledVoice> voices = speechSynth.GetInstalledVoices();
            foreach (InstalledVoice voice in voices)
            {
                if (voice.VoiceInfo.Name.ToLower().Contains("david") || voice.VoiceInfo.Name.ToLower().Contains("sam"))
                {
                    speechSynth.SelectVoice(voice.VoiceInfo.Name);
                    break;
                }
            }

            CurrentProcess.Text = "Generating TTS";
            Prompt prompt = new Prompt(TTS.Text);
            if (File.Exists("WeAreLegion.wav"))
                File.Delete("WeAreLegion.wav");
            FileStream wavStream = File.OpenWrite("WeAreLegion.wav");
            speechSynth.SetOutputToWaveStream(wavStream);
            speechSynth.SpeakAsync(prompt);
            while (!prompt.IsCompleted)
                Application.DoEvents();
            wavStream.Dispose();

            CurrentProcess.Text = "Generating Video...";

            Process ffmpeg = new Process();
            ffmpeg.StartInfo.FileName = "ffmpeg.exe";
            ffmpeg.StartInfo.Arguments = "-stream_loop -1 -i AnnonLoop.mp4 -i WeAreLegion.wav -shortest -map 0:v:0 -map 1:a:0 -y WeAreLegion.mp4";
            ffmpeg.StartInfo.CreateNoWindow = true;
            ffmpeg.StartInfo.UseShellExecute = false;
            ffmpeg.Start();


            while (!ffmpeg.HasExited)
                Application.DoEvents();

            if (File.Exists("WeAreLegion.wav"))
                File.Delete("WeAreLegion.wav");


            CurrentProcess.Text = "Adding Intro Video...";

            ffmpeg = new Process();
            ffmpeg.StartInfo.FileName = "ffmpeg.exe";
            ffmpeg.StartInfo.Arguments = "-i AnnonIntro.mp4 -i WeAreLegion.mp4 -filter_complex \"[0:v] [0:a] [1:v] [1:a] concat=n=2:v=1:a=1 [v] [a]\" -map \"[v]\" -map \"[a]\" -y \"" + outputPath+"\"";
            ffmpeg.StartInfo.CreateNoWindow = true;
            ffmpeg.StartInfo.UseShellExecute = false;
            ffmpeg.Start();

            while (!ffmpeg.HasExited)
                Application.DoEvents();

            ffmpeg.Dispose();

            if (File.Exists("WeAreLegion.mp4"))
                File.Delete("WeAreLegion.mp4");

            CurrentProcess.Text = "WE DO NOT FORGIVE, WE DO NOT FORGET, EXPECT US";

            MessageBox.Show("YOU ARE ANONYMOUS", "WE ARE LEGION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CreateVideo.Enabled = true;
        }

        private void Anonymous_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process[] procs = Process.GetProcessesByName("ffmpeg");
            foreach(Process proc in procs)
            {
                proc.Kill();
            }

            Environment.Exit(0);
        }
    }
}

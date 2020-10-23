namespace WeAreAnonymous
{
    partial class Anonymous
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anonymous));
            this.CreateVideo = new System.Windows.Forms.Button();
            this.TestTTS = new System.Windows.Forms.Button();
            this.TTS = new System.Windows.Forms.RichTextBox();
            this.CurrentProcess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateVideo
            // 
            this.CreateVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateVideo.BackColor = System.Drawing.Color.Black;
            this.CreateVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateVideo.Location = new System.Drawing.Point(12, 609);
            this.CreateVideo.Name = "CreateVideo";
            this.CreateVideo.Size = new System.Drawing.Size(388, 23);
            this.CreateVideo.TabIndex = 1;
            this.CreateVideo.Text = "EXPECT US";
            this.CreateVideo.UseVisualStyleBackColor = false;
            this.CreateVideo.Click += new System.EventHandler(this.CreateVideo_Click);
            // 
            // TestTTS
            // 
            this.TestTTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TestTTS.BackColor = System.Drawing.Color.Black;
            this.TestTTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestTTS.Location = new System.Drawing.Point(415, 609);
            this.TestTTS.Name = "TestTTS";
            this.TestTTS.Size = new System.Drawing.Size(401, 23);
            this.TestTTS.TabIndex = 2;
            this.TestTTS.Text = "WE ARE LEGION";
            this.TestTTS.UseVisualStyleBackColor = false;
            this.TestTTS.Click += new System.EventHandler(this.TestTTS_Click);
            // 
            // TTS
            // 
            this.TTS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TTS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TTS.DetectUrls = false;
            this.TTS.ForeColor = System.Drawing.Color.Lime;
            this.TTS.Location = new System.Drawing.Point(12, 12);
            this.TTS.Name = "TTS";
            this.TTS.Size = new System.Drawing.Size(804, 570);
            this.TTS.TabIndex = 3;
            this.TTS.Text = resources.GetString("TTS.Text");
            // 
            // CurrentProcess
            // 
            this.CurrentProcess.AutoSize = true;
            this.CurrentProcess.Location = new System.Drawing.Point(12, 585);
            this.CurrentProcess.Name = "CurrentProcess";
            this.CurrentProcess.Size = new System.Drawing.Size(302, 13);
            this.CurrentProcess.TabIndex = 4;
            this.CurrentProcess.Text = "WE DO NOT FORGIVE, WE DO NOT FORGET, EXPECT US";
            // 
            // Anonymous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(828, 644);
            this.Controls.Add(this.CurrentProcess);
            this.Controls.Add(this.TTS);
            this.Controls.Add(this.TestTTS);
            this.Controls.Add(this.CreateVideo);
            this.ForeColor = System.Drawing.Color.SpringGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Anonymous";
            this.Text = "We Are Anonymous";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Anonymous_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateVideo;
        private System.Windows.Forms.Button TestTTS;
        private System.Windows.Forms.RichTextBox TTS;
        private System.Windows.Forms.Label CurrentProcess;
    }
}


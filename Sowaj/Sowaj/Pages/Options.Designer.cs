namespace Sowaj
{
    partial class Options
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
            this.lblSound = new System.Windows.Forms.Label();
            this.btnSoundOn = new System.Windows.Forms.Button();
            this.btnSoundOff = new System.Windows.Forms.Button();
            this.lblMusic = new System.Windows.Forms.Label();
            this.btnMusicOn = new System.Windows.Forms.Button();
            this.btnMusicOff = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Location = new System.Drawing.Point(213, 206);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(49, 17);
            this.lblSound.TabIndex = 0;
            this.lblSound.Text = "Sound";
            // 
            // btnSoundOn
            // 
            this.btnSoundOn.Location = new System.Drawing.Point(268, 202);
            this.btnSoundOn.Name = "btnSoundOn";
            this.btnSoundOn.Size = new System.Drawing.Size(75, 23);
            this.btnSoundOn.TabIndex = 1;
            this.btnSoundOn.Text = "on";
            this.btnSoundOn.UseVisualStyleBackColor = true;
            this.btnSoundOn.Click += new System.EventHandler(this.btnSoundOn_Click);
            // 
            // btnSoundOff
            // 
            this.btnSoundOff.Location = new System.Drawing.Point(349, 202);
            this.btnSoundOff.Name = "btnSoundOff";
            this.btnSoundOff.Size = new System.Drawing.Size(75, 23);
            this.btnSoundOff.TabIndex = 1;
            this.btnSoundOff.Text = "off";
            this.btnSoundOff.UseVisualStyleBackColor = true;
            this.btnSoundOff.Click += new System.EventHandler(this.btnSoundOff_Click);
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.Location = new System.Drawing.Point(213, 179);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(44, 17);
            this.lblMusic.TabIndex = 0;
            this.lblMusic.Text = "Music";
            // 
            // btnMusicOn
            // 
            this.btnMusicOn.Location = new System.Drawing.Point(268, 175);
            this.btnMusicOn.Name = "btnMusicOn";
            this.btnMusicOn.Size = new System.Drawing.Size(75, 23);
            this.btnMusicOn.TabIndex = 1;
            this.btnMusicOn.Text = "on";
            this.btnMusicOn.UseVisualStyleBackColor = true;
            this.btnMusicOn.Click += new System.EventHandler(this.btnMusicOn_Click);
            // 
            // btnMusicOff
            // 
            this.btnMusicOff.Location = new System.Drawing.Point(349, 175);
            this.btnMusicOff.Name = "btnMusicOff";
            this.btnMusicOff.Size = new System.Drawing.Size(75, 23);
            this.btnMusicOff.TabIndex = 1;
            this.btnMusicOff.Text = "off";
            this.btnMusicOff.UseVisualStyleBackColor = true;
            this.btnMusicOff.Click += new System.EventHandler(this.btnMusicOff_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(556, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 421);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMusicOff);
            this.Controls.Add(this.btnSoundOff);
            this.Controls.Add(this.btnMusicOn);
            this.Controls.Add(this.lblMusic);
            this.Controls.Add(this.btnSoundOn);
            this.Controls.Add(this.lblSound);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.Button btnSoundOn;
        private System.Windows.Forms.Button btnSoundOff;
        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.Button btnMusicOn;
        private System.Windows.Forms.Button btnMusicOff;
        private System.Windows.Forms.Button btnClose;
    }
}
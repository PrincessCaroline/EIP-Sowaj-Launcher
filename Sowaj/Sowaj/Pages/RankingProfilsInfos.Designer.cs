namespace Sowaj
{
    partial class RankingProfilsInfos
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
            this.pctAvatar = new System.Windows.Forms.PictureBox();
            this.lblNickname = new System.Windows.Forms.Label();
            this.lblRankPoints = new System.Windows.Forms.Label();
            this.pctRank = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRank)).BeginInit();
            this.SuspendLayout();
            // 
            // pctAvatar
            // 
            this.pctAvatar.Image = global::Sowaj.Properties.Resources._2;
            this.pctAvatar.Location = new System.Drawing.Point(2, 1);
            this.pctAvatar.Name = "pctAvatar";
            this.pctAvatar.Size = new System.Drawing.Size(63, 59);
            this.pctAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAvatar.TabIndex = 0;
            this.pctAvatar.TabStop = false;
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Location = new System.Drawing.Point(82, 9);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(89, 17);
            this.lblNickname.TabIndex = 1;
            this.lblNickname.Text = "Player Name";
            // 
            // lblRankPoints
            // 
            this.lblRankPoints.AutoSize = true;
            this.lblRankPoints.Location = new System.Drawing.Point(507, 25);
            this.lblRankPoints.Name = "lblRankPoints";
            this.lblRankPoints.Size = new System.Drawing.Size(113, 17);
            this.lblRankPoints.TabIndex = 2;
            this.lblRankPoints.Text = "2042 PVP points";
            // 
            // pctRank
            // 
            this.pctRank.Image = global::Sowaj.Properties.Resources.diamond_1;
            this.pctRank.Location = new System.Drawing.Point(439, 1);
            this.pctRank.Name = "pctRank";
            this.pctRank.Size = new System.Drawing.Size(62, 59);
            this.pctRank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRank.TabIndex = 3;
            this.pctRank.TabStop = false;
            // 
            // RankingProfilsInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 63);
            this.Controls.Add(this.pctRank);
            this.Controls.Add(this.lblRankPoints);
            this.Controls.Add(this.lblNickname);
            this.Controls.Add(this.pctAvatar);
            this.Name = "RankingProfilsInfos";
            this.Text = "RankingProfilsInfos";
            ((System.ComponentModel.ISupportInitialize)(this.pctAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctAvatar;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.Label lblRankPoints;
        private System.Windows.Forms.PictureBox pctRank;
    }
}
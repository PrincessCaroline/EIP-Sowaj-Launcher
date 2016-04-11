namespace Sowaj
{
    partial class Friends
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
            this.pnlFriendInfos = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.picFriendRank = new System.Windows.Forms.PictureBox();
            this.lblFriendRank = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFriendLevel = new System.Windows.Forms.Label();
            this.lblFriendPseudo = new System.Windows.Forms.Label();
            this.picFriendAvatar = new System.Windows.Forms.PictureBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.ListBoxMessages = new System.Windows.Forms.ListBox();
            this.pnlFriendInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFriendRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFriendAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFriendInfos
            // 
            this.pnlFriendInfos.Controls.Add(this.progressBar1);
            this.pnlFriendInfos.Controls.Add(this.picFriendRank);
            this.pnlFriendInfos.Controls.Add(this.lblFriendRank);
            this.pnlFriendInfos.Controls.Add(this.label1);
            this.pnlFriendInfos.Controls.Add(this.label2);
            this.pnlFriendInfos.Controls.Add(this.lblFriendLevel);
            this.pnlFriendInfos.Controls.Add(this.lblFriendPseudo);
            this.pnlFriendInfos.Controls.Add(this.picFriendAvatar);
            this.pnlFriendInfos.Location = new System.Drawing.Point(3, 1);
            this.pnlFriendInfos.Name = "pnlFriendInfos";
            this.pnlFriendInfos.Size = new System.Drawing.Size(354, 148);
            this.pnlFriendInfos.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 119);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(348, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // picFriendRank
            // 
            this.picFriendRank.Image = global::Sowaj.Properties.Resources.diamond_1;
            this.picFriendRank.Location = new System.Drawing.Point(279, 4);
            this.picFriendRank.Name = "picFriendRank";
            this.picFriendRank.Size = new System.Drawing.Size(70, 70);
            this.picFriendRank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFriendRank.TabIndex = 2;
            this.picFriendRank.TabStop = false;
            // 
            // lblFriendRank
            // 
            this.lblFriendRank.Location = new System.Drawing.Point(279, 71);
            this.lblFriendRank.Name = "lblFriendRank";
            this.lblFriendRank.Size = new System.Drawing.Size(69, 23);
            this.lblFriendRank.TabIndex = 1;
            this.lblFriendRank.Text = "Diamant I";
            this.lblFriendRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Humain";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(282, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "2155";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFriendLevel
            // 
            this.lblFriendLevel.AutoSize = true;
            this.lblFriendLevel.Location = new System.Drawing.Point(120, 26);
            this.lblFriendLevel.Name = "lblFriendLevel";
            this.lblFriendLevel.Size = new System.Drawing.Size(54, 17);
            this.lblFriendLevel.TabIndex = 1;
            this.lblFriendLevel.Text = "Level 5";
            // 
            // lblFriendPseudo
            // 
            this.lblFriendPseudo.AutoSize = true;
            this.lblFriendPseudo.Location = new System.Drawing.Point(120, 6);
            this.lblFriendPseudo.Name = "lblFriendPseudo";
            this.lblFriendPseudo.Size = new System.Drawing.Size(101, 17);
            this.lblFriendPseudo.TabIndex = 1;
            this.lblFriendPseudo.Text = "Nom du joueur";
            // 
            // picFriendAvatar
            // 
            this.picFriendAvatar.Image = global::Sowaj.Properties.Resources._2;
            this.picFriendAvatar.Location = new System.Drawing.Point(3, 3);
            this.picFriendAvatar.Name = "picFriendAvatar";
            this.picFriendAvatar.Size = new System.Drawing.Size(110, 110);
            this.picFriendAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFriendAvatar.TabIndex = 0;
            this.picFriendAvatar.TabStop = false;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(277, 623);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(75, 23);
            this.btnSendMsg.TabIndex = 1;
            this.btnSendMsg.Text = "Envoyer";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(3, 623);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(267, 22);
            this.txtMessage.TabIndex = 0;
            // 
            // ListBoxMessages
            // 
            this.ListBoxMessages.FormattingEnabled = true;
            this.ListBoxMessages.ItemHeight = 16;
            this.ListBoxMessages.Location = new System.Drawing.Point(4, 151);
            this.ListBoxMessages.Name = "ListBoxMessages";
            this.ListBoxMessages.Size = new System.Drawing.Size(350, 468);
            this.ListBoxMessages.TabIndex = 2;
            // 
            // Friends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 654);
            this.Controls.Add(this.ListBoxMessages);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.pnlFriendInfos);
            this.Name = "Friends";
            this.Text = "Friends";
            this.pnlFriendInfos.ResumeLayout(false);
            this.pnlFriendInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFriendRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFriendAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlFriendInfos;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.PictureBox picFriendRank;
        private System.Windows.Forms.Label lblFriendRank;
        private System.Windows.Forms.Label lblFriendLevel;
        private System.Windows.Forms.Label lblFriendPseudo;
        private System.Windows.Forms.PictureBox picFriendAvatar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListBoxMessages;
    }
}
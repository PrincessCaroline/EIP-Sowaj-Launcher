namespace Sowaj
{
    partial class ItemFriends
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFriendName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChat)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sowaj.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblFriendName
            // 
            this.lblFriendName.AutoSize = true;
            this.lblFriendName.Location = new System.Drawing.Point(39, 9);
            this.lblFriendName.Name = "lblFriendName";
            this.lblFriendName.Size = new System.Drawing.Size(99, 17);
            this.lblFriendName.TabIndex = 1;
            this.lblFriendName.Text = "JeremyLeChat";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnChat
            // 
            this.btnChat.Image = global::Sowaj.Properties.Resources._1455745131_speech_bubble_dots_outline;
            this.btnChat.Location = new System.Drawing.Point(144, 3);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(30, 30);
            this.btnChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnChat.TabIndex = 0;
            this.btnChat.TabStop = false;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // ItemFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 36);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFriendName);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ItemFriends";
            this.Text = "ItemFriends";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFriendName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox btnChat;
    }
}
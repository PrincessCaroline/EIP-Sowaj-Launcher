namespace Sowaj
{
    partial class Ranking
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
            this.tabCtrlRanking = new System.Windows.Forms.TabControl();
            this.tabPageFriends = new System.Windows.Forms.TabPage();
            this.tabPageWorld = new System.Windows.Forms.TabPage();
            this.tabPageLocal = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabCtrlRanking.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrlRanking
            // 
            this.tabCtrlRanking.Controls.Add(this.tabPageFriends);
            this.tabCtrlRanking.Controls.Add(this.tabPageWorld);
            this.tabCtrlRanking.Controls.Add(this.tabPageLocal);
            this.tabCtrlRanking.HotTrack = true;
            this.tabCtrlRanking.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabCtrlRanking.Location = new System.Drawing.Point(12, 37);
            this.tabCtrlRanking.Name = "tabCtrlRanking";
            this.tabCtrlRanking.SelectedIndex = 0;
            this.tabCtrlRanking.Size = new System.Drawing.Size(690, 547);
            this.tabCtrlRanking.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabCtrlRanking.TabIndex = 0;
            // 
            // tabPageFriends
            // 
            this.tabPageFriends.AutoScroll = true;
            this.tabPageFriends.Location = new System.Drawing.Point(4, 25);
            this.tabPageFriends.Name = "tabPageFriends";
            this.tabPageFriends.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFriends.Size = new System.Drawing.Size(682, 518);
            this.tabPageFriends.TabIndex = 0;
            this.tabPageFriends.Text = "Classement Amis";
            this.tabPageFriends.UseVisualStyleBackColor = true;
            // 
            // tabPageWorld
            // 
            this.tabPageWorld.AutoScroll = true;
            this.tabPageWorld.Location = new System.Drawing.Point(4, 25);
            this.tabPageWorld.Name = "tabPageWorld";
            this.tabPageWorld.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorld.Size = new System.Drawing.Size(682, 518);
            this.tabPageWorld.TabIndex = 1;
            this.tabPageWorld.Text = "Classement Mondial";
            this.tabPageWorld.UseVisualStyleBackColor = true;
            // 
            // tabPageLocal
            // 
            this.tabPageLocal.AutoScroll = true;
            this.tabPageLocal.Location = new System.Drawing.Point(4, 25);
            this.tabPageLocal.Name = "tabPageLocal";
            this.tabPageLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLocal.Size = new System.Drawing.Size(682, 518);
            this.tabPageLocal.TabIndex = 2;
            this.tabPageLocal.Text = "Classement Local";
            this.tabPageLocal.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(621, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 584);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabCtrlRanking);
            this.Name = "Ranking";
            this.Text = "Ranking";
            this.tabCtrlRanking.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlRanking;
        private System.Windows.Forms.TabPage tabPageFriends;
        private System.Windows.Forms.TabPage tabPageWorld;
        private System.Windows.Forms.TabPage tabPageLocal;
        private System.Windows.Forms.Button btnClose;
    }
}
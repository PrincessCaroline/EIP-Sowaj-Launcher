namespace Sowaj
{
    partial class Deck
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCardNumberInfo = new System.Windows.Forms.Label();
            this.lblCardNumberText = new System.Windows.Forms.Label();
            this.lblChampionName = new System.Windows.Forms.Label();
            this.ptcChampionAvatar = new System.Windows.Forms.PictureBox();
            this.btnDeleteDeck = new System.Windows.Forms.Button();
            this.btnCreateDeck = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRenameDeck = new System.Windows.Forms.Button();
            this.txtDeckName = new System.Windows.Forms.TextBox();
            this.lblDeckName = new System.Windows.Forms.Label();
            this.pctPrevDeck = new System.Windows.Forms.PictureBox();
            this.pctNextDeck = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowDeck = new System.Windows.Forms.Button();
            this.btnEditDeck = new System.Windows.Forms.Button();
            this.btnChooseCardsSkins = new System.Windows.Forms.PictureBox();
            this.btnSelectChampion = new System.Windows.Forms.Button();
            this.btnBackToProfil = new System.Windows.Forms.Button();
            this.pnlChooseSkinCards = new System.Windows.Forms.Panel();
            this.pnlChooseChampions = new System.Windows.Forms.Panel();
            this.pnlEditDeck = new System.Windows.Forms.Panel();
            this.pnlShowDeck = new System.Windows.Forms.Panel();
            this.btnSaveDeck = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcChampionAvatar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrevDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNextDeck)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnChooseCardsSkins)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCardNumberInfo);
            this.panel1.Controls.Add(this.lblCardNumberText);
            this.panel1.Controls.Add(this.lblChampionName);
            this.panel1.Controls.Add(this.ptcChampionAvatar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnDeleteDeck);
            this.panel1.Controls.Add(this.btnCreateDeck);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(264, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 339);
            this.panel1.TabIndex = 0;
            // 
            // lblCardNumberInfo
            // 
            this.lblCardNumberInfo.Location = new System.Drawing.Point(360, 313);
            this.lblCardNumberInfo.Name = "lblCardNumberInfo";
            this.lblCardNumberInfo.Size = new System.Drawing.Size(42, 22);
            this.lblCardNumberInfo.TabIndex = 4;
            this.lblCardNumberInfo.Text = "0/30";
            this.lblCardNumberInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCardNumberText
            // 
            this.lblCardNumberText.Location = new System.Drawing.Point(224, 313);
            this.lblCardNumberText.Name = "lblCardNumberText";
            this.lblCardNumberText.Size = new System.Drawing.Size(135, 23);
            this.lblCardNumberText.TabIndex = 4;
            this.lblCardNumberText.Text = "Nombre de cartes :";
            this.lblCardNumberText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChampionName
            // 
            this.lblChampionName.Location = new System.Drawing.Point(4, 310);
            this.lblChampionName.Name = "lblChampionName";
            this.lblChampionName.Size = new System.Drawing.Size(183, 28);
            this.lblChampionName.TabIndex = 3;
            this.lblChampionName.Text = "Choose a champion";
            this.lblChampionName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptcChampionAvatar
            // 
            this.ptcChampionAvatar.Image = global::Sowaj.Properties.Resources.popup_main_3;
            this.ptcChampionAvatar.Location = new System.Drawing.Point(4, 53);
            this.ptcChampionAvatar.Name = "ptcChampionAvatar";
            this.ptcChampionAvatar.Size = new System.Drawing.Size(183, 254);
            this.ptcChampionAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcChampionAvatar.TabIndex = 2;
            this.ptcChampionAvatar.TabStop = false;
            // 
            // btnDeleteDeck
            // 
            this.btnDeleteDeck.Location = new System.Drawing.Point(203, 84);
            this.btnDeleteDeck.Name = "btnDeleteDeck";
            this.btnDeleteDeck.Size = new System.Drawing.Size(199, 32);
            this.btnDeleteDeck.TabIndex = 1;
            this.btnDeleteDeck.Text = "Supprimer";
            this.btnDeleteDeck.UseVisualStyleBackColor = true;
            this.btnDeleteDeck.Click += new System.EventHandler(this.btnDeleteDeck_Click);
            // 
            // btnCreateDeck
            // 
            this.btnCreateDeck.Location = new System.Drawing.Point(203, 51);
            this.btnCreateDeck.Name = "btnCreateDeck";
            this.btnCreateDeck.Size = new System.Drawing.Size(199, 32);
            this.btnCreateDeck.TabIndex = 1;
            this.btnCreateDeck.Text = "Créer";
            this.btnCreateDeck.UseVisualStyleBackColor = true;
            this.btnCreateDeck.Click += new System.EventHandler(this.btnCreateDeck_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRenameDeck);
            this.panel2.Controls.Add(this.txtDeckName);
            this.panel2.Controls.Add(this.lblDeckName);
            this.panel2.Controls.Add(this.pctPrevDeck);
            this.panel2.Controls.Add(this.pctNextDeck);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 46);
            this.panel2.TabIndex = 0;
            // 
            // btnRenameDeck
            // 
            this.btnRenameDeck.Location = new System.Drawing.Point(309, 6);
            this.btnRenameDeck.Name = "btnRenameDeck";
            this.btnRenameDeck.Size = new System.Drawing.Size(41, 32);
            this.btnRenameDeck.TabIndex = 1;
            this.btnRenameDeck.Text = "OK";
            this.btnRenameDeck.UseVisualStyleBackColor = true;
            this.btnRenameDeck.Visible = false;
            this.btnRenameDeck.Click += new System.EventHandler(this.btnRenameDeck_Click);
            // 
            // txtDeckName
            // 
            this.txtDeckName.Location = new System.Drawing.Point(51, 11);
            this.txtDeckName.Name = "txtDeckName";
            this.txtDeckName.Size = new System.Drawing.Size(255, 22);
            this.txtDeckName.TabIndex = 7;
            this.txtDeckName.Visible = false;
            // 
            // lblDeckName
            // 
            this.lblDeckName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeckName.Location = new System.Drawing.Point(48, 4);
            this.lblDeckName.Name = "lblDeckName";
            this.lblDeckName.Size = new System.Drawing.Size(302, 39);
            this.lblDeckName.TabIndex = 1;
            this.lblDeckName.Text = "Nom de la collection";
            this.lblDeckName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDeckName.Click += new System.EventHandler(this.lblDeckName_Click);
            // 
            // pctPrevDeck
            // 
            this.pctPrevDeck.Image = global::Sowaj.Properties.Resources.button_back;
            this.pctPrevDeck.Location = new System.Drawing.Point(3, 4);
            this.pctPrevDeck.Name = "pctPrevDeck";
            this.pctPrevDeck.Size = new System.Drawing.Size(39, 39);
            this.pctPrevDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPrevDeck.TabIndex = 0;
            this.pctPrevDeck.TabStop = false;
            this.pctPrevDeck.Click += new System.EventHandler(this.pctPrevDeck_Click);
            // 
            // pctNextDeck
            // 
            this.pctNextDeck.Image = global::Sowaj.Properties.Resources.button_back;
            this.pctNextDeck.Location = new System.Drawing.Point(356, 4);
            this.pctNextDeck.Name = "pctNextDeck";
            this.pctNextDeck.Size = new System.Drawing.Size(39, 39);
            this.pctNextDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctNextDeck.TabIndex = 0;
            this.pctNextDeck.TabStop = false;
            this.pctNextDeck.Click += new System.EventHandler(this.pctNextDeck_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSaveDeck);
            this.panel3.Controls.Add(this.btnShowDeck);
            this.panel3.Controls.Add(this.btnEditDeck);
            this.panel3.Controls.Add(this.btnChooseCardsSkins);
            this.panel3.Controls.Add(this.btnSelectChampion);
            this.panel3.Controls.Add(this.btnBackToProfil);
            this.panel3.Location = new System.Drawing.Point(676, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 338);
            this.panel3.TabIndex = 1;
            // 
            // btnShowDeck
            // 
            this.btnShowDeck.Location = new System.Drawing.Point(246, 236);
            this.btnShowDeck.Name = "btnShowDeck";
            this.btnShowDeck.Size = new System.Drawing.Size(156, 46);
            this.btnShowDeck.TabIndex = 0;
            this.btnShowDeck.Text = "Visualiser ma collection";
            this.btnShowDeck.UseVisualStyleBackColor = true;
            this.btnShowDeck.Click += new System.EventHandler(this.btnShowDeck_Click);
            // 
            // btnEditDeck
            // 
            this.btnEditDeck.Location = new System.Drawing.Point(246, 184);
            this.btnEditDeck.Name = "btnEditDeck";
            this.btnEditDeck.Size = new System.Drawing.Size(156, 46);
            this.btnEditDeck.TabIndex = 0;
            this.btnEditDeck.Text = "Editer ma collection";
            this.btnEditDeck.UseVisualStyleBackColor = true;
            this.btnEditDeck.Click += new System.EventHandler(this.btnEditDeck_Click);
            // 
            // btnChooseCardsSkins
            // 
            this.btnChooseCardsSkins.Image = global::Sowaj.Properties.Resources.skinBack_1;
            this.btnChooseCardsSkins.Location = new System.Drawing.Point(15, 50);
            this.btnChooseCardsSkins.Name = "btnChooseCardsSkins";
            this.btnChooseCardsSkins.Size = new System.Drawing.Size(199, 276);
            this.btnChooseCardsSkins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnChooseCardsSkins.TabIndex = 2;
            this.btnChooseCardsSkins.TabStop = false;
            this.btnChooseCardsSkins.Click += new System.EventHandler(this.btnChooseCardsSkins_Click);
            // 
            // btnSelectChampion
            // 
            this.btnSelectChampion.Location = new System.Drawing.Point(246, 132);
            this.btnSelectChampion.Name = "btnSelectChampion";
            this.btnSelectChampion.Size = new System.Drawing.Size(156, 46);
            this.btnSelectChampion.TabIndex = 0;
            this.btnSelectChampion.Text = "Selection d\'un champion";
            this.btnSelectChampion.UseVisualStyleBackColor = true;
            this.btnSelectChampion.Click += new System.EventHandler(this.btnSelectChampion_Click);
            // 
            // btnBackToProfil
            // 
            this.btnBackToProfil.Location = new System.Drawing.Point(248, 3);
            this.btnBackToProfil.Name = "btnBackToProfil";
            this.btnBackToProfil.Size = new System.Drawing.Size(156, 46);
            this.btnBackToProfil.TabIndex = 0;
            this.btnBackToProfil.Text = "Retour profil";
            this.btnBackToProfil.UseVisualStyleBackColor = true;
            this.btnBackToProfil.Click += new System.EventHandler(this.btnBackToProfil_Click);
            // 
            // pnlChooseSkinCards
            // 
            this.pnlChooseSkinCards.Location = new System.Drawing.Point(676, 4);
            this.pnlChooseSkinCards.Name = "pnlChooseSkinCards";
            this.pnlChooseSkinCards.Size = new System.Drawing.Size(405, 339);
            this.pnlChooseSkinCards.TabIndex = 3;
            // 
            // pnlChooseChampions
            // 
            this.pnlChooseChampions.AutoScroll = true;
            this.pnlChooseChampions.Location = new System.Drawing.Point(13, 349);
            this.pnlChooseChampions.Name = "pnlChooseChampions";
            this.pnlChooseChampions.Size = new System.Drawing.Size(1235, 402);
            this.pnlChooseChampions.TabIndex = 4;
            // 
            // pnlEditDeck
            // 
            this.pnlEditDeck.AutoScroll = true;
            this.pnlEditDeck.Location = new System.Drawing.Point(13, 349);
            this.pnlEditDeck.Name = "pnlEditDeck";
            this.pnlEditDeck.Size = new System.Drawing.Size(1235, 402);
            this.pnlEditDeck.TabIndex = 5;
            // 
            // pnlShowDeck
            // 
            this.pnlShowDeck.AutoScroll = true;
            this.pnlShowDeck.Location = new System.Drawing.Point(13, 349);
            this.pnlShowDeck.Name = "pnlShowDeck";
            this.pnlShowDeck.Size = new System.Drawing.Size(1235, 402);
            this.pnlShowDeck.TabIndex = 6;
            // 
            // btnSaveDeck
            // 
            this.btnSaveDeck.Location = new System.Drawing.Point(246, 288);
            this.btnSaveDeck.Name = "btnSaveDeck";
            this.btnSaveDeck.Size = new System.Drawing.Size(156, 46);
            this.btnSaveDeck.TabIndex = 0;
            this.btnSaveDeck.Text = "Sauvegarder ma collection";
            this.btnSaveDeck.UseVisualStyleBackColor = true;
            this.btnSaveDeck.Click += new System.EventHandler(this.btnShowDeck_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Deck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 763);
            this.Controls.Add(this.pnlShowDeck);
            this.Controls.Add(this.pnlEditDeck);
            this.Controls.Add(this.pnlChooseChampions);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlChooseSkinCards);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deck";
            this.Text = "Deck";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptcChampionAvatar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrevDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNextDeck)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnChooseCardsSkins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptcChampionAvatar;
        private System.Windows.Forms.Button btnDeleteDeck;
        private System.Windows.Forms.Button btnRenameDeck;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDeckName;
        private System.Windows.Forms.PictureBox pctPrevDeck;
        private System.Windows.Forms.PictureBox pctNextDeck;
        private System.Windows.Forms.Label lblCardNumberText;
        private System.Windows.Forms.Label lblChampionName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnShowDeck;
        private System.Windows.Forms.Button btnEditDeck;
        private System.Windows.Forms.Button btnSelectChampion;
        private System.Windows.Forms.Button btnBackToProfil;
        private System.Windows.Forms.PictureBox btnChooseCardsSkins;
        private System.Windows.Forms.Panel pnlChooseSkinCards;
        private System.Windows.Forms.Panel pnlChooseChampions;
        private System.Windows.Forms.Panel pnlEditDeck;
        private System.Windows.Forms.Panel pnlShowDeck;
        private System.Windows.Forms.TextBox txtDeckName;
        private System.Windows.Forms.Button btnCreateDeck;
        private System.Windows.Forms.Label lblCardNumberInfo;
        private System.Windows.Forms.Button btnSaveDeck;
        private System.Windows.Forms.Button button1;
    }
}
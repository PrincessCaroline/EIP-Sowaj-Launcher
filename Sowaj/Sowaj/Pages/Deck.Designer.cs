﻿namespace Sowaj
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
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblChampionName = new System.Windows.Forms.Label();
            this.ptcChampionAvatar = new System.Windows.Forms.PictureBox();
            this.btnDeleteDeck = new System.Windows.Forms.Button();
            this.btnRenameDeck = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panel1.Controls.Add(this.lblCardNumber);
            this.panel1.Controls.Add(this.lblChampionName);
            this.panel1.Controls.Add(this.ptcChampionAvatar);
            this.panel1.Controls.Add(this.btnDeleteDeck);
            this.panel1.Controls.Add(this.btnRenameDeck);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(264, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 339);
            this.panel1.TabIndex = 0;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.Location = new System.Drawing.Point(232, 315);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(167, 23);
            this.lblCardNumber.TabIndex = 4;
            this.lblCardNumber.Text = "Nombre de carte : 0/30";
            this.lblCardNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChampionName
            // 
            this.lblChampionName.Location = new System.Drawing.Point(4, 310);
            this.lblChampionName.Name = "lblChampionName";
            this.lblChampionName.Size = new System.Drawing.Size(163, 32);
            this.lblChampionName.TabIndex = 3;
            this.lblChampionName.Text = "Nerye";
            this.lblChampionName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptcChampionAvatar
            // 
            this.ptcChampionAvatar.Image = global::Sowaj.Properties.Resources.Neryë;
            this.ptcChampionAvatar.Location = new System.Drawing.Point(4, 84);
            this.ptcChampionAvatar.Name = "ptcChampionAvatar";
            this.ptcChampionAvatar.Size = new System.Drawing.Size(163, 223);
            this.ptcChampionAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcChampionAvatar.TabIndex = 2;
            this.ptcChampionAvatar.TabStop = false;
            // 
            // btnDeleteDeck
            // 
            this.btnDeleteDeck.Location = new System.Drawing.Point(203, 50);
            this.btnDeleteDeck.Name = "btnDeleteDeck";
            this.btnDeleteDeck.Size = new System.Drawing.Size(199, 32);
            this.btnDeleteDeck.TabIndex = 1;
            this.btnDeleteDeck.Text = "Supprimer";
            this.btnDeleteDeck.UseVisualStyleBackColor = true;
            // 
            // btnRenameDeck
            // 
            this.btnRenameDeck.Location = new System.Drawing.Point(4, 50);
            this.btnRenameDeck.Name = "btnRenameDeck";
            this.btnRenameDeck.Size = new System.Drawing.Size(199, 32);
            this.btnRenameDeck.TabIndex = 1;
            this.btnRenameDeck.Text = "Renomer";
            this.btnRenameDeck.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDeckName);
            this.panel2.Controls.Add(this.pctPrevDeck);
            this.panel2.Controls.Add(this.pctNextDeck);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 46);
            this.panel2.TabIndex = 0;
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
            // 
            // panel3
            // 
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
            this.btnShowDeck.Location = new System.Drawing.Point(246, 279);
            this.btnShowDeck.Name = "btnShowDeck";
            this.btnShowDeck.Size = new System.Drawing.Size(156, 46);
            this.btnShowDeck.TabIndex = 0;
            this.btnShowDeck.Text = "Visualiser mon deck";
            this.btnShowDeck.UseVisualStyleBackColor = true;
            this.btnShowDeck.Click += new System.EventHandler(this.btnShowDeck_Click);
            // 
            // btnEditDeck
            // 
            this.btnEditDeck.Location = new System.Drawing.Point(246, 227);
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
            this.btnSelectChampion.Location = new System.Drawing.Point(246, 175);
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
        private System.Windows.Forms.Label lblCardNumber;
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
    }
}
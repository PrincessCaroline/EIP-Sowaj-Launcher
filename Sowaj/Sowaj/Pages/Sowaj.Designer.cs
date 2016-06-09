namespace Sowaj
{
    partial class Sowaj
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.pnlProfil = new System.Windows.Forms.Panel();
            this.pnlDeck = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Location = new System.Drawing.Point(451, 290);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(369, 225);
            this.pnlLogin.TabIndex = 0;
            // 
            // pnlRegister
            // 
            this.pnlRegister.BackColor = System.Drawing.Color.Transparent;
            this.pnlRegister.Location = new System.Drawing.Point(379, 153);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(518, 505);
            this.pnlRegister.TabIndex = 1;
            // 
            // pnlProfil
            // 
            this.pnlProfil.BackColor = System.Drawing.Color.Transparent;
            this.pnlProfil.Location = new System.Drawing.Point(0, 0);
            this.pnlProfil.Name = "pnlProfil";
            this.pnlProfil.Size = new System.Drawing.Size(1276, 810);
            this.pnlProfil.TabIndex = 3;
            // 
            // pnlDeck
            // 
            this.pnlDeck.BackColor = System.Drawing.Color.Transparent;
            this.pnlDeck.Location = new System.Drawing.Point(0, 0);
            this.pnlDeck.Name = "pnlDeck";
            this.pnlDeck.Size = new System.Drawing.Size(1276, 810);
            this.pnlDeck.TabIndex = 3;
            // 
            // Sowaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sowaj.Properties.Resources.CvdYfYz;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 763);
            this.Controls.Add(this.pnlDeck);
            this.Controls.Add(this.pnlProfil);
            this.Controls.Add(this.pnlRegister);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Sowaj";
            this.Text = "Sowaj";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Panel pnlProfil;
        private System.Windows.Forms.Panel pnlDeck;
    }
}


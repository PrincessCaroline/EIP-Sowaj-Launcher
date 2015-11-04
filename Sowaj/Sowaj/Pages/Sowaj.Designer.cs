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
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogin.Location = new System.Drawing.Point(639, 269);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(365, 221);
            this.pnlLogin.TabIndex = 0;
            // 
            // pnlRegister
            // 
            this.pnlRegister.Location = new System.Drawing.Point(616, 269);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(408, 409);
            this.pnlRegister.TabIndex = 1;
            // 
            // pnlProfil
            // 
            this.pnlProfil.Location = new System.Drawing.Point(191, 62);
            this.pnlProfil.Name = "pnlProfil";
            this.pnlProfil.Size = new System.Drawing.Size(1276, 810);
            this.pnlProfil.TabIndex = 2;
            // 
            // Sowaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 953);
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
    }
}


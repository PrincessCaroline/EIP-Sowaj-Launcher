namespace Sowaj
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoginWrong = new System.Windows.Forms.Label();
            this.txtPasswordcomfirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFillAllField = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailcomfirm = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblMailWrong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPasswordWrong = new System.Windows.Forms.Label();
            this.pctLoginAvaible = new System.Windows.Forms.PictureBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dteBirthdate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pctLoginAvaible)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Pseudo";
            // 
            // lblLoginWrong
            // 
            this.lblLoginWrong.AutoSize = true;
            this.lblLoginWrong.ForeColor = System.Drawing.Color.Crimson;
            this.lblLoginWrong.Location = new System.Drawing.Point(12, 55);
            this.lblLoginWrong.Name = "lblLoginWrong";
            this.lblLoginWrong.Size = new System.Drawing.Size(300, 17);
            this.lblLoginWrong.TabIndex = 28;
            this.lblLoginWrong.Text = "Votre pseudo doit avoir plus de 5 charactères.";
            // 
            // txtPasswordcomfirm
            // 
            this.txtPasswordcomfirm.Location = new System.Drawing.Point(12, 266);
            this.txtPasswordcomfirm.Name = "txtPasswordcomfirm";
            this.txtPasswordcomfirm.Size = new System.Drawing.Size(236, 22);
            this.txtPasswordcomfirm.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Adresse Email";
            // 
            // lblFillAllField
            // 
            this.lblFillAllField.AutoSize = true;
            this.lblFillAllField.ForeColor = System.Drawing.Color.Crimson;
            this.lblFillAllField.Location = new System.Drawing.Point(9, 472);
            this.lblFillAllField.Name = "lblFillAllField";
            this.lblFillAllField.Size = new System.Drawing.Size(220, 17);
            this.lblFillAllField.TabIndex = 27;
            this.lblFillAllField.Text = "Tout les champs sont obligatoires";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Comfirmer l\'adresse Email";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 221);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(236, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(402, 466);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(97, 29);
            this.btnCreateAccount.TabIndex = 9;
            this.btnCreateAccount.Text = "S\'enregistrer";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mot de Passe";
            // 
            // txtEmailcomfirm
            // 
            this.txtEmailcomfirm.Location = new System.Drawing.Point(12, 148);
            this.txtEmailcomfirm.Name = "txtEmailcomfirm";
            this.txtEmailcomfirm.Size = new System.Drawing.Size(236, 22);
            this.txtEmailcomfirm.TabIndex = 3;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(12, 31);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(236, 22);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave);
            // 
            // lblMailWrong
            // 
            this.lblMailWrong.AutoSize = true;
            this.lblMailWrong.ForeColor = System.Drawing.Color.Crimson;
            this.lblMailWrong.Location = new System.Drawing.Point(12, 172);
            this.lblMailWrong.Name = "lblMailWrong";
            this.lblMailWrong.Size = new System.Drawing.Size(379, 17);
            this.lblMailWrong.TabIndex = 26;
            this.lblMailWrong.Text = "Votre mail de confirmation doit être identique à votre email.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Comfirmer le mot de passe";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 102);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(236, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // lblPasswordWrong
            // 
            this.lblPasswordWrong.AutoSize = true;
            this.lblPasswordWrong.ForeColor = System.Drawing.Color.Crimson;
            this.lblPasswordWrong.Location = new System.Drawing.Point(12, 290);
            this.lblPasswordWrong.Name = "lblPasswordWrong";
            this.lblPasswordWrong.Size = new System.Drawing.Size(491, 17);
            this.lblPasswordWrong.TabIndex = 26;
            this.lblPasswordWrong.Text = "Votre mot de passe de confirmation doit être identique à votre mot de passe.";
            // 
            // pctLoginAvaible
            // 
            this.pctLoginAvaible.Image = global::Sowaj.Properties.Resources._1447310536_bullet_valid;
            this.pctLoginAvaible.Location = new System.Drawing.Point(254, 18);
            this.pctLoginAvaible.Name = "pctLoginAvaible";
            this.pctLoginAvaible.Size = new System.Drawing.Size(41, 42);
            this.pctLoginAvaible.TabIndex = 29;
            this.pctLoginAvaible.TabStop = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(15, 319);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 17);
            this.lblFirstName.TabIndex = 30;
            this.lblFirstName.Text = "Prénom";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(12, 338);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(236, 22);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(12, 384);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(236, 22);
            this.txtLastName.TabIndex = 7;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(15, 364);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(101, 17);
            this.lblLastName.TabIndex = 30;
            this.lblLastName.Text = "Nom de famille";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(15, 409);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(126, 17);
            this.lblBirthDate.TabIndex = 30;
            this.lblBirthDate.Text = "Date de naissance";
            // 
            // dteBirthdate
            // 
            this.dteBirthdate.Location = new System.Drawing.Point(13, 429);
            this.dteBirthdate.Name = "dteBirthdate";
            this.dteBirthdate.Size = new System.Drawing.Size(200, 22);
            this.dteBirthdate.TabIndex = 8;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 501);
            this.Controls.Add(this.dteBirthdate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLoginWrong);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtPasswordcomfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFillAllField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmailcomfirm);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPasswordWrong);
            this.Controls.Add(this.lblMailWrong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pctLoginAvaible);
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pctLoginAvaible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoginWrong;
        private System.Windows.Forms.TextBox txtPasswordcomfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFillAllField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailcomfirm;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblMailWrong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPasswordWrong;
        private System.Windows.Forms.PictureBox pctLoginAvaible;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dteBirthdate;
    }
}
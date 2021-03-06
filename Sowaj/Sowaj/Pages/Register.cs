﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sowaj
{
    public partial class Register : Form
    {
        Sowaj s;

        public Register(Sowaj _s)
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtPasswordcomfirm.PasswordChar = '*';
            hideError();
            pctLoginAvaible.Hide();

            s = _s;
        }

        private void hideError()
        {
            lblLoginWrong.Hide();
            lblMailWrong.Text = "Votre pseudo doit avoir plus de 5 charactères.";
            lblMailWrong.Hide();
            lblMailWrong.Text = "Votre mail de confirmation doit être identique à votre email.";
            lblPasswordWrong.Hide();
            lblPasswordWrong.Text = "Votre mot de passe de confirmation doit être identique à votre mot de passe.";
            lblFillAllField.Hide();
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            pctLoginAvaible.Hide();
            RequestServer newreq = new RequestServer();

            if (newreq.LoginAvaible(txtLogin.Text) == false)
            {
                lblLoginWrong.Text = "Le pseudo que vous avez choisit n'est pas disponible.";
                lblLoginWrong.Show();
                btnCreateAccount.Hide();
            }
            else
            {
                lblLoginWrong.Hide();
                btnCreateAccount.Show();
                pctLoginAvaible.Show();
            }

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            hideError();
            bool allGood = true;
            //Check if all label is fill
            if (txtPassword.Text != "" &&
                txtEmailcomfirm.Text != "" &&
                txtPasswordcomfirm.Text != "" &&
                txtEmail.Text != "" &&
                txtLogin.Text != "" &&
                txtFirstName.Text != "" &&
                txtLastName.Text != "")
            {
                if (txtLogin.Text.Length < 5)
                {
                    lblLoginWrong.Show();
                    allGood = false;
                }
                if (IsValidEmail(txtEmail.Text) != false)
                {
                    if (txtEmail.Text != txtEmailcomfirm.Text)
                    {
                        lblMailWrong.Show();
                        allGood = false;
                    }
                }
                else
                {
                    lblMailWrong.Text = "Votre e-mail n'est pas valide.";
                    lblMailWrong.Show();
                    allGood = false;
                }
                if (txtPassword.Text.Length > 7)
                {
                    if (txtPassword.Text != txtLogin.Text)
                    {
                        if (txtPassword.Text != txtPasswordcomfirm.Text)
                        {
                            lblPasswordWrong.Show();
                            allGood = false;
                        }
                    }
                    else
                    {
                        lblPasswordWrong.Text = "Vous devez choisir un mot de passe différent de votre pseudo.";
                        lblPasswordWrong.Show();
                        allGood = false;
                    }
                }
                else
                {
                    lblPasswordWrong.Text = "Votre mot de passe doit avoir plus de 7 charactères.";
                    lblPasswordWrong.Show();
                    allGood = false;
                }

                //If every fields are correct  send Request to register.
                if (allGood == true)
                {
                    RequestServer newreq = new RequestServer();
                    if (newreq.Register(txtLogin.Text, 
                                        txtPassword.Text, 
                                        txtEmail.Text, 
                                        txtFirstName.Text, 
                                        txtLastName.Text, "KR", 
                                        dteBirthdate.Value.Date.ToString("dd/MM/yyyy")) == true)
                        {
                            s.AffLogin();
                        }
                        else
                        {
                            MessageBox.Show("L'inscription à echoué :'(");
                        }
                }
            }
            else
                lblFillAllField.Show();
        }

    }
}

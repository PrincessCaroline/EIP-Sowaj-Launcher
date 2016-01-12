using System;
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
    public partial class Login : Form
    {
        Sowaj s;

        public Login(Sowaj _s)
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            s = _s;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RequestServer newreq = new RequestServer();
            ParserJSON parser = new ParserJSON();

            try
            {
                var addr = new System.Net.Mail.MailAddress(txtUsername.Text);
                s.tokenConnection = parser.ServerConnect("", txtPassword.Text, txtUsername.Text);
            }
            catch
            {
                s.tokenConnection = parser.ServerConnect(txtUsername.Text, txtPassword.Text, "");
            }

            if (s.tokenConnection.connectionAccepted == true)
            {
                s.AffProfil();
            }
            else
            {
                MessageBox.Show("Informations de connection incorrectes.");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            s.AffRegister();
        }
    }
}

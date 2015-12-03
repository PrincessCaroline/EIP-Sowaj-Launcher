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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RequestServer newreq = new RequestServer();

            if (newreq.ServerConnect(txtUsername.Text, txtPassword.Text, "mail") == true)
           // if (0 == 0)
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

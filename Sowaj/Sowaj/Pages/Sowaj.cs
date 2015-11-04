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
    public partial class Sowaj : Form
    {

        public Sowaj()
        {
            InitializeComponent();            
            InitializePanel();
            AffLogin();
        }

        private void hidePanel()
        {
            pnlLogin.Hide();
            pnlRegister.Hide();
            pnlProfil.Hide();
        }

        public void AffLogin()
        {
            hidePanel();
            pnlLogin.Show();
        }        
        public void AffRegister()
        {
            hidePanel();
            pnlRegister.Show();
        }

        public void AffProfil()
        {
            hidePanel();
            pnlProfil.Show();
        }

        private void InitializePanel()
        {
            Console.WriteLine("je commence a init mes panels");
            Login       loginForm = new Login(this);
            Register    regForm = new Register(this);
            Profil      profilForm = new Profil(this);

            //fill login panel with login form
            loginForm.TopLevel = false;
            pnlLogin.Controls.Add(loginForm);
            loginForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            loginForm.Dock = DockStyle.Fill;
            loginForm.Show();
            Console.WriteLine("login panel init : DONE");

            //fill register panel with register form
            regForm.TopLevel = false;
            pnlRegister.Controls.Add(regForm);
            regForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            regForm.Dock = DockStyle.Fill;
            regForm.Show();
            Console.WriteLine("reg panel init: DONE");

            //fill profil panel with profil form
            profilForm.TopLevel = false;
            pnlProfil.Controls.Add(profilForm);
            profilForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            profilForm.Dock = DockStyle.Fill;
            profilForm.Show();
            Console.WriteLine("profil panel init: DONE");
        }
    }
}

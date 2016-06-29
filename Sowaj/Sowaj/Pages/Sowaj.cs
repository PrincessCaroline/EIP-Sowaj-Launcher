using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sowaj
{
    public partial class Sowaj : Form
    {
        public SoundPlayer music = new SoundPlayer(@"C:\Users\PrincessCaroline\Documents\GitHub\EIP-Sowaj-Launcher\Sowaj\Sowaj\Resources\music.wav");
        public Token tokenConnection;
        public ClientInfos client = new ClientInfos();

        public Sowaj()
        {
            InitializeComponent();
            InitializePanel_BeforeConnection();
            Profil tmp = new Profil(this);
            tmp.Show();
            AffLogin();
        }

        private void hidePanel()
        {
            pnlLogin.Hide();
            pnlRegister.Hide();
            pnlProfil.Hide();
            pnlDeck.Hide();
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
            InitializePanel_AfterConnection();
            hidePanel();
            pnlProfil.Show();
        }

        public void AffDeck()
        {
            hidePanel();
            pnlDeck.Show();
        }

        private void InitializePanel_BeforeConnection()
        {
            Console.WriteLine("je commence a init mes panels");
            Login       loginForm = new Login(this);
            Register    regForm = new Register(this);

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
        }
        private void InitializePanel_AfterConnection()
        {
            Profil profilForm = new Profil(this);

            //fill profil panel with profil form
            profilForm.TopLevel = false;
            pnlProfil.Controls.Add(profilForm);
            profilForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            profilForm.Dock = DockStyle.Fill;
            profilForm.Show();
            Console.WriteLine("profil panel init: DONE");

           Deck deckForm = new Deck(this);

            //fill profil panel with profil form
            deckForm.TopLevel = false;
            pnlDeck.Controls.Add(deckForm);
            deckForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            deckForm.Dock = DockStyle.Fill;
            deckForm.Show();
            Console.WriteLine("deck panel init: DONE");
        }

    }
}

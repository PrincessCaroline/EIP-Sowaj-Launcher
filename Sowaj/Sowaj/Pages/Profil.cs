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
    public partial class Profil : Form
    {
        Sowaj s;

        public Profil(Sowaj _s)
        {
            InitializeComponent();
            s = _s;
            InitializePanels();
            pnlAvatarChoose.Hide();
            FirstConnection();
        }

        private void InitializePanels()
        {
            ChooseAvatar chooseAvatarPanel = new ChooseAvatar(this);
            chooseAvatarPanel.TopLevel = false;
            pnlAvatarChoose.Controls.Add(chooseAvatarPanel);
            chooseAvatarPanel.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            chooseAvatarPanel.Dock = DockStyle.Fill;
            chooseAvatarPanel.Show();
        }

        private void FirstConnection()
        {
            ChooseClass chooseClass = new ChooseClass(this);

            //fill profil panel with profil form
            chooseClass.TopLevel = false;
            pnlChooseClass.Controls.Add(chooseClass);
            chooseClass.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            chooseClass.Dock = DockStyle.Fill;
            chooseClass.Show();
//            Console.WriteLine("profil panel init: DONE");
        }

        public void setClass(int classIndex)
        {
            pnlChooseClass.Hide();
        }

        public void setAvatar(Image newAvatar)
        {
            btnAvatar.Image = newAvatar;
            pnlAvatarChoose.Hide();
        }

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            pnlAvatarChoose.Show();
        }
    }
}

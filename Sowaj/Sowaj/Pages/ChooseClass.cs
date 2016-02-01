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
    public partial class ChooseClass : Form
    {
        Profil p;
        public ChooseClass(Profil _p)
        {
            InitializeComponent();
            p = _p;
            HidePanel();
        }

        private void HidePanel()
        {
            pnlStoryHuman.Hide();
            pnlStoryElves.Hide();
            pnlStoryDwarfs.Hide();
            pnlChooseClass.Hide();
            pnlChooseElves.Hide();
            pnlChooseDwarfs.Hide();
            pnlChooseHuman.Hide();
        }

        //First next : GOTO choose nickname
        private void button1_Click(object sender, EventArgs e)
        {
            pnlStoryIntro.Hide();
            pnlStoryHuman.Show();
        }

        //2nd next : GOTO  Storyhuman
        private void btnNext_Click(object sender, EventArgs e)
        {
            pnlStoryHuman.Hide();
            pnlStoryDwarfs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlStoryElves.Hide();
            pnlChooseClass.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlStoryDwarfs.Hide();
            pnlStoryElves.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pnlChooseElves.Show();
        }

        private void btnChooseDwarfs_Click(object sender, EventArgs e)
        {
            pnlChooseDwarfs.Show();
        }

        private void btnChooseHuman_Click(object sender, EventArgs e)
        {
            pnlChooseHuman.Show();
        }

        private void btnClosePnlHuman_Click(object sender, EventArgs e)
        {
            pnlChooseHuman.Hide();
        }

        private void btnClosePnlDwarfs_Click(object sender, EventArgs e)
        {
            pnlChooseDwarfs.Hide();
        }

        private void btnClosePnlElves_Click(object sender, EventArgs e)
        {
            pnlChooseElves.Hide();
        }

        private void btnChoosingElves_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous avez choisi d'être  un elfe, excellent choix...pour une fille.");
            p.setClass(0);
        }

        private void btnChoosingDwarfs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous avez choisi d'être  un nain, je suis mitigée...");
            p.setClass(1);
        }

        private void btnChoosingHuman_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous avez choisi d'être  un nain, pas très original...");
            p.setClass(2);
        }
    }
}

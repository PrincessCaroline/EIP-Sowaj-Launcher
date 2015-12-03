using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;
using System.Resources;

namespace Sowaj
{
    public partial class Profil : Form
    {
        ResourceManager res_man = new ResourceManager(typeof(fr));    // declare Resource manager to access to specific cultureinfo

        public Sowaj s;
        private ClientInfos client = new ClientInfos();

        public void switch_language(char c)
        {
            if (c == 'f')    //in vietnamese
            {
                 res_man = new ResourceManager(typeof(fr));
            }
            else                                                //in english
            {
                res_man = new ResourceManager(typeof(en));
            }
            load_text();
        }

        private void load_text()
        {
            btnPlay.Text = res_man.GetString("btnPlay");
        }

        public Profil(Sowaj _s)
        {
            InitializeComponent();
            s = _s;
            s.music.Play();
            InitializePanels();
            HidePanel();
            InitializeClientInfos();
            //FirstConnection();
            load_text();
        }

        private void InitializePanels()
        {
            ChooseAvatar chooseAvatarPanel = new ChooseAvatar(this);
            chooseAvatarPanel.TopLevel = false;
            pnlAvatarChoose.Controls.Add(chooseAvatarPanel);
            chooseAvatarPanel.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            chooseAvatarPanel.Dock = DockStyle.Fill;
            chooseAvatarPanel.Show();

            Options optionPanel = new Options(this);
            optionPanel.TopLevel = false;
            pnlOptions.Controls.Add(optionPanel);
            optionPanel.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            optionPanel.Dock = DockStyle.Fill;
            optionPanel.Show();

            ChooseClass chooseClass = new ChooseClass(this);
            chooseClass.TopLevel = false;
            pnlChooseClass.Controls.Add(chooseClass);
            chooseClass.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            chooseClass.Dock = DockStyle.Fill;
            chooseClass.Show();

        }
        private void HidePanel()
        {
            pnlAvatarChoose.Hide();
            pnlOptions.Hide();
            pnlChooseClass.Hide();
        }
        private void FirstConnection()
        {

        }

        private void InitializeClientInfos()
        {
            client.ClientInfos_Init();
            lblLogin.Text = client.getPlayerName();
            lblExperience.Text = client.getExp() + "/1000";
            progressBarExperience.Maximum = 1000;
            progressBarExperience.Minimum = 0;
            progressBarExperience.Value = client.getExp();
            lblLevelNumber.Text = client.getLevel().ToString();
            lblGamesNumber.Text = client.getNBgames().ToString();
            lblVictoryNumber.Text = client.getNBvictories().ToString();
            lblLooseNumber.Text = client.getNBdefeats().ToString();


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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlOptions.Show();
        }

        public void closeOptions()
        {
            pnlOptions.Hide();
        }
    }
}

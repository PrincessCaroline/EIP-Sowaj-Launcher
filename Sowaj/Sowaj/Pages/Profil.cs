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
  
        public Profil(Sowaj _s)
        {
            InitializeComponent();
            s = _s;
            //s.music.Play();
            InitializePanels();
            HidePanel();
            pnlRankInfos.Show();
            s.client.setUnknow();
            InitializeClientInfos();
            FirstConnection();
            load_text();
        }

        private void InitializePanels()
        {
            setHistory();

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

            Ranking ranking = new Ranking(this);
            ranking.TopLevel = false;
            pnlRanking.Controls.Add(ranking);
            ranking.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ranking.Dock = DockStyle.Fill;
            ranking.Show();
        }
        private void HidePanel()
        {
            pnlAvatarChoose.Hide();
            pnlOptions.Hide();
            pnlChooseClass.Hide();
            pnlRanking.Hide();
            pnlFightHistory.Hide();
            pnlRankInfos.Hide();
        }
        private void FirstConnection()
        {            
            pnlChooseClass.Show();
        }

        //Method concerned by languages
        public void switch_language(char c)
        {
            if (c == 'f')
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
            btnDeck.Text = res_man.GetString("btnDeck");
            btnFriends.Text = res_man.GetString("btnFriends");
            btnShop.Text = res_man.GetString("btnShop");
            lblCard.Text = res_man.GetString("lblCard");
            lblRank.Text = res_man.GetString("lblRank");
            btnMoney.Text = res_man.GetString("lblMoney");
            lblTrophy.Text = res_man.GetString("lblTrophy");
            lblGames.Text = res_man.GetString("lblGames");
            lblVictory.Text = res_man.GetString("lblVictory");
            lblLoose.Text = res_man.GetString("lblLoose");
            btnSettings.Text = res_man.GetString("btnSettings");
        }

        public void InitializeClientInfos()
        {
            lblLogin.Text = s.client.nickName;
            lblExperience.Text = s.client.points + "/" + s.client.maximum_points;
            progressBarExperience.Maximum = 1000;
            progressBarExperience.Minimum = 0;
            progressBarExperience.Value = s.client.points;
            lblLevelNumber.Text = s.client.level.ToString();
            //lblGamesNumber.Text = client.getNBgames().ToString();
            //lblVictoryNumber.Text = client.getNBvictories().ToString();
            //lblLooseNumber.Text = client.getNBdefeats().ToString();
        }

        public void setClass(int classIndex)
        {
            pnlChooseClass.Hide();
        }


        //Method concerned by the AVATAR
        public void setAvatar(Image newAvatar)
        {
            btnAvatar.Image = newAvatar;
            pnlAvatarChoose.Hide();
            pnlFightHistory.Show();
            pnlRankInfos.Show();
        }

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            HidePanel();
            pnlAvatarChoose.Show();
            //pnlFightHistory.Hide();
            //pnlRankInfos.Hide();
        }


        //Method concerned by the SETTINGS
        private void btnSettings_Click(object sender, EventArgs e)
        {
            HidePanel();
            pnlOptions.Show();
        }

        public void btnSettings_Close()
        {
            pnlOptions.Hide();
            pnlFightHistory.Show();
            pnlRankInfos.Show();
        }



        //Method concerned by the HISTORY
        public int YPanelLocation = 1;
        private Panel getFightHistory()
        {
            Panel newPanel = new Panel();
            DetailPartie detail = new DetailPartie();

            //setposition and size of the panel
            newPanel.Location = new Point(1, YPanelLocation);
            newPanel.Size = new Size(600, 186);

            //add detailpartie view to newpanel
            detail.TopLevel = false;
            newPanel.Controls.Add(detail);
            detail.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            detail.Dock = DockStyle.Fill;
            detail.Show();

            //add panel to this view
            this.Controls.Add(newPanel);

            YPanelLocation += 186;
            return (newPanel);
        }

        private int gameNbr = 0;
        private void setHistory()
        {
            pnlFightHistory.Controls.Clear();
            YPanelLocation = 1;
            for (int i = 0; i < gameNbr; i++)
            {
                pnlFightHistory.Controls.Add(getFightHistory());
            }
        }


        //Method conserned by the RANKING
        private void btnRanking_Click(object sender, EventArgs e)
        {
            HidePanel();
            pnlRanking.Show();
        }

        public void closeRanking()
        {
            pnlRanking.Hide();
            pnlFightHistory.Show();
            pnlRankInfos.Show();
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            gameNbr++;
            setHistory();
        }


        private void btnFriends_Click(object sender, EventArgs e)
        {

        }
    }
}

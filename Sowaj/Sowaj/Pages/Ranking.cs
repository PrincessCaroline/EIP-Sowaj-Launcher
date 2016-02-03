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
    public partial class Ranking : Form
    {
        Profil p;
        public Ranking(Profil _p)
        {
            InitializeComponent();
            setRankingFriendsProfilsInfos();
            setRankingWorldProfilsInfos();
            setRankingLocalProfilsInfos();
            p = _p;
        }

        int YPanelLocation = 1;
        private Panel getRankingProfilInfos()
        {
            Panel newPanel = new Panel();
            RankingProfilsInfos detail = new RankingProfilsInfos();

            //setposition and size of the panel
            newPanel.Location = new Point(1, YPanelLocation);
            newPanel.Size = new Size(500, 80);

            //add detailpartie view to newpanel
            detail.TopLevel = false;
            newPanel.Controls.Add(detail);
            detail.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            detail.Dock = DockStyle.Fill;
            detail.Show();

            //add panel to this view
            this.Controls.Add(newPanel);

            YPanelLocation += 80;
            return (newPanel);
        }

        private void setRankingFriendsProfilsInfos()
        {
            tabPageFriends.Controls.Clear();
            YPanelLocation = 1;
            for (int i = 0; i < 2; i++)
            {
                tabPageFriends.Controls.Add(getRankingProfilInfos());
            }
        }

        private void setRankingWorldProfilsInfos()
        {
            tabPageWorld.Controls.Clear();
            YPanelLocation = 1;
            for (int i = 0; i < 20; i++)
            {
                tabPageWorld.Controls.Add(getRankingProfilInfos());
            }
        }

        private void setRankingLocalProfilsInfos()
        {
            tabPageLocal.Controls.Clear();
            YPanelLocation = 1;
            for (int i = 0; i < 10; i++)
            {
                tabPageLocal.Controls.Add(getRankingProfilInfos());
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            p.closeRanking();
        }
    }
}

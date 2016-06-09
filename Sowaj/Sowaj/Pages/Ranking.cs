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
            p = _p;
            setRankingFriendsProfilsInfos();
            setRankingWorldProfilsInfos();
            setRankingLocalProfilsInfos();
        }

        int YPanelLocation = 1;
        private Panel getRankingProfilInfos(ClientInfos profilInfos)
        {
            Panel newPanel = new Panel();
            RankingProfilsInfos detail = new RankingProfilsInfos();
            detail.SetRankingProfilsInfos(profilInfos);

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
            ParserJSON parser = new ParserJSON();
            RequestServer newreq = new RequestServer();

            String rsp = newreq.RankOverall(p.s.client.profile_id, "friend", p.s.tokenConnection.Tok);
            ClientInfos_List tmp = parser.RankOverall(rsp);

            YPanelLocation = 1;
            for (int i = 0; i < tmp.data.Count() ; i++)
            {
                tabPageFriends.Controls.Add(getRankingProfilInfos(tmp.data[i]));
            }
        }

        private void setRankingWorldProfilsInfos()
        {
            tabPageWorld.Controls.Clear();
            ParserJSON parser = new ParserJSON();
            RequestServer newreq = new RequestServer();

            String rsp = newreq.RankOverall(p.s.client.profile_id, "all", p.s.tokenConnection.Tok);
            ClientInfos_List tmp = parser.RankOverall(rsp);
            YPanelLocation = 1;
            for (int i = 0; i < tmp.data.Count(); i++)
            {
                tabPageFriends.Controls.Add(getRankingProfilInfos(tmp.data[i]));
            }
        }

        private void setRankingLocalProfilsInfos()
        {
            tabPageLocal.Controls.Clear();
            ParserJSON parser = new ParserJSON();
            RequestServer newreq = new RequestServer();

            String rsp = newreq.RankOverall(p.s.client.profile_id, "nat", p.s.tokenConnection.Tok);
            ClientInfos_List tmp = parser.RankOverall(rsp);
            YPanelLocation = 1;
            for (int i = 0; i < tmp.data.Count(); i++)
            {
                tabPageFriends.Controls.Add(getRankingProfilInfos(tmp.data[i]));
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            p.closeRanking();
        }
    }
}

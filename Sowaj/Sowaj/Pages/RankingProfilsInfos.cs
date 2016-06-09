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
    public partial class RankingProfilsInfos : Form
    {
        public RankingProfilsInfos()
        {
            InitializeComponent();
        }

        public void SetRankingProfilsInfos(ClientInfos profilInfos)
        {
            lblNickname.Text = profilInfos.nickname;
            lblRankPoints.Text = profilInfos.points.ToString() + " PVP points";
        }

    }
}

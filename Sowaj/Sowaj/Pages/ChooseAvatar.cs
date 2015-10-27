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
    public partial class ChooseAvatar : Form
    {
        Profil p;
        public ChooseAvatar(Profil _p)
        {
            InitializeComponent();
            p = _p;
        }

        private void Avatar1_Click(object sender, EventArgs e)
        {
            p.setAvatar(Avatar1.Image);
        }

        private void Avatar2_Click(object sender, EventArgs e)
        {
            p.setAvatar(Avatar2.Image);
        }

        private void Avatar3_Click(object sender, EventArgs e)
        {
            p.setAvatar(Avatar3.Image);
        }

        private void Avatar4_Click(object sender, EventArgs e)
        {
            p.setAvatar(Avatar4.Image);
        }

        private void Avatar5_Click(object sender, EventArgs e)
        {
            p.setAvatar(Avatar5.Image);
        }

        private void Avatar6_Click(object sender, EventArgs e)
        {
            p.setAvatar(Avatar6.Image);
        }

        private void Avatar7_Click(object sender, EventArgs e)
        {
            p.setAvatar(Avatar7.Image);
        }

        private void Avatar8_Click(object sender, EventArgs e)
        {
            p.setAvatar(Avatar8.Image);
        }
    }
}

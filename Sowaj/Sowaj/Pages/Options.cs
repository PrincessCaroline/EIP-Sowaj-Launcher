using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Sowaj
{
    public partial class Options : Form
    {
        Profil p;
        public Options(Profil _p)
        {
            InitializeComponent();
            p = _p;
        }

        private void btnMusicOn_Click(object sender, EventArgs e)
        {
            p.s.music.Play();
        }

        private void btnMusicOff_Click(object sender, EventArgs e)
        {
            p.s.music.Stop();
        }

        private void btnSoundOn_Click(object sender, EventArgs e)
        {

        }

        private void btnSoundOff_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            p.closeOptions();
        }
    }
}

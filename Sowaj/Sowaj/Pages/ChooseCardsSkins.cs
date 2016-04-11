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
    public partial class ChooseCardsSkins : Form
    {
        Deck d;

        public ChooseCardsSkins(Deck _d)
        {
            InitializeComponent();
            d = _d;
        }

        private void cardSkin_1_Click(object sender, EventArgs e)
        {
            d.setCardsSkin(cardSkin_1.Image);
        }

        private void cardSkin_2_Click(object sender, EventArgs e)
        {
            d.setCardsSkin(cardSkin_2.Image);
        }

        private void cardSkin_3_Click(object sender, EventArgs e)
        {
            d.setCardsSkin(cardSkin_3.Image);
        }

        private void cardSkin_4_Click(object sender, EventArgs e)
        {
            d.setCardsSkin(cardSkin_4.Image);
        }

        private void cardSkin_5_Click(object sender, EventArgs e)
        {
            d.setCardsSkin(cardSkin_5.Image);
        }

        private void cardSkin_6_Click(object sender, EventArgs e)
        {
            d.setCardsSkin(cardSkin_6.Image);
        }
    }
}

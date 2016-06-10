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
    public partial class Card : Form
    {
        Deck        d;
        CardInfos   infos;

        public Card(Deck _d, CardInfos _i)
        {
            InitializeComponent();
            d = _d;
            infos = _i;
            if (infos.isEditable == false)
                this.btnAddCard.Hide();
        }
        
        public void     setCardInfos()
        {
            lblCardName.Text = infos.idCard.ToString();
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            bool inDeck = false;

            if (infos.isEditable == true)
            {
                foreach (CardInfos element in d.currentDeck.card_list)
                {
                    if (infos.idCard == element.idCard)
                        inDeck = true;
                }
                if (inDeck == false)
                    d.currentDeck.AddCard(infos.idCard);
            }
        }
    }
}

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
    public partial class Deck : Form
    {
        Sowaj s;
        public Deck(Sowaj _s)
        {
            InitializeComponent();
            s = _s;
            InitializePanels();
            
        }

        private void btnBackToProfil_Click(object sender, EventArgs e)
        {
            s.AffProfil();
        }

        // Functions about PANELS
        private void InitializePanels()
        {
            ChooseCardsSkins ChooseSkinCards = new ChooseCardsSkins(this);
            ChooseSkinCards.TopLevel = false;
            pnlChooseSkinCards.Controls.Add(ChooseSkinCards);
            ChooseSkinCards.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ChooseSkinCards.Dock = DockStyle.Fill;
            ChooseSkinCards.Show();
        }

        private void HidePanels()
        {
            pnlChooseChampions.Hide();
            pnlEditDeck.Hide();
            pnlShowDeck.Hide();
        }

        // Functions about CARDSKINS
        public void    setCardsSkin(Image newCardsSkin)
        {
            btnChooseCardsSkins.Image = newCardsSkin;
            pnlChooseSkinCards.SendToBack();
        }
        private void btnChooseCardsSkins_Click(object sender, EventArgs e)
        {
            pnlChooseSkinCards.BringToFront();
        }
        
        // Functions about CARDLIST 
        private Panel getCardItem(int i, bool isEdit)
        {
            Panel newPanel = new Panel();
            Card detail = new Card(this, isEdit);

            //setposition and size of the panel
            newPanel.Location = new Point(i, 1);
            newPanel.Size = new Size(223, 300);

            //add detailpartie view to newpanel
            detail.TopLevel = false;
            newPanel.Controls.Add(detail);
            detail.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            detail.Dock = DockStyle.Fill;
            detail.Show();

            //add panel to this view
            this.Controls.Add(newPanel);

            i += 223;
            return (newPanel);
        }
        private void setCardToList(Panel pnlContainer, int i, bool isEdit)
        {
            Panel tmp = getCardItem(i, isEdit);
            pnlContainer.Controls.Add(tmp);

        }

        private int addCard_Location = 1;
        public void addCardToDeck()
        {
            pnlShowDeck.Controls.Add(getCardItem(addCard_Location, false));
            addCard_Location += 223;
        }


        private void btnSelectChampion_Click(object sender, EventArgs e)
        {
            int i = 1;
            HidePanels();
            setCardToList(pnlChooseChampions, i, true);
            i += 223;
            setCardToList(pnlChooseChampions, i, true);
            i += 223;
            setCardToList(pnlChooseChampions, i, true);
            i += 223;
            setCardToList(pnlChooseChampions, i, true);
            i += 223;
            setCardToList(pnlChooseChampions, i, true);
            i += 223;
            setCardToList(pnlChooseChampions, i, true);
            i += 223;
            pnlChooseChampions.Show();
        }
        private void btnEditDeck_Click(object sender, EventArgs e)
        {
            HidePanels();
            int i = 1;
            setCardToList(pnlEditDeck, i, true);
            i += 223;
            setCardToList(pnlEditDeck, i, true);
            i += 223;
            setCardToList(pnlEditDeck, i, true);
            i += 223;
            setCardToList(pnlEditDeck, i, true);
            i += 223;
            setCardToList(pnlEditDeck, i, true);
            i += 223;
            setCardToList(pnlEditDeck, i, true);
            i += 223;
            setCardToList(pnlEditDeck, i, true);
            i += 223;
            setCardToList(pnlEditDeck, i, true);
            i += 223;
            setCardToList(pnlEditDeck, i, true);
            i += 223;
            setCardToList(pnlEditDeck, i, true);
            i += 223;
            setCardToList(pnlEditDeck, i, true);
            i += 223;
            setCardToList(pnlEditDeck, i, true);
            i += 223;
            pnlEditDeck.Show();
        }

        private void btnShowDeck_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlShowDeck.Show();
        }
    }
}

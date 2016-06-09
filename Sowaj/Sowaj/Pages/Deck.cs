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
        Sowaj           s;
        DeckInfos       currentDeck = new DeckInfos();
        DeckInfos       newDeck = new DeckInfos();
        int             currentDeckIt = 0;
        DeckInfos_List  decksList;

        public Deck(Sowaj _s)
        {
            InitializeComponent();
            s = _s;
            InitializeNewDeck();
            InitializeDeckEditor();
            InitializePanels();            
        }

        private void InitializeNewDeck()
        {
            newDeck.deck_name = "Nouveau deck";
        }
        private void    InitializeDeckEditor()
        {
            ParserJSON parser = new ParserJSON();
            RequestServer newreq = new RequestServer();

            String rsp = newreq.DeckAll(s.tokenConnection.Profiles[0].ToString(), s.tokenConnection.Tok);
            decksList = parser.DeckAll(rsp);
            if (decksList.data.Count > 0)
                currentDeck = decksList.data[0];
            else
                currentDeck = newDeck;
            UpdateDeckInfos();
        }

        private void    UpdateDeckInfos()
        {
            lblDeckName.Text = currentDeck.deck_name;
            currentDeck.InitializationDeck();
            lblCardNumberInfo.Text = currentDeck.deck_info_int.Count().ToString() + "/30";        
        }

        private void    btnBackToProfil_Click(object sender, EventArgs e)
        {
            s.AffProfil();
        }

        // Functions about PANELS
        private void    InitializePanels()
        {
            ChooseCardsSkins ChooseSkinCards = new ChooseCardsSkins(this);
            ChooseSkinCards.TopLevel = false;
            pnlChooseSkinCards.Controls.Add(ChooseSkinCards);
            ChooseSkinCards.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ChooseSkinCards.Dock = DockStyle.Fill;
            ChooseSkinCards.Show();
        }

        private void    HidePanels()
        {
            pnlChooseChampions.Hide();
            pnlEditDeck.Hide();
            pnlShowDeck.Hide();
        }

        // Functions about CARDSKINS
        public void     setCardsSkin(Image newCardsSkin)
        {
            btnChooseCardsSkins.Image = newCardsSkin;
            pnlChooseSkinCards.SendToBack();
        }
        private void    btnChooseCardsSkins_Click(object sender, EventArgs e)
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

        private void lblDeckName_Click(object sender, EventArgs e)
        {
            txtDeckName.Show();
            btnRenameDeck.Show();
        }

        private void btnRenameDeck_Click(object sender, EventArgs e)
        {
            RequestServer newreq = new RequestServer();
            ParserJSON parser = new ParserJSON();

            if (txtDeckName.Text != "")
            {
/*                if (currentDeck != newDeck)
                {
                    String rsp = newreq.ModifyDeck(currentDeck.profile_id.ToString(),
                                                   s.tokenConnection.Tok,
                                                   currentDeck.deck_name,
                                                   "",
                                                   "action=modify",
                                                   currentDeck.deck_id.ToString());
                    MessageBox.Show("MODIFY DECK? : " + rsp);
                    //decksList = parser.DeckAll(newreq.DeckAll(currentDeck.profile_id.ToString(), s.tokenConnection.Tok));
                } */
                currentDeck.deck_name = txtDeckName.Text;
            }
            txtDeckName.Hide();
            btnRenameDeck.Hide();
            UpdateDeckInfos();
        }

        private void pctNextDeck_Click(object sender, EventArgs e)
        {
            if (currentDeckIt < decksList.data.Count()-1)
            {
                currentDeckIt++;
                currentDeck = decksList.data[currentDeckIt];
            }
            else if (currentDeckIt <= decksList.data.Count()-1)
                currentDeck = newDeck;
            UpdateDeckInfos();
        }
        private void pctPrevDeck_Click(object sender, EventArgs e)
        {
            if (currentDeckIt > 0 && currentDeck != newDeck)
                currentDeckIt--;
            currentDeck = decksList.data[currentDeckIt];
            UpdateDeckInfos();
            Console.WriteLine("deck ite : " + currentDeckIt.ToString());
        }

        private void btnCreateDeck_Click(object sender, EventArgs e)
        {
            ParserJSON parser = new ParserJSON();
            RequestServer newreq = new RequestServer();
            String rsp = newreq.CreateDeck(s.tokenConnection.Profiles[0].ToString(), s.tokenConnection.Tok, currentDeck.deck_name, "");
            MessageBox.Show("CREATE DECK ? : " + rsp);
            
            //decksList = parser.DeckAll(newreq.DeckAll(s.tokenConnection.Profiles[0].ToString(), s.tokenConnection.Tok));
        }
        private void btnDeleteDeck_Click(object sender, EventArgs e)
        {
            ParserJSON parser = new ParserJSON();
            RequestServer newreq = new RequestServer();
            String rsp = newreq.DeleteDeck(s.tokenConnection.Profiles[0].ToString(), s.tokenConnection.Tok, currentDeck.deck_id.ToString());
          //  decksList = parser.DeckAll(newreq.DeckAll(s.tokenConnection.Profiles[0].ToString(), s.tokenConnection.Tok));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParserJSON parser = new ParserJSON();
            RequestServer newreq = new RequestServer();

            decksList = parser.DeckAll(newreq.DeckAll(s.tokenConnection.Profiles[0].ToString(), s.tokenConnection.Tok));
            currentDeckIt = 0;
            currentDeck = decksList.data[currentDeckIt];
            InitializeNewDeck();
            UpdateDeckInfos();
        }
    }
}
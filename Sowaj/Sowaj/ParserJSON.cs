using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;


namespace Sowaj
{
    class ParserJSON
    {

        public Token   ServerConnect(String response)
        {
            Token token = new Token();

//           MessageBox.Show("Connection : " + response);
            try
            { 
                token = JsonConvert.DeserializeObject<Token>(response);
                token.connectionAccepted = true;
            }
            catch
            {
                token.connectionAccepted = false;
                token.Tok = response;
            }
            return (token);
        }

        public ClientInfos InfosPlayer(String response)
        {
            ClientInfos clientInfos = new ClientInfos();

            //MessageBox.Show("infosPlayer : " + response);

            try
            {
                clientInfos = JsonConvert.DeserializeObject<ClientInfos>(response);
            }
            catch
            {
                clientInfos.nickname = "Unknow";
            }
            return (clientInfos);
        }

        public ClientInfos_List RankOverall(String response)
        {
            ClientInfos_List profilsRanked;

            response = "{\"data\":" + response + "}";
            try
            {
                profilsRanked = JsonConvert.DeserializeObject<ClientInfos_List>(response);
            }
            catch
            {
                profilsRanked = null;
            }
            return (profilsRanked);
        }

        public DeckInfos_List DeckAll(String response)
        {
            DeckInfos_List decksList;

            response = "{\"data\":" + response + "}";
            //MessageBox.Show(response);
            try
            {
                decksList = JsonConvert.DeserializeObject<DeckInfos_List>(response);
            }
            catch
            {
                decksList = null;
            }
            return (decksList);
        }

        public CardInfos_List AllCardsList(String response)
        {
            CardInfos_List      cardList;

            response = "{\"data\":" + response + "}";
            //MessageBox.Show(response);
            try
            {
                cardList = JsonConvert.DeserializeObject<CardInfos_List>(response);
            }
            catch (Exception e)
            {
                Console.WriteLine("HERE =====" + e.ToString());
                cardList = null;
            }
            return (cardList);
        }
    }
}

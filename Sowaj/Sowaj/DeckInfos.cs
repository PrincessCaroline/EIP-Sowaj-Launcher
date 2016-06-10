using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sowaj
{
    public class DeckInfos_List
    {
        public List<DeckInfos>  data{ get; set; }
    }

    public class DeckInfos
    {
        public int              deck_id;
        public int              profile_id;
        public String           deck_name;
        public String           description;
        public String           deck_info;
        public int[]            deck_info_int = new int[30];
        public int              cardsnumber = 0;
        public Boolean          used;
        public List<CardInfos>  card_list = new List<CardInfos>();

        public void     InitializationDeck()
        {
            DeckInfos_strToTab();
            InitlizationCardList();
        }

        public void     InitlizationCardList()
        {
                foreach (int element in deck_info_int)
                {
                    Console.WriteLine("CREATE LIST [CHECK de l'it] : " + card_list.Count().ToString());
                    int tmp = card_list.Count();
                    card_list.Add(new CardInfos(element, tmp));
                }
        }

        public int      getNewCardPosition()
        {
            int         pos = 0;

            foreach (CardInfos element in card_list)
            {
                if (element.idCard != -1)
                    pos++;
            }
            return (pos);
        }

        public void     AddCard(int id)
        {
            card_list.Add(new CardInfos(id, getNewCardPosition()));
        }

        public void    DeckInfos_strToTab()
        {
            for (int i = 0; i < deck_info_int.Length; i++)
                deck_info_int[i] = -1;
            
            deck_info = "[0,0,1,2,3]";
            int foundS1 = deck_info.IndexOf("[");
            int foundS2 = deck_info.IndexOf("]", foundS1 + 1);

            if (foundS1 != foundS2 && foundS1 >= 0 && foundS2 >= 0)
            {
                deck_info = deck_info.Remove(foundS2);
                deck_info = deck_info.Remove(foundS1, foundS1 + 1);
            }

            String[] tmp = deck_info.Split(',');
            int j = 0;
            foreach (String element in tmp)
            {
                deck_info_int[j] = int.Parse(element);
                j++;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sowaj
{
    class CardsSingleton
    {
        private static volatile CardsSingleton instance;
        private static object syncRoot = new Object();

        private CardsSingleton() { }
        
        public static CardsSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new CardsSingleton();
                    }
                }

                return instance;
            }
        }

        public CardInfos_List        AllCardsList;
    }
}

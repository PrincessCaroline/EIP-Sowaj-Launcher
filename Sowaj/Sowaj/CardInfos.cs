using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sowaj
{
    public class CardInfos
    {
        public CardInfos(int id, int listpos)
        {
            idCard = id;
            pos = listpos * 223;
        }

        public bool        isEditable = false;
        public String      name;
        public int         idCard;
        public int         pos;
    }
}

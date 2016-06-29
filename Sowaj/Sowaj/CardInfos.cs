using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sowaj
{
    public class CardInfos_List
    {
        public List<CardInfos> data { get; set; }
    }
    public class CardInfos
    {
        public CardInfos(int _id, int listpos)
        {
            idCard = _id;
            pos = listpos * 223;
        }

        public bool        isEditable = false;
        public String      name;
        public int         idCard;
        public String      id;
        public String      className;
        public int         pos;
    }
}

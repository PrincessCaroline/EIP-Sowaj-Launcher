using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sowaj
{
    public class ClientInfos
    {
        public int      rank_id;
        public int      profile_id;
        public int      points;
        public String   nickName;
        public int      division_id;
        public int      best_points;
        public int      best_rank;
        public int      icon_id;
        public int      level;
        public int      division_name;
        public int      league_number;
        public int      div_number;
        public int      minimum_points;
        public int      maximum_points;

        public void     setUnknow()
        {
             rank_id = 0;
             profile_id = 0;
             points = 0;
             nickName = "PrincesseCaro";
             division_id = 0;
             best_points = 0;
             best_rank = 0;
             icon_id = 0;
             level = 0;
             division_name = 0;
             league_number = 0;
             div_number = 0;
             minimum_points = 0;
             maximum_points = 0;
        }
    }
}

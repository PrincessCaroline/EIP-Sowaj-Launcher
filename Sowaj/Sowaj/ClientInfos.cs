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
        public int      user_id;
        public int      profile_id;
        public int      points;
        public String   nickname;
        public int      division_id;
        public int      best_points;
        public int      best_rank;
        public int      iconId;
        public int      level;
        public int      division_name;
        public int      league_number;
        public int      div_number;
        public int      minimum_points;
        public int      maximum_points;
        public int      exp;
        public int      mana;
        public int      nbVictories;
        public int      nbDefeats;
        public int      nbGames;

        public void     setUnknow()
        {
             rank_id = 0;
             profile_id = 0;
             points = 0;
             nickname = "";
             division_id = 0;
             best_points = 0;
             best_rank = 0;
             iconId = 0;
             level = 0;
             division_name = 0;
             league_number = 0;
             div_number = 0;
             minimum_points = 0;
             maximum_points = 0;
        }
    }
}

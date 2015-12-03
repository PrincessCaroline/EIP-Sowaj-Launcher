using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sowaj
{
    class ClientInfos
    {
        private int profilId;
        private String playerName;
        private int iconId;
        private int level;
        private int exp;
        private int NBvictories;
        private int NBdefeats;
        private int NBgames;
        private int currentDeckId;

        public void ClientInfos_Init()
        {
            profilId = 1;
            playerName = "Toto l'asticot";
            iconId = 1;
            level = 1;
            exp = 546;
            NBvictories = 3;
            NBdefeats = 1;
            NBgames = 4;
            currentDeckId = 1;
        }

        public void setProfilID(int id) { profilId = id; }
        public int getProfilID() { return (profilId); }

        public void setPlayerName(String name) { playerName = name; }
        public String getPlayerName() { return (playerName); }

        public void setLevel(int _level) { level = _level; }
        public int getLevel() { return (level); }

        public void setExp(int _exp) { exp = _exp; }
        public int getExp() { return (exp); }

        public void setNBvictories(int _NBvictories) { NBvictories = _NBvictories; }
        public int getNBvictories() { return (NBvictories); }

        public void setNBdefeats(int _NBdefeats) { NBdefeats = _NBdefeats; }
        public int getNBdefeats() { return (NBdefeats); }

        public void setNBgames(int _NBgames) { NBgames = _NBgames; }
        public int getNBgames() { return (NBgames); }

        public void setCurrentDeckId(int _currentDeckId) { currentDeckId = _currentDeckId; }
        public int getCurrentDeckId() { return (currentDeckId); }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    sealed class Player
    {
        private static Player player;                              //Singleton pattern
        public List<Fish> fishlist = new List<Fish>();
        public string NickName { get; set; } = "Рыболов";
        public int Money { get; set; } = 10000000;
        public int RoadPower { get; set; } = 2000;
        public int LeskaPower { get; set; } = 1500;
        public int ReelPower { get; set; } = 3;
        public Road proad;
        public Reel reel;
        public FLine fline;
        public Lure lure;
        private Player()
        {
        }
        public static Player getPlayer()                           
        {
            if(player == null)
            {
                player = new Player();
            }

            return player;              
        }

        public void setAssembly(Road r, Reel reel, FLine fLine, Lure lure)
        {
            this.proad = r;
            this.reel = reel;
            this.fline = fLine;
            this.lure = lure;
        }
    }
}

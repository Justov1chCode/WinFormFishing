using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fishing
{
    class Reel : Item
    {
        public int Power;
        public Reel(string name, int power, int price, Bitmap pic) : base(name, price, pic)
        {
            Power = power;
        }
        public static Reel Hydra = new Reel("Hydra", 3, 100000, Resource1.HYDRA);
        public static Reel SYBERIA_LT_2 = new Reel("SYBERIA_LT_2", 6, 200000, Resource1.SYBERIA_LT_2);
        public static Reel Quest_Reel = new Reel("Quest_Reel", 6, 400000, Resource1.QUEST_REEL);
        public static Reel SYBERIA_4 = new Reel("SYBERIA 4", 8, 600000, Resource1.SYBERIA_4);
        public static Reel Zymix = new Reel("Zymix", 10, 400000, Resource1.ZYMIX);

        public override string ToString()
        {
            return this.Name;
        }
    }
}

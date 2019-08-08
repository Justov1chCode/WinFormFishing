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
        public static Reel Hydra = new Reel("Hydra", 3, 100000, Resource1.Hydra);
        public static Reel Marco_R1 = new Reel("Marco_R1", 6, 200000, Resource1.Marco_R1);
        public static Reel Quest_Reel = new Reel("Quest_Reel", 6, 400000, Resource1.Quest_Reel);
        public static Reel Marco_R6 = new Reel("Marco_R6", 8, 600000, Resource1.Marco_R6);
        public static Reel Zymix = new Reel("Zymix", 10, 400000, Resource1.Zymix);

        public override string ToString()
        {
            return this.Name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fishing
{
    class PinkSalmon : Fish
    {
        public static HashSet<Lure> lures = new HashSet<Lure>() { Lure.vob1, Lure.vob4, Lure.jelezo1, Lure.jelezo3, Lure.jelezo4 };
        private static int Power = 6;
        private static string Name = "Горбуша";
        private static int Price = 3;
        public PinkSalmon() : base(Name, randWigth.Next(500, 20000), Power, Price)
        {
        }
    }
}

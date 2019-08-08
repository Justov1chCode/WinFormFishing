using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fishing
{
    class ArcticChar : Fish
    {
        public static HashSet<Lure> lures = new HashSet<Lure>() { Lure.vob1, Lure.vob2, Lure.vob3, Lure.jelezo2 };
        private static int Power = 6;
        private static string Name = "Арктический Голец";
        private static int Price = 2;
        public ArcticChar() : base(Name, randWigth.Next(200, 20000), Power, Price)
        {
        }
    }
}

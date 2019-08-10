using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fishing
{
    class Pike : Fish
    {
        public static HashSet<Lure> lures = new HashSet<Lure>() {Lure.vob1, Lure.vob4, Lure.jelezo3, Lure.jelezo4 };
        private static int Power = 5;
        private static string Name = "Щука";
        private static int Price = 1;
        public Pike() : base(Name, randWigth.Next(1, 10000), Power, Price)
        {
        }
    }
}

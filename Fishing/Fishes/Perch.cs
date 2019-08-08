using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fishing
{
    class Perch : Fish
    {
        public static HashSet<Lure> lures = new HashSet<Lure>() { Lure.vob2, Lure.vob3, Lure.jelezo2 };
        private static int Power = 3;
        private static string Name = "Окунь";
        private static int Price = 1;
        public Perch() : base(Name, randWigth.Next(200, 1700), Power, Price)
        {

        }
    }
}

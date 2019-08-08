using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Salmon : Fish
    {
        public static HashSet<Lure> lures = new HashSet<Lure>() { Lure.vob1, Lure.vob4, Lure.jelezo1, Lure.jelezo3, Lure.jelezo4};
        private static int Power = 5;
        private static string Name = "Сёмга";
        private static int Price = 6;
        public Salmon() : base(Name, randWigth.Next(500, 30000), Power, Price)
        {

        }
    }
}

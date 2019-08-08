using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Grayling : Fish
    {
        public static HashSet<Lure> lures = new HashSet<Lure>() { Lure.vob2, Lure.vob3, Lure.jelezo2 };
        private static int Power = 4;
        private static string Name = "Хариус";
        private static int Price = 5;
        public Grayling() : base(Name, randWigth.Next(500, 2000), Power, Price)
        {
        }
    }
}

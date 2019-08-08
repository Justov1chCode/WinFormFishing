using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Trout : Fish
    {
        public static HashSet<Lure> lures = new HashSet<Lure>() {Lure.vob2, Lure.vob3, Lure.jelezo2};     
        private static int Power = 4;
        private static string Name = "Форель";
        private static int Price = 2;
        public Trout() : base(Name, randWigth.Next(500, 15000), Power, Price)
        {
        }
    }
}

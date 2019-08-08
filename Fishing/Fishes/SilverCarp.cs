using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fishing
{
    class SilverCarp : Fish
    {
        private static int Power = 2;
        private static string Name = "Карась сер.";
        private static int Price = 2;
        public SilverCarp() : base(Name, randWigth.Next(100, 2500), Power, Price)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fishing
{
    class Roach : Fish
    {
        private static int Power = 2;
        private static string Name = "Плотва";
        private static int Price = 2;
        public Roach() : base(Name, randWigth.Next(100, 1500), Power, Price)
        {

        }
    }
}

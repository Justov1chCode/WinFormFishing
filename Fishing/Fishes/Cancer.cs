using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fishing
{
    class Cancer : Fish
    {
        private static int Power = 0;
        private static string Name = "Рак";
        private static int Price = 2;
        public Cancer() : base(Name, randWigth.Next(30, 250), Power, Price)
        {

        }
    }
}

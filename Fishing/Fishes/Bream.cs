using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fishing
{
    sealed class Bream : Fish
    {
        private static int Power = 2;
        private static string Name = "Лещ";
        private static int Price = 2;
        public Bream() : base(Name, randWigth.Next(300, 3000), Power, Price)
        {

        }
    }
}

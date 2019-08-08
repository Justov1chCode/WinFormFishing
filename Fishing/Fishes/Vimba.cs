using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Fishing
{
    class Vimba : Fish
    {
        private static int Power = 3;
        private static string Name = "Рыбец";
        private static int Price = 5;
        public Vimba() : base(Name, randWigth.Next(100, 2500), Power, Price)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fishing
{
    sealed class Zywiec : Baits
    {
        public Zywiec(string name, int count, int price, Bitmap pic) : base(name, count, price, pic)
        {

        }
    }
}

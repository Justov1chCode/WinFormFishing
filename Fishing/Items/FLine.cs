using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fishing
{
    class FLine : Item
    {
        public static FLine twokgMono = new FLine("Монка 2кг", 2000, 500, Resource1.indiana);
        public int LeskaPower;
        public FLine(string name, int power, int price, Bitmap pic) : base(name, price, pic)
        {
            LeskaPower = power;
        }
        public static FLine Indiana1500 = new FLine("Indiana 1500", Player.getPlayer().LeskaPower, 500, Resource1.indiana);
        public static FLine Quest_Fishers = new FLine("Quest_fishers 90000", 90000, 200000, Resource1.Quest_Fishers);
        public static FLine Colorado = new FLine("Colorado 30000", 30000, 100000, Resource1.Colorado);
        public override string ToString()
        {
            return this.Name;
        }
    }
}

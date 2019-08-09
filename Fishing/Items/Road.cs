using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fishing
{
    enum ROAD_TYPE
    {
        Spinning,
        Feeder,
        Float
    }
    class Road : Item
    {
        public int Power;
        public ROAD_TYPE Type;
        public Road(string name, ROAD_TYPE type, int power, int price, Bitmap pic) : base(name, price, pic)
        {
            Power = power;
            Type = type;
        }
        public static Road Titanium = new Road("Titanium", ROAD_TYPE.Spinning, 40000, 300000, Resource1.Titanium);
        public static Road Achilles = new Road("Achilles", ROAD_TYPE.Spinning, 20000, 3000, Resource1.ACHILLES);
        public static Road YSuperCarp = new Road("Yellow super Carp", ROAD_TYPE.Feeder, 100000, 600000, Resource1.YELLOW_SUPERCARP);
        public override string ToString() {
            return this.Name;
        }
    }
}

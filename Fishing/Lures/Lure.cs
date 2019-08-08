using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fishing
{
    enum LureType
    {
        DeepXL,
        DeepSmall,
        DeepLarge,
        FlyingXL,
        FlyingSmall,
        FlyingLarge,
        TopXL,
        TopSmall,
        TopLarge,
        XL,
        Small,
        Large
    }
    class Lure
    {
        public string Name;
        public int Count;
        public int Price;
        public Bitmap pic;
        public LureType type;
        public Lure(string name, LureType type, int count, int price, Bitmap Pic)
        {
            Name = name;
            this.type = type;
            Count = count;
            Price = price;
            pic = Pic;
        }
        public static Wobbler vob1 = new Wobbler("Составник", LureType.FlyingLarge, 1, 3000, Resource1.Vob_3015);
        public static Wobbler vob2 = new Wobbler("Воб2", LureType.FlyingSmall, 1, 3000, Resource1.Vob_3002);
        public static Wobbler vob3 = new Wobbler("Воб3", LureType.FlyingSmall, 1, 3000, Resource1.Vob_3001);
        public static Wobbler vob4 = new Wobbler("Воб4", LureType.FlyingXL, 1, 3000, Resource1.Vob_3003);
        public static Iron jelezo1 = new Iron("Вертушка 1", LureType.XL, 1, 500, Resource1.Circl_5103);
        public static Iron jelezo2 = new Iron("Вертушка 2", LureType.Small, 1, 500, Resource1.Circl_5113);
        public static Iron jelezo3 = new Iron("Колебалка 1", LureType.XL, 1, 500, Resource1.Vib_6000);
        public static Iron jelezo4 = new Iron("Колебалка 1", LureType.XL, 1, 500, Resource1.Vib_6008);
        public override string ToString()
        {
            return this.Name;
        }
    }
}

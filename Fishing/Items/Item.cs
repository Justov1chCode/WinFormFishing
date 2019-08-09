using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fishing
{
    class Item
    {
        public static List<Road> RoadShop = new List<Road>();
        public static List<Reel> ReelShop = new List<Reel>();
        public static List<FLine> LeskaShop = new List<FLine>();
        public static List<Road> RoadInv = new List<Road>();
        public static List<Reel> ReelInv = new List<Reel>();
        public static List<FLine> LeskaInv = new List<FLine>();
        public static List<Lure> LureShop = new List<Lure>();
        public static List<Lure> LureInv = new List<Lure>();
        public string Name;
        public int Price;
        public Bitmap Pict;

        public Item(string name, int price, Bitmap pict)
        {
            Name = name;
            Price = price;
            Pict = pict;
        }


    }
}

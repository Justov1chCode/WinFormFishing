using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Fishing
{
    class Baits
    {
        public string Name;
        public int Count;
        public Bitmap pic;
        public int Price;

        public Baits(string name, int count,int price, Bitmap Pic)
        {
            Name = name;
            Count = count;
            pic = Pic;
            Price = price;
        }
        public static Pray Molusk = new Pray("Молюск", 30, 5000, Resource1.rm_mollusk);
        public static Zywiec jhivec = new Zywiec("Живец", 30, 3000, Resource1.rm_zhivec);
        public static Maggot oparish = new Maggot("Опарыш", 30, 500, Resource1.oparysh);
        public static FishMeat fishm = new FishMeat("Кусочки рыбы", 30, 3000, Resource1.rm_fish);
        public static Worm worm = new Worm("Червь", 30, 250, Resource1.worm);
    }
}

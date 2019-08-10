using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fishing
{
    abstract class Fish
    {
        protected static Random randWigth = new Random();
        public string name { get; set; }
        public int weight { get; set; }
        public int power { get; set; }
        public static Fish CFish { get; set; }
        public double price { get; set; }

        public Fish(string name, int weight, int power, double price)
        {
            this.name = name;
            this.weight = weight;
            this.power = power;
            this.price = price;
        }
        public override string ToString()
        {
            return Player.getPlayer().NickName + " поймал " + Fish.CFish.name + " масса " + Fish.CFish.weight + " г.";
        }
    }
}

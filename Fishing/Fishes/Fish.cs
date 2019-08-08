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
        public string name;
        public int weight;
        public int power;
        public static Fish CFish;
        public double price;
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

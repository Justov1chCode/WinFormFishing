using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Fishing
{
    abstract class LVL
    {
        public static Label[,] Deeparr = new Label[51, 18];
        protected List<Fish> fishes = new List<Fish>(1000);
        public abstract void addFishes();

        public abstract Fish getFish();

        public abstract void SetDeep();

        public static bool isFishAttackAbble(Fish fish)
        {
            if (Fish.CFish is Pike)
            {
                if (Pike.lures.Contains(Player.getPlayer().lure))
                {
                    return true;
                }
            }
            if (Fish.CFish is Perch)
            {
                if (Perch.lures.Contains(Player.getPlayer().lure))
                {
                    return true;
                }
            }
            if (Fish.CFish is PinkSalmon)
            {
                if (PinkSalmon.lures.Contains(Player.getPlayer().lure))
                {
                    return true;
                }
            }
            if (Fish.CFish is ArcticChar)
            {
                if (ArcticChar.lures.Contains(Player.getPlayer().lure))
                {
                    return true;
                }
            }
            if (Fish.CFish is Grayling)
            {
                if (Grayling.lures.Contains(Player.getPlayer().lure))
                {
                    return true;
                }
            }
            if (Fish.CFish is Salmon)
            {
                if (Salmon.lures.Contains(Player.getPlayer().lure))
                {
                    return true;
                }
            }
            if (Fish.CFish is Trout)
            {
                if (Trout.lures.Contains(Player.getPlayer().lure))
                {
                    return true;
                }
            }
            return false;
        }
        public static void setCurrentFish()
        {
            Game.currentFish = new CurrentFish();
            if (Fish.CFish is Pike)
            {
                Game.currentFish.FishImage.Image = Resource1.PIKE;
            }
            if (Fish.CFish is Perch)
            {
                Game.currentFish.FishImage.Image = Resource1.PERCH;
            }
            if (Fish.CFish is PinkSalmon)
            {
                Game.currentFish.FishImage.Image = Resource1.GORBUSHA;
            }
            if (Fish.CFish is ArcticChar)
            {
                Game.currentFish.FishImage.Image = Resource1.GOLEC1;
            }
            if(Fish.CFish is Grayling)
            {
                Game.currentFish.FishImage.Image = Resource1.XARIYS;
            }
            if (Fish.CFish is Salmon)
            {
                Game.currentFish.FishImage.Image = Resource1.SEMGA;
            }
            if (Fish.CFish is Trout)
            {
                Game.currentFish.FishImage.Image = Resource1.FOREL;
            }
            if(Fish.CFish is SilverCarp)
            {
                Game.currentFish.FishImage.Image = Resource1.KARASS;
            }
            if (Fish.CFish is Bream)
            {
                Game.currentFish.FishImage.Image = Resource1.LESH;
            }
            if (Fish.CFish is Cancer)
            {
                Game.currentFish.FishImage.Image = Resource1.RAK;
            }
            if (Fish.CFish is Roach)
            {
                Game.currentFish.FishImage.Image = Resource1.PLOTVA;
            }
            if (Fish.CFish is Vimba)
            {
                Game.currentFish.FishImage.Image = Resource1.RIBEC;
            }
            Game.currentFish.NameLabel.Text = Fish.CFish.name;
            Game.currentFish.WeightLabel.Text = Fish.CFish.weight.ToString();
            Game.currentFish.PriceButton.Text = (Fish.CFish.price * Fish.CFish.weight).ToString();
            Game.currentFish.Show();
            Game.isFishAttack = false;
        }
        public void MainTimertick()
        {
            if (Game.gui.FLineBar.Value > 0)
                Game.gui.FLineBar.Increment(-1);
            if (Game.gui.ReelBar.Value > 0)
                Game.gui.ReelBar.Increment(-1);
            if (Game.gui.FLineBar.Value > 98)
            {
                Game.gui.EventsBox.Items.Add(Player.getPlayer().NickName + " порвал леску");
                Game.isFishAttack = false;
                Game.CastPoint.Y = 0;
                Item.LureInv.Remove(Player.getPlayer().lure);
                Player.getPlayer().lure = null;
            }
            if (Game.gui.ReelBar.Value > 98)
            {
                Game.gui.EventsBox.Items.Add(Player.getPlayer().NickName + " сломал удочку");
                Pictures.road = Pictures.brokenRoad;
                Game.isFishAttack = false;
                Item.RoadInv.Remove(Player.getPlayer().proad);
                Game.CastPoint.Y = 800;
                //Item.RoadInv.Remove(Player.proad);
                Player.getPlayer().proad = null;
            }
            Game.ozeroForm.Refresh();
            if (Game.CastPoint.X > 1049) Game.CastPoint.X = 1048;
            if (Game.CastPoint.X < 0) Game.CastPoint.X = 1;
            if (Game.nettingY == 550 && Game.isFishAttack && Game.CastPoint.Y > 600)
            {
                if (Game.gui.EventsBox.Items.Count > 5) Game.gui.EventsBox.Items.Clear();
                Game.gui.FLineBar.Value = 0;
                Game.gui.ReelBar.Value = 0;
                LVL.setCurrentFish();
                Game.gui.EventsBox.Items.Add(Fish.CFish.ToString());           
            }
            Game.nettingY = 800;
        }
    }
}

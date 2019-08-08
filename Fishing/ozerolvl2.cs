using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fishing
{
    class ozerolvl2 : Game
    {
        public static List<Fishes> lFishes = new List<Fishes>();
        internal static void SetDeep()
        {
            for (int x = 0; x < 51; x++)
            {
                for (int y = 0; y < 15; y++)
                {

                }
                ozerolvl1.Larr[x, 0].Tag = 110.ToString();
                ozerolvl1.Larr[x, 1].Tag = 110.ToString();
                ozerolvl1.Larr[x, 2].Tag = 200.ToString();
                ozerolvl1.Larr[x, 3].Tag = 300.ToString();
                ozerolvl1.Larr[x, 4].Tag = 250.ToString();
                ozerolvl1.Larr[x, 5].Tag = 600.ToString();
                ozerolvl1.Larr[x, 6].Tag = 700.ToString();
                ozerolvl1.Larr[x, 7].Tag = 300.ToString();
                ozerolvl1.Larr[x, 8].Tag = 300.ToString();
                ozerolvl1.Larr[x, 9].Tag = 400.ToString();
                ozerolvl1.Larr[x, 10].Tag = 120.ToString();
                ozerolvl1.Larr[x, 11].Tag = 100.ToString();
                ozerolvl1.Larr[x, 12].Tag = 100.ToString();
                ozerolvl1.Larr[x, 13].Tag = 90.ToString();
                ozerolvl1.Larr[x, 14].Tag = 90.ToString();

            }
        }

        public static void SetFish()
        {
            for (int i = 0; i < 1000; i++)
            {
                massa = randommass.Next(500, 10000);
                pike = new Pike("Щука", massa, 7, 3);
                if (i < 150)
                {
                    lFishes.Add(pike);
                }
                massa = randommass.Next(2500, 20000);
                gorbusha = new Gorbusha("Горбуша", massa, 10, 15);
                if (i > 150 && i < 200)
                {
                    lFishes.Add(gorbusha);
                }
                massa = randommass.Next(100, 2000);
                okyn = new Okyn("Окунь", massa, 2, 3);
                if (i > 200 && i < 250)
                {
                    lFishes.Add(okyn);
                }
                massa = randommass.Next(100, 2000);
                okyn = new Okyn("Окунь", massa, 2, 3);
                if (i > 200 && i < 250)
                {
                    lFishes.Add(okyn);
                }
                massa = randommass.Next(500, 8000);
                golec = new Golec("Голец", massa, 7, 10);
                if (i > 250 && i < 500)
                {
                    lFishes.Add(golec);
                }
            }
        }
        public override void NavozChAttack()
        {
            if ((curpoint.Y > 300 && curpoint.Y < 700) && Game.Deep > 300)
            {
                if (Game.lure is Vobler || Game.lure is Jelezo && Game.Move == true)
                {
                    frm1.timer1.Interval = 5000;
                    fish = randf.Next(1, 1000);
                    if (fish > lFishes.Count)
                        fish = randf.Next(1, lFishes.Count);

                    if (lFishes[fish] is Pike)
                    {
                        gui.label1.Text = "Поклёвка";
                        massa = randommass.Next(500, 10000);
                        pike = new Pike("Щука", massa, 6, 3);
                        Fishes.CFish = pike;
                        FishAttack = true;
                        fishpowerx = pike.Power;
                        fishpowery = pike.Power;

                    }

                    if (lFishes[fish] is Gorbusha)
                    {
                        gui.label1.Text = "Поклёвка";
                        massa = randommass.Next(2500, 13000);
                        gorbusha = new Gorbusha("Горбуша", massa, 5, 15);
                        Fishes.CFish = gorbusha;
                        FishAttack = true;
                        fishpowerx = gorbusha.Power;
                        fishpowery = gorbusha.Power / 2;
                    }

                    if (lFishes[fish] is Okyn)
                    {
                        gui.label1.Text = "Поклёвка";
                        massa = randommass.Next(100, 2000);
                        okyn = new Okyn("Окунь", massa, 4, 7);
                        Fishes.CFish = okyn;
                        FishAttack = true;
                        fishpowerx = okyn.Power;
                        fishpowery = okyn.Power / 2;
                    }
                    if (lFishes[fish] is Golec)
                    {
                        gui.label1.Text = "Поклёвка";
                        massa = randommass.Next(500, 8000);
                        golec = new Golec("Голец", massa, 7, 10);
                        Fishes.CFish = golec;
                        FishAttack = true;
                        fishpowerx = golec.Power;
                        fishpowery = golec.Power / 2;
                    }
                }
            }
        }
        public override void tim2tick()
        {
            if (gui.progressBar1.Value > 99)
            {
                gui.listBox1.Items.Add(NickName + " порвал леску");
                FishAttack = false;
                curpoint.Y = 0;
                gui.label1.Text = " ";
                Item.LureInv.Remove(lure);
                Game.lure = null;
            }
            if (Game.gui.progressBar2.Value > 99)
            {
                Game.gui.listBox1.Items.Add(Game.NickName + " сломал удочку");
                road = brokenr;
                FishAttack = false;
                curpoint.Y = 800;
                gui.label1.Text = " ";
                Item.RoadInv.Remove(Proad);
                Game.Proad = null;
            }
            if (gui.progressBar2.Value > 3 && gui.progressBar2.Value > 0)
                gui.progressBar2.Increment(-(1));
            if (gui.progressBar1.Value > 3 && gui.progressBar1.Value > 0)
                gui.progressBar1.Increment(-(1));
            frm1.Refresh();
            if (gui.listBox1.Items.Count > 5) gui.listBox1.Items.Clear();
            if (curpoint.X > 1049) curpoint.X = 1048;
            if (curpoint.X < 0) curpoint.X = 1;
            if (podsachiky == 550 && FishAttack && curpoint.Y > 600)
            {
                if (Fishes.CFish is Pike)
                {
                    gui.listBox1.Items.Add(NickName + " поймал " + pike.Name + " " + pike.Massa + "г");
                    FishAttack = false;
                    gui.label1.Text = " ";
                    gui.progressBar1.Value = 0;
                    gui.progressBar2.Value = 0;
                    fishes = pike;
                    currentFish = new CurrentFish();
                    if (pike.Massa > 3000)
                        Game.currentFish.button1.Text = Convert.ToString(pike.Price * pike.Massa);
                    currentFish.pictureBox1.Image = Resource1.pike;
                    currentFish.label1.Text = "Щука";
                    currentFish.label2.Text = Convert.ToString(pike.Massa);
                    currentFish.Show();
                    massa = 0;
                }
                if (Fishes.CFish is Gorbusha)
                {
                    gui.listBox1.Items.Add(NickName + " поймал " + gorbusha.Name + " " + gorbusha.Massa + "г");
                    FishAttack = false;
                    gui.label1.Text = " ";
                    fishes = gorbusha;
                    gui.progressBar1.Value = 0;
                    gui.progressBar2.Value = 0;
                    currentFish = new CurrentFish();
                    if (gorbusha.Massa > 2000)
                        currentFish.button1.Text = Convert.ToString(gorbusha.Price * gorbusha.Massa);
                    currentFish.pictureBox1.Image = Resource1.gorbysha;
                    currentFish.label1.Text = "Горбуша";
                    currentFish.label2.Text = Convert.ToString(gorbusha.Massa);
                    currentFish.Show();
                    massa = 0;
                }
                if (Fishes.CFish is Okyn)
                {
                    gui.listBox1.Items.Add(NickName + " поймал " + okyn.Name + " " + okyn.Massa + "г");
                    FishAttack = false;

                    gui.label1.Text = " ";
                    fishes = okyn;
                    gui.progressBar1.Value = 0;
                    gui.progressBar2.Value = 0;
                    currentFish = new CurrentFish();
                    if (okyn.Massa > 1000)
                        currentFish.button1.Text = Convert.ToString(okyn.Price * okyn.Massa);
                    currentFish.pictureBox1.Image = Resource1.okyn;
                    currentFish.label1.Text = "Окунь";
                    currentFish.label2.Text = Convert.ToString(okyn.Massa);
                    currentFish.Show();
                    massa = 0;
                }
                if (Fishes.CFish is Golec)
                {
                    gui.listBox1.Items.Add(NickName + " поймал " + golec.Name + " " + golec.Massa + "г");
                    FishAttack = false;

                    gui.label1.Text = " ";
                    fishes = golec;
                    gui.progressBar1.Value = 0;
                    gui.progressBar2.Value = 0;
                    currentFish = new CurrentFish();
                    if (golec.Massa > 2000)
                        currentFish.button1.Text = Convert.ToString(golec.Price * golec.Massa);
                    currentFish.pictureBox1.Image = Resource1.golec;
                    currentFish.label1.Text = "Голец";
                    currentFish.label2.Text = Convert.ToString(golec.Massa);
                    currentFish.Show();
                    massa = 0;
                }

                podsachiky = 800;
            }
        }
    }
}

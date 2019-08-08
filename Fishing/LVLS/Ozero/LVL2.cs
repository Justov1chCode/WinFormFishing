using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class LVL2 : LVL
    {
        public static LVL2 lvl2 = new LVL2();
        public override void addFishes()
        {
            for(int i = 0; i < 1000; i++)
            {
                if(i < 250)
                {
                    lvl2.fishes.Add(new Pike());
                }
                if (i > 250 && i < 450)
                {
                    lvl2.fishes.Add(new Perch());
                }
                if (i > 450 && i < 600)
                {
                    lvl2.fishes.Add(new ArcticChar());
                }
                if(i > 600 && i < 700)
                {
                    lvl2.fishes.Add(new Trout());
                }
                if (i > 700 && i < 800)
                {
                    lvl2.fishes.Add(new PinkSalmon());
                }
                if (i > 800 && i < 900)
                {
                    lvl2.fishes.Add(new Grayling());
                }
                if (i > 900 && i < 1000)
                {
                    lvl2.fishes.Add(new Salmon());
                }
            }
        }                         //добавляем рыбу на локацию

        public override Fish getFish()
        {
                if((Player.getPlayer().lure is Wobbler || Player.getPlayer().lure is Iron) && Game.Deep > 300 )
                if (Game.CastPoint.Y > 400 && Game.CastPoint.Y < 800)
                {
                    Game.ozeroForm.baitTimer.Interval = 5000;
                    Fish.CFish = lvl2.fishes[Game.randomFish.Next(1, 999)];
                    if (LVL.isFishAttackAbble(Fish.CFish))
                    {
                        Game.isFishAttack = true;
                        Game.fishpowerX = Fish.CFish.power / Fish.CFish.weight;
                        Game.fishpowerY = Fish.CFish.power / Fish.CFish.weight;
                        Game.ozeroForm.baitTimer.Stop();
                        int Gathering = Game.randomGathering.Next(1, 100);
                        if (Gathering <= 5)
                        {
                            Game.ozeroForm.GatheringTimer.Start();
                        }
                    }
                }   
            return Fish.CFish;
        }                          //Выбираем рыбу, вычисляем будет ли сход

        public override void SetDeep()
        {
            for (int x = 0; x < 51; x++)
            {
                for (int y = 0; y < 15; y++)
                {

                }
                Larr[x, 0].Tag = 450;
                Larr[x, 1].Tag = 400;
                Larr[x, 2].Tag = 360;
                Larr[x, 3].Tag = 400;
                Larr[x, 4].Tag = 500;
                Larr[x, 5].Tag = 600;
                Larr[x, 6].Tag = 200;
                Larr[x, 7].Tag = 360;
                Larr[x, 8].Tag = 400;
                Larr[x, 9].Tag = 350;
                Larr[x, 10].Tag = 330;
                Larr[x, 11].Tag = 200;
                Larr[x, 12].Tag = 200;
                Larr[x, 13].Tag = 90;
                Larr[x, 14].Tag = 90;
                Larr[x, 15].Tag = 80;
                Larr[x, 16].Tag = 80;
                Larr[x, 17].Tag = 80;

            }
        }                          //Устанавливаем глубину                         
    }
}

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
                if((Player.getPlayer().lure is Wobbler || Player.getPlayer().lure is Iron) && Game.Deep > 350 )
                if (Game.CastPoint.Y > 400 && Game.CastPoint.Y < 800)
                {
                    Game.ozeroForm.baitTimer.Interval = 5000;
                    Fish.CFish = lvl2.fishes[Game.randomFish.Next(1, 999)];
                    if (isFishAttackAbble(Fish.CFish) && Game.isBaitMoving)
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
                for (int y = 0; y < 18; y++)
                {
                }
                Deeparr[x, 0].Tag = 340;
                Deeparr[x, 1].Tag = 340;
                Deeparr[x, 2].Tag = 360;
                Deeparr[x, 3].Tag = 380;
                Deeparr[x, 4].Tag = 450;
                Deeparr[x, 5].Tag = 500;
                Deeparr[x, 6].Tag = 550;
                Deeparr[x, 7].Tag = 600;
                Deeparr[x, 8].Tag = 600;
                Deeparr[x, 9].Tag = 540;
                Deeparr[x, 10].Tag = 470;
                Deeparr[x, 11].Tag = 440;
                Deeparr[x, 12].Tag = 370;
                Deeparr[x, 13].Tag = 320;
                Deeparr[x, 14].Tag = 250;
                Deeparr[x, 15].Tag = 200;
                Deeparr[x, 16].Tag = 150;
                Deeparr[x, 17].Tag = 150;

            }
        }                          //Устанавливаем глубину                         
    }
}

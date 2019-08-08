using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing.LVLS.Ozero
{
    class LVL1 : LVL
    {

        public static LVL1 lvl1 = new LVL1();
        public override void addFishes()
        {
            for (int i = 0; i < 1000; i++)
            {
                if (i < 250)
                {
                    lvl1.fishes.Add(new Roach());
                }
                if (i > 250 && i < 450)
                {
                    lvl1.fishes.Add(new Vimba());
                }
                if (i > 450 && i < 600)
                {
                    lvl1.fishes.Add(new Bream());
                }
                if (i > 600 && i < 700)
                {
                    lvl1.fishes.Add(new Cancer());
                }
                if (i > 700 && i < 800)
                {
                    lvl1.fishes.Add(new SilverCarp());
                }
                if (i > 800 && i < 1000)
                {
                    lvl1.fishes.Add(new Roach());
                }
            }
        }                  //добавляем рыбу на локацию

        public override Fish getFish()
        {
            throw new NotImplementedException();
        }

        public override void SetDeep()
        {
            for (int x = 0; x < 51; x++)
            {
                for (int y = 0; y < 15; y++)
                {

                }
                Larr[x, 0].Tag = 290;
                Larr[x, 1].Tag = 310;
                Larr[x, 2].Tag = 360;
                Larr[x, 3].Tag = 400;
                Larr[x, 4].Tag = 500;
                Larr[x, 5].Tag = 600;
                Larr[x, 6].Tag = 200;
                Larr[x, 7].Tag = 200;
                Larr[x, 8].Tag = 400;
                Larr[x, 9].Tag = 350;
                Larr[x, 10].Tag = 330;
                Larr[x, 11].Tag = 200;
                Larr[x, 12].Tag = 200;
                Larr[x, 13].Tag = 90;
                Larr[x, 14].Tag = 90;

            }
        }                    //Устанавливаем глубину
    }
}

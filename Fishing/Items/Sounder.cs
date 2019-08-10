using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    class Sounder : Item
    {
        private Timer sounderUpdater;
        private Panel sounder;
        private static int Y = 0;
        private static int X = 0;

        public static void setY(int y)
        {
            Y = y;
        }
        public static void setX(int x)
        {
            X = x;
        }
        public Sounder(Panel sounder, Timer timer) : base ("Эхолот", 100000, Resource1.DRACO_FD)
        {
            this.sounder = sounder;
            this.sounderUpdater = timer;
            timer.Tick += SounderUpdater_Tick;
            sounder.Paint += SounderPanel_Paint;
            sounder.BackColor = Color.Gray;
        }

        private void SounderUpdater_Tick(object sender, EventArgs e)
        {
            sounder.Refresh();
        }

        private void SounderPanel_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int drawX = 0;
            int drawX2 = 0;
            for (int i = 0; i < 17; i++)
            {
                drawX2 = drawX + 10;
                g.DrawLine(new Pen(Color.White, 2), drawX, (int)LVL.Deeparr[Y, i].Tag / 10, drawX2,
                                                                            (int)LVL.Deeparr[Y, i + 1].Tag / 10);
                drawX = drawX2;
            }
            drawPoint(g);
        }

        private static void drawPoint(Graphics g)
        {
            if (Player.getPlayer().lure.type == LureType.FlyingLarge
                            || Player.getPlayer().lure.type == LureType.FlyingSmall
                                        || Player.getPlayer().lure.type == LureType.FlyingXL)
            {
                g.DrawEllipse(new Pen(Color.Black), X * 10, Game.Deep / 20, 3, 3);
            }
            else if (Player.getPlayer().lure.type == LureType.TopLarge
                            || Player.getPlayer().lure.type == LureType.TopSmall
                                        || Player.getPlayer().lure.type == LureType.TopXL)
            {
                g.DrawEllipse(new Pen(Color.Black), X * 10, 5, 3, 3);
            }
            else if (Player.getPlayer().lure.type == LureType.XL
                            || Player.getPlayer().lure.type == LureType.Small
                                        || Player.getPlayer().lure.type == LureType.Large)
            {
                g.DrawEllipse(new Pen(Color.Black), X * 10, Game.Deep / 10 - 5, 3, 3);
            }
            else if (Player.getPlayer().lure.type == LureType.DeepXL
                            || Player.getPlayer().lure.type == LureType.DeepSmall
                                        || Player.getPlayer().lure.type == LureType.DeepLarge)
            {
                g.DrawEllipse(new Pen(Color.Black), X * 10, Game.Deep / 10 - 5, 3, 3);
            }
        }
    }
}

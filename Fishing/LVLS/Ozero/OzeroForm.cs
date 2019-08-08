using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fishing
{
    public partial class OzeroForm : Form
    {
        public OzeroForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.UserPaint, true);

            UpdateStyles();
            Game.currentFish = new CurrentFish();
            Game.gui = new GUI();

        }
        public void OzeroForm_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush sbrush = new SolidBrush(Color.White);
            Graphics g = e.Graphics;
            if (Game.isFishAttack == true)
            {
                Game.fishpowerX = Fish.CFish.power;
                Game.fishpowerY = Fish.CFish.power;
                Game.CastPoint.X += Game.moveLeftRigthSpeed;
                Game.CastPoint.Y += Game.moveUpDownSpeed;
            }
            Game.CastPoint.Y += Game.windingSpeed;
            Rectangle rect = new Rectangle(Game.CastPoint.X, Game.roadY, 50, 250);
            Rectangle rect2 = new Rectangle(Game.roadX, Game.roadY, 80, 250);
            Rectangle podsrect = new Rectangle(Game.CastPoint.X, Game.nettingY, 50, 200);
            g.DrawImage(Pictures.netting, podsrect);
            if (Game.isFishAttack == false && Pictures.road != null)
            {
                g.DrawImage(Pictures.road, rect);
                Game.roadX = Game.CastPoint.X;
            }
            if (Game.isFishAttack == true && Pictures.roadMaxBend != null)
            {
                g.DrawImage(Pictures.roadMaxBend, rect2);

            }

            if (Game.CastPoint.Y > 350)
            {
                g.DrawEllipse(new Pen(sbrush), Game.CastPoint.X, Game.CastPoint.Y, 5, 5);
                g.FillEllipse(sbrush, Game.CastPoint.X, Game.CastPoint.Y, 5, 5);

            }
            else if (Game.CastPoint.Y < 350 && Game.CastPoint.Y != 0)
            {
                Game.CastPoint.Y = 349;
                g.DrawEllipse(new Pen(sbrush), Game.CastPoint.X, Game.CastPoint.Y, 5, 5);
                g.FillEllipse(sbrush, Game.CastPoint.X, Game.CastPoint.Y, 5, 5);
            }
        }           //Прорисовка объектов
        private void OzeroForm_Load(object sender, EventArgs e)
        {
           
            Game.gui.Show();
            Game.gui.MoneyLabel.Text = Player.getPlayer().Money.ToString();
        }                //Загрузка OzeroForm
        private void BaitTimer_Tick(object sender, EventArgs e)                   //Получаем рыбу,сходы
        {
            LVL2.lvl2.getFish();
            //LVLS.Ozero.LVL1.lvl1.getFish();
        }
        private void OzeroForm_KeyDown(object sender, KeyEventArgs e)
        {
            for (int x = 0; x < 51; x++)
            {
                for (int y = 0; y < 18; y++)
                {
                    Point between = new Point(Game.CastPoint.X - LVL.Larr[x, y].Location.X, Game.CastPoint.Y - LVL.Larr[x, y].Location.Y);
                    float distance = (float)Math.Sqrt(between.X * between.X + between.Y * between.Y);
                    if (distance < 20) Game.gui.DeepLabel.Text = LVL.Larr[x, y].Tag.ToString();
                    Game.Deep = Convert.ToInt32(Game.gui.DeepLabel.Text);
                }
            }
            switch (e.KeyCode)
            {
                case Keys.G:
                    Game.isBaitMoving = true;
                    if (Game.isFishAttack)
                        Game.windingSpeed = Player.getPlayer().reel.Power;
                    else
                        Game.windingSpeed = Game.gui.SpeedBar.Value;

                    if (Game.roadY < 477)
                        Game.roadY += 7;
                    if (Game.isFishAttack)
                    {
                       
                        if (Game.gui.FLineBar.Value < 100)
                            Game.gui.FLineBar.Increment(Fish.CFish.weight * 20 / (Player.getPlayer().fline.LeskaPower));
                        if (Game.gui.ReelBar.Value > 0)
                            Game.gui.ReelBar.Increment(-(Fish.CFish.weight * 20 / (Player.getPlayer().proad.Power)));
                    }
                    break;
                case Keys.H:
                    if (Game.isFishAttack)
                    {
                        if (Game.gui.ReelBar.Value < 100)
                            Game.gui.ReelBar.Increment(Fish.CFish.weight * 20 / (Player.getPlayer().proad.Power));
                        if (Game.gui.FLineBar.Value > 0)
                            Game.gui.FLineBar.Increment(-(Fish.CFish.weight * 20 / (Player.getPlayer().fline.LeskaPower)));
                    }
                    break;
                case Keys.Space:
                    if (Game.CastPoint.Y > 620)
                        Game.nettingY = 550;
                    break;
            }
        }          //Нажатия кнопок

        private void OzeroForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.G:
                    Game.isBaitMoving = false;
                    Game.windingSpeed = 0;
                    Game.roadY -= 7;
                    break;
                case Keys.H:

                    break;
            }
        }            //Поднятие клавиш
        private void MainTimer_Tick(object sender, EventArgs e)
        {
            LVL2.lvl2.MainTimertick();
        }                //Основные действия
        private void OzeroForm_MouseDown(object sender, MouseEventArgs e)         //Нажатия мышью
        {
            if (!Game.isFishAttack)
            {
                if (Player.getPlayer().proad != null)
                {
                    baitTimer.Start();
                    Game.CastPoint = PointToClient(Cursor.Position);
                    Refresh();
                    Game.roadY = 470;
                    Game.gui.FLineBar.Value = 0;
                    Game.gui.ReelBar.Value = 0;
                    Game.windingSpeed = 0;
                }
                if(Player.getPlayer().lure is null == false)
                baitTimer.Start();
                try
                {
                    if (Player.getPlayer().lure is null && Player.getPlayer().proad.Type == ROAD_TYPE.Spinning)
                    {
                        Game.CastPoint.Y = 0;
                        MessageBox.Show(Game.NO_LURE_EQUIPED);
                    }
                }
                catch(NullReferenceException)
                {
                    Game.CastPoint.Y = 0;
                }

            }
        }      
        private void FishMovesTimer_Tick(object sender, EventArgs e)
        {
            if (Game.isFishAttack)
            {
                Game.moveLeftRigthSpeed = Game.fishMovingX.Next(-Game.fishpowerX, Game.fishpowerX);
                Game.moveUpDownSpeed = Game.fishMovingY.Next(-Game.fishpowerY, 1);
            }
        }           //Движение рыбы
        private void OzeroForm_MouseClick(object sender, MouseEventArgs e)
        {
            for (int x = 0; x < 51; x++)
            {
                for (int y = 0; y < 18; y++)
                {

                    Point between = new Point(Game.CastPoint.X - LVL.Larr[x, y].Location.X, Game.CastPoint.Y - LVL.Larr[x, y].Location.Y);
                    float distance = (float)Math.Sqrt(between.X * between.X + between.Y * between.Y);
                    if (distance < 20) Game.gui.DeepLabel.Text = LVL.Larr[x, y].Tag.ToString();
                    Game.Deep = Convert.ToInt32(Game.gui.DeepLabel.Text);
                }
            }
        }     //Вычисляем длину
                                                                                  //Теорема Пифгора

        private void GatheringTimer_Tick(object sender, EventArgs e)
        {
            if (Game.isFishAttack == true)
            {
                Game.gui.EventsBox.Items.Add(Player.getPlayer().NickName + " Сход =(");
                Game.isFishAttack = false;
                GatheringTimer.Stop();
            }
        }           //Через сколько будет сход
    }
}

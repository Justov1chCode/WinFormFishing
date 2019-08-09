using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
            for (int x = 0; x < 51; x++)
            {
                for (int y = 0; y < 18; y++)
                {
                    LVL.Larr[x, y] = new Label()
                    {
                        Left = 5 + x * 20,
                        Top = 350 + y * 20,
                        Height = 20,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Width = 20,
                        Visible = false,

                    };

                    Controls.Add(LVL.Larr[x, y]);
                    LVL.Larr[x, y].MouseClick += GUI_MouseClick;
                }
            }
            Sounder sounder = new Sounder(SounderPanel, SounderUpdater);
        }

        private void MapLabel_Click(object sender, EventArgs e)
        {
            Ozero ozero = new Ozero();
            ozero.Show();
        }

        private void InventoryLabel_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            inv.Show();
        }


        private void SettingsLabel_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void FPondLabel_Click(object sender, EventArgs e)
        {
            fishesForm form2 = new fishesForm();
            form2.Show();
        }

        private void MenuLabel_Click(object sender, EventArgs e)
        {
            Menu menuf = new Menu();
            this.Close();
            Game.ozeroForm.Close();
            menuf.Show();
        }


        private void GUI_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Game.isFishAttack)
            {
                
                for (int x = 0; x < 51; x++)
                {
                    for (int y = 0; y < 18; y++)
                    {
                        Game.CastPoint = PointToClient(Cursor.Position);
                        Point between = new Point(Game.CastPoint.X - LVL.Larr[x, y].Location.X, Game.CastPoint.Y - LVL.Larr[x, y].Location.Y);
                        float distance = (float)Math.Sqrt(between.X * between.X + between.Y * between.Y);
                    }
                }



            }
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            SounderPanel.BackColor = Color.Aquamarine;
        }
    }
}

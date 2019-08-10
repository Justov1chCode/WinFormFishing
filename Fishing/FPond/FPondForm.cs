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
    public partial class fishesForm : Form
    {
        public fishesForm()
        {
            InitializeComponent();
        }

        private void FishesForm_Load(object sender, EventArgs e)
        {
            foreach (Fish i in Player.getPlayer().fishlist)
                FishList.Items.Add(i.name + " " +i.weight+ "г");
        }

        private void FishList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is ArcticChar)
                    FishImage.Image = Resource1.GOLEC;
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is Perch)
                    FishImage.Image = Resource1.PERCH;
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is PinkSalmon)
                    FishImage.Image = Resource1.GORBUSHA;
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is Pike)
                    FishImage.Image = Resource1.PIKE;
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is Sturgeon)
                    FishImage.Image = Resource1.OSETR;
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is Beluga)
                    FishImage.Image = Resource1.BELUGA;
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is Catfish)
                    FishImage.Image = Resource1.CATFISH;
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is Roach)
                    FishImage.Image = Resource1.PLOTVA;
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is SilverCarp)
                    FishImage.Image = Resource1.KARASS;
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is Vimba)
                    FishImage.Image = Resource1.RIBEC;
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is Cancer)
                    FishImage.Image = Resource1.RAK;
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is Bream)
                    FishImage.Image = Resource1.LESH;
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }


        private void FishesForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            try
            {
                Player.getPlayer().Money += (int)Player.getPlayer().fishlist[FishList.SelectedIndex].price * Player.getPlayer().fishlist[FishList.SelectedIndex].weight;
                Game.gui.MoneyLabel.Text = Player.getPlayer().Money.ToString();
                Player.getPlayer().fishlist.Remove(Player.getPlayer().fishlist[FishList.SelectedIndex]);
                FishList.Items.Remove(Player.getPlayer().fishlist[FishList.SelectedIndex]);
                Refresh();
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }
    }
}

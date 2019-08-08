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
                    FishImage.Image = Resource1.golec;
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is Perch)
                    FishImage.Image = Resource1.okyn;
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is PinkSalmon)
                    FishImage.Image = Resource1.gorbysha;
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is Pike)
                    FishImage.Image = Resource1.pike1;
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is Sturgeon)
                    FishImage.Image = Resource1.osetr;
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is Beluga)
                    FishImage.Image = Resource1.beluga;
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is Catfish)
                    FishImage.Image = Resource1.catfish;
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is Roach)
                    FishImage.Image = Resource1.plotva;
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is SilverCarp)
                    FishImage.Image = Resource1.karass;
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is Vimba)
                    FishImage.Image = Resource1.ribec;
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is Cancer)
                    FishImage.Image = Resource1.rak;
                if (Player.getPlayer().fishlist[FishList.SelectedIndex] is Bream)
                    FishImage.Image = Resource1.lesh;
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

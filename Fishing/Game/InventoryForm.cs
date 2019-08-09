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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }
        private Road road;
        private Lure lure;
        private Reel reel;
        private FLine fline;

        private void Inventory_Load(object sender, EventArgs e)
        {
            assembliesBox.DataSource = Assembly.GetAssemblies();
            RoadsList.DataSource = Item.RoadInv;
            ReelsList.DataSource = Item.ReelInv;
            FLineList.DataSource = Item.LeskaInv;
            LuresList.DataSource = Item.LureInv;
        }

        private void RoadsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = RoadsList.SelectedIndex;
                pictureBox5.Image = Item.RoadInv[index].Pict;
                nameBox.Text = Item.RoadInv[index].Name;
                powerBox.Text = (Item.RoadInv[index].Power / 1000).ToString();
                typeBox.Text = Item.RoadInv[index].Type.ToString();
            }
            catch (Exception) { }
        }

        private void RoadsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = RoadsList.SelectedIndex;
            road = Item.RoadInv[index];
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FLineList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = FLineList.SelectedIndex;
                fline = Item.LeskaInv[index];
            }
            catch (Exception) { }
        }

        private void FLineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = FLineList.SelectedIndex;
                pictureBox5.Image = Item.LeskaInv[index].Pict;
                nameBox.Text = Item.LeskaInv[index].Name;
                powerBox.Text = Item.LeskaInv[index].LeskaPower.ToString();
                typeBox.Text = "Леска";
            }
            catch (Exception) { }
        }

        private void ReelsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = ReelsList.SelectedIndex;
                typeBox.Text = "Катушка";
                pictureBox5.Image = Item.ReelInv[index].Pict;
                nameBox.Text = Item.ReelInv[index].Name;
                powerBox.Text = Item.ReelInv[index].Power.ToString();
            }
            catch (Exception) { }
        }

        private void ReelsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = ReelsList.SelectedIndex;
                reel = Item.ReelInv[index];
            }
            catch (Exception) { }
        }

        private void LuresList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = LuresList.SelectedIndex;
                powerBox.Text = "-";
                typeBox.Text = Item.LureInv[index].type.ToString();
                pictureBox5.Image = Item.LureInv[index].pic;
                nameBox.Text = Item.LureInv[index].name;
                countBox.Text = Item.LureInv[index].count.ToString();
            }
            catch (Exception) { }
        }

        private void LuresList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = LuresList.SelectedIndex;
                lure = Item.LureInv[index];
            }
            catch (Exception) { }
        }

        private void FetchButton_Click(object sender, EventArgs e)
        {
            try
            {
                Assembly.addAssembly(new Assembly(road.Name, road, reel, fline, lure, road.Type));
            }
            catch (Exception) {
                MessageBox.Show("Выбраны не все элементы!");
            }
        }

        private void AssembliesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = assembliesBox.SelectedIndex;
                RoadBox.Image = Assembly.GetAssemblies()[index].proad.Pict;
                ReelBox.Image = Assembly.GetAssemblies()[index].reel.Pict;
                FLineBox.Image = Assembly.GetAssemblies()[index].fLine.Pict;
                BaitBox.Image = Assembly.GetAssemblies()[index].lure.pic;
            }
            catch(Exception)
            {

            }
        }

        private void AssembliesBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = assembliesBox.SelectedIndex;
                RoadBox.Image = Assembly.GetAssemblies()[index].proad.Pict;
                ReelBox.Image = Assembly.GetAssemblies()[index].reel.Pict;
                FLineBox.Image = Assembly.GetAssemblies()[index].fLine.Pict;
                BaitBox.Image = Assembly.GetAssemblies()[index].lure.pic;
                road = Assembly.GetAssemblies()[index].proad;
                reel = Assembly.GetAssemblies()[index].reel;
                fline = Assembly.GetAssemblies()[index].fLine;
                lure = Assembly.GetAssemblies()[index].lure;
                Player.getPlayer().setAssembly(road, reel, fline, lure);
            }
            catch (Exception)
            {

            }
        }
    }
}

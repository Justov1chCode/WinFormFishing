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
    public partial class Shop : Form
    {
        Inventory inv;
        public Shop()
        {
            InitializeComponent();
            inv = new Inventory();
            Item.RoadShop.Add(Road.Titanium);
            Item.RoadShop.Add(Road.Achilles);
            Item.RoadShop.Add(Road.YSuperCarp);
            Item.ReelShop.Add(Reel.Hydra);
            Item.ReelShop.Add(Reel.Marco_R1);
            Item.ReelShop.Add(Reel.Quest_Reel);
            Item.LeskaShop.Add(FLine.Quest_Fishers);
            Item.LeskaShop.Add(FLine.Colorado);
            Item.LeskaShop.Add(FLine.Indiana1500);
            Item.ReelShop.Add(Reel.Marco_R6);
            Item.ReelShop.Add(Reel.Zymix);
            for (int i = 0; i < Item.RoadShop.Count; i++)
                RoadsList.Items.Add(Item.RoadShop[i].Name);
            for (int i = 0; i < Item.ReelShop.Count; i++)
                ReelsList.Items.Add(Item.ReelShop[i].Name);
            for (int i = 0; i < Item.LeskaShop.Count; i++)
                FLineList.Items.Add(Item.LeskaShop[i].Name);
            moneyBox.Text = "Деньги: " + Player.getPlayer().Money;
        }

        private void Shop_Leave(object sender, EventArgs e)
        {
            Game.gui.MoneyLabel.Text = "Деньги:" + Player.getPlayer().Money;
        }    //Выход из магазина
        private void RoadsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                itemBox.Image = Item.RoadShop[RoadsList.SelectedIndex].Pict;
                nameBox.Text = Item.RoadShop[RoadsList.SelectedIndex].Name;
                powerBox.Text = Item.RoadShop[RoadsList.SelectedIndex].Power.ToString();
                priceBox.Text = Item.RoadShop[RoadsList.SelectedIndex].Price.ToString();
                typeBox.Text = Item.RoadShop[RoadsList.SelectedIndex].Type.ToString();
                label1.Text = " ";
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }          //Выбор удочки
        private void RoadsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (Player.getPlayer().Money >= Item.RoadShop[RoadsList.SelectedIndex].Price)
                {
                    Item.RoadInv.Add(Item.RoadShop[RoadsList.SelectedIndex]);
                    label1.Text = "Приобретено...";
                    Player.getPlayer().Money -= Item.RoadShop[RoadsList.SelectedIndex].Price;
                    moneyBox.Text = "Деньги: " + Player.getPlayer().Money;
                }
                else label1.Text = "Недостаточно средств";
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }//Удочка выбрана

        private void ReelsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                itemBox.Image = Item.ReelShop[ReelsList.SelectedIndex].Pict;
                nameBox.Text = Item.ReelShop[ReelsList.SelectedIndex].Name;
                powerBox.Text = Item.ReelShop[ReelsList.SelectedIndex].Power.ToString();
                priceBox.Text = Item.ReelShop[ReelsList.SelectedIndex].Price.ToString();
                label1.Text = " ";
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }//Выбор катушки
        private void ReelsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (Player.getPlayer().Money >= Item.ReelShop[ReelsList.SelectedIndex].Price)
                {
                    Item.ReelInv.Add(Item.ReelShop[ReelsList.SelectedIndex]);
                    label1.Text = "Приобретено...";
                    Player.getPlayer().Money -= Item.ReelShop[ReelsList.SelectedIndex].Price;
                    moneyBox.Text = "Деньги: " + Player.getPlayer().Money;
                }
                else label1.Text = "Недостаточно средств";
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }//Катушка выбрана

        private void FLinesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                itemBox.Image = Item.LeskaShop[FLineList.SelectedIndex].Pict;
                nameBox.Text = Item.LeskaShop[FLineList.SelectedIndex].Name;
                powerBox.Text = Item.LeskaShop[FLineList.SelectedIndex].LeskaPower.ToString();
                priceBox.Text = Item.LeskaShop[FLineList.SelectedIndex].Price.ToString();
                label1.Text = " ";
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }//Выбор лески

        private void FLinesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (Player.getPlayer().Money >= Item.LeskaShop[FLineList.SelectedIndex].Price)
                {
                    Item.LeskaInv.Add(Item.LeskaShop[FLineList.SelectedIndex]);
                    label1.Text = "Приобретено...";
                    Player.getPlayer().Money -= Item.LeskaShop[FLineList.SelectedIndex].Price;
                    moneyBox.Text = "Деньги: " + Player.getPlayer().Money;
                }
                else label1.Text = "Недостаточно средств";
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        } //Леска выбрана

        private void CloseButton_Click(object sender, EventArgs e)             //Выход из магазина
        {
            this.Close();
        }

        private void Shop_Load(object sender, EventArgs e)
        {

        }
    }
}

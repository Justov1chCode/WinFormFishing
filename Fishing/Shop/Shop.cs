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
            RoadsList.DataSource = Item.RoadShop;
            ReelsList.DataSource = Item.ReelShop;
            FLineList.DataSource = Item.LeskaShop;
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

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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Item.LureInv.Add(Lure.vob1);
            Item.LureInv.Add(Lure.vob2);
            Item.LureInv.Add(Lure.vob3);
            Item.LureInv.Add(Lure.vob4);
            Item.LureInv.Add(Lure.jelezo2);
            Item.LureInv.Add(Lure.jelezo3);
            Item.LureInv.Add(Lure.jelezo4);
            Item.RoadShop.Add(Road.Titanium);
            Item.RoadShop.Add(Road.Achilles);
            Item.RoadShop.Add(Road.YSuperCarp);
            Item.ReelShop.Add(Reel.Hydra);
            Item.ReelShop.Add(Reel.SYBERIA_LT_2);
            Item.ReelShop.Add(Reel.Quest_Reel);
            Item.LeskaShop.Add(FLine.Quest_Fishers);
            Item.LeskaShop.Add(FLine.Colorado);
            Item.LeskaShop.Add(FLine.Indiana1500);
            Item.ReelShop.Add(Reel.SYBERIA_4);
            Item.ReelShop.Add(Reel.Zymix);
        }

        private void MapButton_Click(object sender, EventArgs e)
        {         
            Ozero ozero = new Ozero();         
            ozero.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.Show();
        }

        private void ShopButton_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop();
            shop.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            label2.Text += "Игрок: " + Player.getPlayer().NickName + "                              " + Player.getPlayer().Money;
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            inv.Show();
        }
    }
}

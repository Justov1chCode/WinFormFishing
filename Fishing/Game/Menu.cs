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
            Item.BaitsInv.Add(Baits.Molusk);
            Item.BaitsInv.Add(Baits.jhivec);
            Item.BaitsInv.Add(Baits.oparish);
            Item.BaitsInv.Add(Baits.worm);
            Item.BaitsInv.Add(Baits.fishm);
            Item.LureInv.Add(Lure.vob1);
            Item.LureInv.Add(Lure.vob2);
            Item.LureInv.Add(Lure.vob3);
            Item.LureInv.Add(Lure.vob4);
            Item.LureInv.Add(Lure.jelezo1);
            Item.LureInv.Add(Lure.jelezo2);
            Item.LureInv.Add(Lure.jelezo3);
            Item.LureInv.Add(Lure.jelezo4);
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

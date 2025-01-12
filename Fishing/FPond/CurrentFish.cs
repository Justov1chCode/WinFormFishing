﻿using System;
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
    public partial class CurrentFish : Form
    {
        public CurrentFish()
        {
            InitializeComponent();
        }

        private void CurrentFish_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Player.getPlayer().fishlist.Add(Fish.CFish);
                this.Close();
            }
            if(e.KeyCode == Keys.F)
            {
                if (PriceButton.Text.Length > 0)
                {
                    Player.getPlayer().Money += Convert.ToInt32(PriceButton.Text);
                    MessageBox.Show("Продано");
                    Game.gui.MoneyLabel.Text = Convert.ToString(Player.getPlayer().Money);
                    this.Close();
                }
            }

        }   //Нажатия кнопок
    }
}

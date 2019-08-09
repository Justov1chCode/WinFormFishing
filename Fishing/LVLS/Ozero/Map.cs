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
    public partial class Ozero : Form
    {
        public Ozero()
        {
            InitializeComponent();
            Game.ozeroForm = new OzeroForm();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Game.ozeroForm.Show();
            LVL2.lvl2.SetDeep();
            LVL2.lvl2.addFishes();
            Game.ozeroForm.BackgroundImage = Resource1.ozerolvl2;
        }

        private void Label3_Click(object sender, EventArgs e)
        {
        }

        private void Ozero_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

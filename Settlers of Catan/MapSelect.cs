using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOCForm
{
    public partial class MapSelect : Form
    {
        public Form startMenu;
        public MapSelect(Form StartMenu)
        {
            InitializeComponent();
            this.startMenu = StartMenu;
        }

        private void MapSelect_Load(object sender, EventArgs e)
        {

        }

        private void onePlayerBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(1);
            f1.Show();
        }

        private void twoPlayerBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(2);
            f1.Show();
        }

        private void threePlayerBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(3);
            f1.Show();
        }

        private void fourPlayerBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(4);
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            this.startMenu.Show();
            
        }
    }
}

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

        private void onePlayerBtn_Click(object sender, EventArgs e)
        {
            DifficultySelect f1 = new DifficultySelect(this, 1 ,3);
            f1.Show();
            this.Close();
        }

        private void twoPlayerBtn_Click(object sender, EventArgs e)
        {
            DifficultySelect f1 = new DifficultySelect(this, 2, 2);
            f1.Show();
            this.Close();
        }

        private void threePlayerBtn_Click(object sender, EventArgs e)
        {
            DifficultySelect f1 = new DifficultySelect(this, 3, 1);
            f1.Show();
            this.Close();
        }

        private void fourPlayerBtn_Click(object sender, EventArgs e)
        {
            DifficultySelect f1 = new DifficultySelect(this, 4, 0);
            f1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            this.startMenu.Show();
            
        }
    }
}

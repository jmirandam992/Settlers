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
    public partial class DifficultySelect : Form
    {
        public Form MapSelect;
        private int players;
        private int ai;


        public DifficultySelect(Form mapSelect, int Players, int Ai)
        {
            InitializeComponent();
            this.MapSelect = mapSelect;
            players = Players;
            ai = Ai;

        }

        private void easyBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(players, ai, 1);
            form1.Show();
            this.Close();
        }

        private void insaneBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(players, ai, 10);
            form1.Show();
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.MapSelect.Show();
        }
    }
}

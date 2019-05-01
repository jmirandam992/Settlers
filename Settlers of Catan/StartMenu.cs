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
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect s = new MapSelect(this);
            s.Show();
            


        }

        private void rulesBtn_Click(object sender, EventArgs e)
        {

            Rules r = new Rules(this);
            r.Show();
            this.Hide();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SOCForm
{
    public partial class Rules : Form
    {
        public Form startMenu;

        public Rules(Form StartMenu)
        {
            InitializeComponent();
            this.startMenu = StartMenu;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.startMenu.Show();
        }
    }
}

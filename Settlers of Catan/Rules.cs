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
        public Form mainWindows;

        public Rules(Form MainWindows)
        {
            InitializeComponent();
            this.mainWindows = MainWindows;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.mainWindows.Visible = true;
        }
    }
}

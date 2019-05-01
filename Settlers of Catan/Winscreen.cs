using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winScreen
{
    public partial class frmWinner : Form
    {
        public frmWinner()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Blank dialog result for messages for buttons.
        /// </summary>
        public DialogResult yes;

        /// <summary>
        /// Replays the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReplay_Click(object sender, EventArgs e)
        {
            this.yes = MessageBox.Show("Do you wish to play again?","Play Again", MessageBoxButtons.YesNo);
        }

        /// <summary>
        /// Closes application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.yes = MessageBox.Show("Do you wish to close?", "Closing Game", MessageBoxButtons.YesNo);
            if (yes == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

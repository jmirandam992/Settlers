using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOCForm.Classes
{
    class Dice
    {

        ///// <summary>
        ///// The value for the first die.
        ///// </summary>
        //public int die1;

        ///// <summary>
        ///// The value for the second die.
        ///// </summary>
        //public int die2;

        ///// <summary>
        ///// The total roll for die1 and die2.
        ///// </summary>
        //public int rollTotal;

        ///// <summary>
        ///// Random for both die 1 and die two.
        ///// </summary>
        //public Random r;

        //private void TmrDieRoll_Tick(object sender, EventArgs e)
        //{
        //    //declared new random
        //    r = new Random();

        //    //progressbar increment
        //    progressBar1.Increment(10);

        //    //set randoms
        //    die1 = r.Next(0, 6);
        //    die2 = r.Next(0, 6);

        //    switch (die1)
        //    {
        //        case 1:
        //            pnlDie1.BackgroundImage = Properties.Resources.two;

        //            break;
        //        case 2:
        //            pnlDie1.BackgroundImage = Properties.Resources.three;
        //            break;
        //        case 3:
        //            pnlDie1.BackgroundImage = Properties.Resources.four;

        //            break;
        //        case 4:
        //            pnlDie1.BackgroundImage = Properties.Resources.five;

        //            break;
        //        case 5:
        //            pnlDie1.BackgroundImage = Properties.Resources.six;

        //            break;
        //        default:
        //            pnlDie1.BackgroundImage = Properties.Resources.one;

        //            break;

        //    }

        //    switch (die2)
        //    {
        //        case 1:
        //            pnlDie2.BackgroundImage = Properties.Resources.two;

        //            break;
        //        case 2:
        //            pnlDie2.BackgroundImage = Properties.Resources.three;
        //            break;
        //        case 3:
        //            pnlDie2.BackgroundImage = Properties.Resources.four;

        //            break;
        //        case 4:
        //            pnlDie2.BackgroundImage = Properties.Resources.five;

        //            break;
        //        case 5:
        //            pnlDie2.BackgroundImage = Properties.Resources.six;

        //            break;
        //        default:
        //            pnlDie2.BackgroundImage = Properties.Resources.one;

        //            break;

        //    }

        //    if (progressBar1.Value == 100)
        //    {
        //        tmrDieRoll.Stop();
        //    }


        //}

        //private void PnlDie1_Click(object sender, EventArgs e)
        //{
        //    progressBar1.Value = 0;
        //    pnlDie1.BackgroundImage = null;
        //    tmrDieRoll.Start();
        //}

        //private void PnlDie2_Click(object sender, EventArgs e)
        //{
        //    progressBar1.Value = 0;
        //    pnlDie2.BackgroundImage = null;
        //    tmrDieRoll.Start();
        //}

        //private void pnlDie1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    progressBar1.Value = 0;
        //    pnlDie1.BackgroundImage = null;
        //    tmrDieRoll.Start();
        //}

        //private void pnlDie2_MouseClick(object sender, MouseEventArgs e)
        //{
        //    progressBar1.Value = 0;
        //    pnlDie2.BackgroundImage = null;
        //    tmrDieRoll.Start();
        //}
    }
}

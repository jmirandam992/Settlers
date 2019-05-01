using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOCForm.Classes
{
    public class Dice
    {
        public Form1 game;

        public Dice()
        {

        }
        public Dice(Form1 Game)
        {
            this.game = Game;
        }

        
        

        ///// <summary>
        ///// The value for the first die.
        ///// </summary>
        public int die1;

        ///// <summary>
        ///// The value for the second die.
        ///// </summary>
        public int die2;

        ///// <summary>
        ///// The total roll for die1 and die2.
        ///// </summary>
        public int rollTotal;

        ///// <summary>
        ///// Random for both die 1 and die two.
        ///// </summary>
        public Random r;

        public void RollDie(PictureBox d1, PictureBox d2)
        {
            //    //declared new random
            r = new Random();

            //    //set randoms
            die1 = r.Next(0, 6);
            die2 = r.Next(0, 6);

            switch (die1)
            {
                case 1:

                    d1.Image = Properties.Resources.two;

                    break;
                case 2:
                    d1.Image = Properties.Resources.three;
                    break;
                case 3:
                    d1.Image = Properties.Resources.four;

                    break;
                case 4:
                    d1.Image = Properties.Resources.five;

                    break;
                case 5:
                    d1.Image = Properties.Resources.six;

                    break;
                default:
                  d1.Image = Properties.Resources.one;

                    break;

            }

            switch (die2)
            {
                case 1:
                    d2.Image = Properties.Resources.two;

                    break;
                case 2:
                    d2.Image = Properties.Resources.three;
                    break;
                case 3:
                    d2.Image = Properties.Resources.four;

                    break;
                case 4:
                    d2.Image = Properties.Resources.five;

                    break;
                case 5:
                    d2.Image = Properties.Resources.six;

                    break;
                default:
                   d2.Image = Properties.Resources.one;

                    break;
            }

            }
     
        }
    }


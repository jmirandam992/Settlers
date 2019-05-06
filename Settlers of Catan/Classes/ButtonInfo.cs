using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOCForm.Classes
{
    public class ButtonInfo
    {
        public ButtonInfo(Form1 form, Hexagon[] grid, List<PictureBox> background, ButtonManager btnManager, PiecePlacement Place, bool IsRoad, int index, int hexloc, int location)
        {
            this.Index = index;
            this.Form = form;
            this.Grid = grid;
            this.place = Place;
            this.isRoad = IsRoad;
            this.Hexscape = hexloc;
            this.Location = location;
            this.Background = background;
            this.Parent = btnManager;
        }

        public int Index;
        public Form1 Form;
        public int Location;
        public int Hexscape;
        public bool isRoad;
        public Hexagon[] Grid;
        public List<PictureBox> Background;
        private PiecePlacement place;
        public ButtonManager Parent;

        public void click()
        {
            // Generates img.
            if (isRoad)
            {
                place.Road(Form, Grid, Background, Hexscape, Location);
                Parent.pressedRoads.Add(Index);
            }
            else
            {
                place.Town(Form, Grid, Background, Hexscape, Location);
                Parent.pressedTowns.Add(Index);
            }

            // Generates buttons.
            this.nextBtn();
            this.linkHex();

            // Runs the click method.
            this.Parent.click();
        }

        private void nextBtn()
        {
            if (Location == 0)
            {
                active(Index, Index);
                active(Index + 1, Index + 5);
            }
            else if (Location == 5)
            {
                active(Index, Index);
                active(Index - 5, Index - 1);
            }
            else
            {
                active(Index, Index);
                active(Index + 1, Index - 1);
            }
        }

        private void linkHex()
        {
            if (!isRoad)
            {
                if (Location == 0)
                {
                    if ((Hexscape > 2 && Hexscape < 6) || (Hexscape > 15 && Hexscape < 19))
                    {
                        // 3 Jump-back | Pos 1
                        active(0, Index - 14);
                    }
                    if (Hexscape == 6)
                    {
                        // 3 Jump Back | Pos 4
                        active(0, Index - 23);
                    }
                    if (Hexscape == 7 || (Hexscape > 11 && Hexscape < 16))
                    {
                        // 3 Jump Back | Pos 1
                        active(0, Index - 20);
                    }
                    if (Hexscape > 7 && Hexscape < 12)
                    {
                        // 4 Jump Back | Pos 4
                        active(0, Index - 29);
                    }
                }
                if (Location == 1)
                {
                    if (Hexscape != 2 && Hexscape != 6 && Hexscape != 11 && Hexscape != 15 && Hexscape != 18)
                    {
                        active(0, Index + 10);
                    }
                    else if (Hexscape == 15)
                    {
                        // 4 Jump Back | Pos 5
                        active(0, Index - 23);
                    }
                    else if (Hexscape == 18)
                    {
                        // 3 Jump Back | Pos 5
                        active(0, Index - 17);
                    }
                }
                if (Location == 2)
                {
                    if (Hexscape != 2 && Hexscape != 6 && Hexscape != 11 && Hexscape != 15 && Hexscape != 18)
                    {
                        active(0, Index + 7);
                    }
                    else if (Hexscape == 2)
                    {
                        // 4 Jump | Pos 2
                        active(0, Index + 22);
                    }
                    else if (Hexscape == 6)
                    {
                        // 5 Jump | Pos 2
                        active(0, Index + 28);
                    }
                }
                if (Location == 3)
                {
                    if ((Hexscape >= 0 && Hexscape < 3) || (Hexscape > 12 && Hexscape < 16))
                    {
                        // 3 Jump-back | Pos 1
                        active(0, Index + 16);
                    }
                    if ((Hexscape > 2 && Hexscape < 7) || (Hexscape > 7 && Hexscape < 12))
                    {
                        // 4 Jump | Pos 1
                        active(0, Index + 22);
                    }
                    if (Hexscape == 7)
                    {
                        // 5 Jump | Pos 4
                        active(0, Index + 31);
                    }
                    if (Hexscape == 12)
                    {
                        // 4 Jump Back | Pos 4
                        active(0, Index + 25);
                    }
                }
                if (Location == 4)
                {
                    if (Hexscape != 0 && Hexscape != 3 && Hexscape != 7 && Hexscape != 12 && Hexscape != 16)
                    {
                        active(0, Index - 8);
                    }
                    else if (Hexscape == 0)
                    {
                        // 4 Jump | Pos 2
                        active(0, Index + 19);
                    }
                    else if (Hexscape == 3)
                    {
                        // 5 Jump | Pos 2
                        active(0, Index + 25);
                    }
                }
                if (Location == 5)
                {
                    if (Hexscape != 0 && Hexscape != 3 && Hexscape != 7 && Hexscape != 12 && Hexscape != 16)
                    {
                        active(0, Index - 11);
                    }
                    else if (Hexscape == 12)
                    {
                        // 4 Jump Back | Pos 3
                        active(0, Index - 32);
                    }
                    else if (Hexscape == 16)
                    {
                        // 3 Jump Back | Pos 3
                        active(0, Index - 26);
                    }
                }
            }
        }

        private void active(int townIndex, int roadIndex)
        {
            
            if (isRoad)
            {
                Parent.townBtns[townIndex].BringToFront();
                Parent.townBtns[townIndex].Enabled = true;
            }
            else
            {
                if (Parent.clicks > 2)
                {
                    Parent.roadBtns[roadIndex].BringToFront();
                    Parent.roadBtns[roadIndex].Enabled = true;
                }
                else
                {
                    Parent.disabledBtns.Add(roadIndex);
                }
            }
        }
    }
}

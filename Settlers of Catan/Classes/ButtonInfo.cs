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

        // ERROR: Not loading the third road BTN for some reason unless it just loads the first road and not the first two.
        private void linkHex()
        {
            if (!isRoad)
            {
                if (Location == 0)
                {
                    if (Hexscape > 2 && Hexscape < 7)
                    {
                        active(0, Index - 22);
                        active(Index, Index);
                        active(Index + 1, Index + 5);
                        
                    }
                    
                }
                if (Location == 1)
                {
                    active(0, Index + 9);
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

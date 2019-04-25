using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOCForm.Classes
{
    public class ButtonManager
    {
        public ButtonManager()
        {
            btnHalf = btnSize / 2;
        }
        public int hexSize; 
        private int btnSize = 30;
        private int btnHalf;
        private Color btnColor = Color.Red;

        public void genAllBtn(Form1 form, Hexagon[] Grid)
        {
            for (int i = 0; i < Grid.Length; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    this.TownBtnLcn(form, Grid, i, j);
                }
                for (int j = 0; j < 6; j++)
                {
                    this.RoadBtnLcn(form, Grid, i, j);
                }
            }
        }
        public void TownBtnLcn(Form1 form, Hexagon[] Grid, int hexRef, int loc)
        {
            if (loc == 0)
            {
                HouseGen(form, Grid, loc, hexRef, ((hexSize / 2) - btnHalf), -btnHalf);
            }
            if (loc == 1)
            {
                HouseGen(form, Grid, loc, hexRef, (hexSize - btnHalf), (hexSize / 4) - btnHalf);
            }
            if (loc == 2)
            {
                HouseGen(form, Grid, loc, hexRef, (hexSize - btnHalf), (hexSize / 4) + (hexSize / 2) - btnHalf);
            }
            if (loc == 3)
            {
                HouseGen(form, Grid, loc, hexRef, ((hexSize / 2) - btnHalf), (hexSize - btnHalf));
            }
            if (loc == 4)
            {
                HouseGen(form, Grid, loc, hexRef, -btnHalf, (hexSize / 4) + (hexSize / 2) - btnHalf);
            }
            if (loc == 5)
            {
                HouseGen(form, Grid, loc, hexRef, -btnHalf, (hexSize / 4) - btnHalf);
            }
        }

        public void RoadBtnLcn(Form1 form, Hexagon[] Grid, int loc, int hexRef)
        {
            if (loc == 0)
            {
                RoadGen(form, Grid, loc, hexRef, ((hexSize / 2) + (btnHalf * 3)), btnHalf);
            }
            if (loc == 1)
            {
                RoadGen(form, Grid, loc, hexRef, (hexSize - btnHalf), (hexSize / 4) + 75);
            }
            if (loc == 2)
            {
                RoadGen(form, Grid, loc, hexRef, (hexSize / 2 + (btnHalf * 3)), (hexSize / 4) + (hexSize / 2) + btnHalf);
            }
            if (loc == 3)
            {
                RoadGen(form, Grid, loc, hexRef, ((hexSize / 2) - 75), (hexSize - 65));
            }
            if (loc == 4)
            {
                RoadGen(form, Grid, loc, hexRef, -btnHalf, (hexSize / 4) + (hexSize / 2) - 90);
            }
            if (loc == 5)
            {
                RoadGen(form, Grid, loc, hexRef, 60, (hexSize / 4) - (btnHalf * 3));
            }
        }
        private void HouseGen(Form1 form, Hexagon[] Grid, int loc, int hexRef, int x, int y)
        {
            Point newLoc = new Point(Grid[hexRef].LocX + x, Grid[hexRef].LocY + y); // Set whatever you want for initial location
            Button b = new Button();
            b.Height = btnSize;
            b.Width = btnSize;
            b.Location = newLoc;
            b.BackColor = btnColor;
            newLoc.Offset(0, b.Height + 5);
            form.Controls.Add(b);
            b.BringToFront();
        }
        private void RoadGen(Form1 form, Hexagon[] Grid, int loc, int hexRef, int x, int y)
        {
            Point newLoc = new Point(Grid[hexRef].LocX + x, Grid[hexRef].LocY + y); // Set whatever you want for initial location
            Button b = new Button();
            b.Size = new Size(btnSize, btnSize);
            b.Location = newLoc;
            b.BackColor = btnColor;
            // newLoc.Offset(0, b.Height + 5);
            form.Controls.Add(b);
        }
    }
}

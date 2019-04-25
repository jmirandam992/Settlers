using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOCForm.Classes
{
    public class PiecePlacement
    {
        public PiecePlacement(int HexSize)
        {
            this.hexSize = HexSize;
        }

        private int hexSize;
        private int townSize = 30;
        private int roadSize = 30;

        public void Towns(Form1 form, Hexagon[] Grid, int hexRef, int loc)
        {
            if (loc == 0)
            {
                HouseGen(form, Grid, loc, hexRef, ((hexSize / 2) - (townSize / 2)), -(townSize / 2));
            }
            if (loc == 1)
            {
                HouseGen(form, Grid, loc, hexRef, (hexSize - (townSize / 2)), (hexSize / 4) - (townSize / 2));
            }
            if (loc == 2)
            {
                HouseGen(form, Grid, loc, hexRef, (hexSize - (townSize / 2)), (hexSize / 4) + (hexSize / 2) - (townSize / 2));
            }
            if (loc == 3)
            {
                HouseGen(form, Grid, loc, hexRef, ((hexSize / 2) - (townSize / 2)), (hexSize - (townSize / 2)));
            }
            if (loc == 4)
            {
                HouseGen(form, Grid, loc, hexRef, -(townSize / 2), (hexSize / 4) + (hexSize / 2) - (townSize / 2));
            }
            if (loc == 5)
            {
                HouseGen(form, Grid, loc, hexRef, -(townSize / 2), (hexSize / 4) - (townSize / 2));
            }
        }

        public void Roads(Form1 form, Hexagon[] Grid, int loc, int hexRef)
        {
            if (loc == 0)
            {
                RoadGen(form, Grid, loc, hexRef, ((hexSize / 2) + 45), 15);
            }
            if (loc == 1)
            {
                RoadGen(form, Grid, loc, hexRef, (hexSize - 15), (hexSize / 4) + 75);
            }
            if (loc == 2)
            {
                RoadGen(form, Grid, loc, hexRef, (hexSize / 2 + 45), (hexSize / 4) + (hexSize / 2) + 15);
            }
            if (loc == 3)
            {
                RoadGen(form, Grid, loc, hexRef, ((hexSize / 2) - 75), (hexSize - 65));
            }
            if (loc == 4)
            {
                RoadGen(form, Grid, loc, hexRef, -15, (hexSize / 4) + (hexSize / 2) - 90);
            }
            if (loc == 5)
            {
                RoadGen(form, Grid, loc, hexRef, 60, (hexSize / 4) - 45);
            }
        }

        private void HouseGen(Form1 form, Hexagon[] Grid, int loc, int hexRef, int x, int y)
        {
            PictureBox house = new PictureBox()
            {
                Name = "pictureBox",
                Size = new Size(townSize, townSize),
                Location = new Point(Grid[hexRef].LocX + x, Grid[hexRef].LocY + y),
                Image = Image.FromFile("Media\\house.jpg"),
                BackColor = Color.Transparent,
            };
            
            form.Controls.Add(house);
            house.BringToFront();
        }
        private void RoadGen(Form1 form, Hexagon[] Grid, int loc, int hexRef, int x, int y)
        {
            PictureBox road = new PictureBox()
            {
                Name = "pictureBox",
                Size = new Size(roadSize, roadSize),
                Location = new Point(Grid[hexRef].LocX + x, Grid[hexRef].LocY + y),
                Image = Image.FromFile("Media\\house.jpg"),
                BackColor = Color.Transparent

            };
            form.Controls.Add(road);
            road.BringToFront();
        }
    }
}

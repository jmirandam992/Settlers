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

        private List<PictureBox> Background;
        private int hexSize;
        private int townSize = 84;
        private int roadWidth = 66;
        private int roadHeight = 68;
        private int roadWidth3 = 36;
        private int roadHeight3 = 62;
        private int shift = 5;
        private List<PictureBox> pieces = new List<PictureBox>();

        public void Town(Form1 form, Hexagon[] Grid, List<PictureBox> Background, int hexRef, int loc)
        {
            this.Background = Background;
            if (loc == 0)
            {
                HouseGen(form, Grid, loc, hexRef, ((hexSize / 2) - (townSize / 2)), -(townSize / 2));
            }
            if (loc == 1)
            {
                HouseGen(form, Grid, loc, hexRef, (hexSize - (townSize / 2)), (hexSize / 4) - (townSize / 2) + shift);
            }
            if (loc == 2)
            {
                HouseGen(form, Grid, loc, hexRef, (hexSize - (townSize / 2)), (hexSize / 4) + (hexSize / 2) - (townSize / 2));
            }
            if (loc == 3)
            {
                HouseGen(form, Grid, loc, hexRef, ((hexSize / 2) - (townSize / 2)), (hexSize - (townSize / 2)) + shift);
            }
            if (loc == 4)
            {
                HouseGen(form, Grid, loc, hexRef, -(townSize / 2), (hexSize / 4) + (hexSize / 2) - (townSize / 2));
            }
            if (loc == 5)
            {
                HouseGen(form, Grid, loc, hexRef, -(townSize / 2), (hexSize / 4) - (townSize / 2) + shift);
            }
        }

        public void Road(Form1 form, Hexagon[] Grid, List<PictureBox> Background, int hexRef, int loc)
        {
            this.Background = Background;
            if (loc == 0)
            {
                RoadGen(form, Grid, loc, hexRef, ((hexSize / 2) + (hexSize / 7)), (hexSize / 60));
            }
            if (loc == 1)
            {
                RoadGen(form, Grid, loc, hexRef, (hexSize - (roadWidth3 / 2)), (hexSize / 2) - (roadHeight / 2) + shift);
            }
            if (loc == 2)
            {
                RoadGen(form, Grid, loc, hexRef, ((hexSize / 2) + (hexSize / 7)), (hexSize / 60) + (hexSize / 2) + (hexSize / 4));
            }
            if (loc == 3)
            {
                RoadGen(form, Grid, loc, hexRef, ((hexSize / 7)), (hexSize / 60) + (hexSize / 2) + (hexSize / 4));
            }
            if (loc == 4)
            {
                RoadGen(form, Grid, loc, hexRef, -roadWidth3 / 2, (hexSize / 2) - (roadHeight / 2) + shift);
            }
            if (loc == 5)
            {
                RoadGen(form, Grid, loc, hexRef, (hexSize / 7), (hexSize / 60));
            }
        }

        private void HouseGen(Form1 form, Hexagon[] Grid, int loc, int hexRef, int x, int y)
        {
            Image img;
            if (loc == 0 || loc == 2 || loc == 4)
            {
                img = Image.FromFile("Media\\town1.png");
            }
            else
            {
                img = Image.FromFile("Media\\town2.png");
            }
            PictureBox house = new PictureBox()
            {
                Name = "pictureBox",
                Size = new Size(townSize, townSize),
                Location = new Point(Background[hexRef].Location.X + x, Background[hexRef].Location.Y + y),
                Image = img,
                BackColor = Color.Transparent,
            };
            this.pieces.Add(house);
            form.Controls.Add(house);
            house.BringToFront();
        }
        private void RoadGen(Form1 form, Hexagon[] Grid, int loc, int hexRef, int x, int y)
        {
            Image img;
            int roadW;
            int roadH;
            if (loc == 0 || loc == 3)
            {
                img = Image.FromFile("Media\\road1.png");
                roadW = roadWidth;
                roadH = roadHeight;
            }
            else if (loc == 2 || loc == 5)
            {
                img = Image.FromFile("Media\\road2.png");
                roadW = roadWidth;
                roadH = roadHeight;
            }
            else
            {
                img = Image.FromFile("Media\\road3.png");
                roadW = roadWidth3;
                roadH = roadHeight3;
            }
            PictureBox road = new PictureBox()
            {
                Name = "pictureBox",
                Size = new Size(roadW, roadH),
                Location = new Point(Background[hexRef].Location.X + x, Background[hexRef].Location.Y + y),
                Image = img,
                BackColor = Color.Transparent

            };
            this.pieces.Add(road);
            form.Controls.Add(road);
            road.BringToFront();
        }

        public void toFront()
        {
            for (int i = 0; i < pieces.Count; i++)
            {
                pieces[i].BringToFront();
            }
        }
    }
}

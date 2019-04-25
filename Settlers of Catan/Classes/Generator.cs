namespace SOCForm.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    class Generation
    {
        public int hexSize;
        public void Standard(Form form, List<PictureBox> background, Hexagon[] Grid)
        {
            // This loop places pictureboxes on the gameboard.
            for (int i = 0; i < Grid.Length; i++)
            {
                Hexagon grid = Grid[i];
                var picture = new PictureBox
                {
                    Name = "pictureBox",
                    Size = new Size(hexSize, hexSize),
                    Location = new Point(grid.LocX, grid.LocY),
                    Image = Image.FromFile(Grid[i].Path[Grid[i].Type]),
                    BackColor = Color.Transparent,
                };
                background.Add(picture);
            }
            // This loop fixes transparancy issues for the most part.
            for (int i = 0; i < Grid.Length; i++)
            {
                Hexagon thisHex = Grid[i];
                if (thisHex.Layer > 0)
                {
                    int reference = i - thisHex.FirstTouchingCnt;
                    Hexagon referenceHex = Grid[reference];
                    PictureBox thisPic = background[i];
                    PictureBox referencePic = background[reference];

                    // Find out which pictureboxes need to be changed.
                    if (thisHex.Touching == "both")
                    {
                        //If current hex is touching on both, two pic boxes need to be changed.
                        PictureBox leftPic = new PictureBox()
                        {
                            Name = "pictureBox",
                            Size = new Size(hexSize, hexSize),
                            Location = new Point((hexSize / 2), (hexSize - (hexSize / 4))),
                            Image = thisPic.Image,
                            BackColor = Color.Transparent,
                        };
                        PictureBox rightPic = new PictureBox()
                        {
                            Name = "pictureBox",
                            Size = new Size(hexSize, hexSize),
                            Location = new Point(-(hexSize / 2), (hexSize - (hexSize / 4))),
                            Image = thisPic.Image,
                            BackColor = Color.Transparent,
                        };
                        PictureBox preRefPic = background[reference - 1];
                        form.Controls.Add(preRefPic);
                        form.Controls.Add(referencePic);
                        form.Controls.Add(thisPic);
                        preRefPic.Controls.Add(leftPic);
                        referencePic.Controls.Add(rightPic);
                    }
                    if (thisHex.Touching == "left")
                    {
                        // Just change the left one.
                        PictureBox leftPic = new PictureBox()
                        {
                            Name = "pictureBox",
                            Size = new Size(hexSize, hexSize),
                            Location = new Point((hexSize / 2), (hexSize - (hexSize / 4))),
                            Image = thisPic.Image,
                            BackColor = Color.Transparent,
                        };
                        form.Controls.Add(referencePic);
                        form.Controls.Add(thisPic);
                        referencePic.Controls.Add(leftPic);
                    }
                    if (thisHex.Touching == "right")
                    {
                        // Just change the right one.
                        PictureBox rightPic = new PictureBox()
                        {
                            Name = "pictureBox",
                            Size = new Size(hexSize, hexSize),
                            Location = new Point(-(hexSize / 2), (hexSize - (hexSize / 4))),
                            Image = thisPic.Image,
                            BackColor = Color.Transparent,
                        };
                        form.Controls.Add(referencePic);
                        form.Controls.Add(thisPic);
                        referencePic.Controls.Add(rightPic);
                    }
                }

                // Troubleshooting with transparancy...
                // It's a headache!
                PictureBox left = new PictureBox()
                {
                    Name = "pictureBox",
                    Size = new Size(hexSize, hexSize),
                    Location = new Point((hexSize / 2), (hexSize - (hexSize / 4))),
                    Image = background[6].Image,
                    BackColor = Color.Transparent,
                };
                background[2].Controls.Add(left);
                PictureBox right = new PictureBox()
                {
                    Name = "pictureBox",
                    Size = new Size(hexSize, hexSize),
                    Location = new Point(+(hexSize / 2), (-(hexSize / 2) - (hexSize / 4))),
                    Image = background[13].Image,
                    BackColor = Color.Transparent,
                };
                background[16].Controls.Add(right);
                PictureBox right2 = new PictureBox()
                {
                    Name = "pictureBox",
                    Size = new Size(hexSize, hexSize),
                    Location = new Point(+(hexSize / 2), (-(hexSize / 2) - (hexSize / 4))),
                    Image = background[14].Image,
                    BackColor = Color.Transparent,
                };
                background[17].Controls.Add(right2);
            }
        }
    }
}

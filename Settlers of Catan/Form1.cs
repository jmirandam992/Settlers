using SOCForm.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOCForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picGrid_Click(object sender, EventArgs e)
        {

        }

        // Checks if the hexagons have been generated.
        private world map = new world();

        // Checks if the hexagons have been generated.
        private bool generated = false;

        // Sets hexagon height.
        private const float HexHeight = 50;

        // Selected hexagons.
        private List<PointF> Hexagons = new List<PointF>();

        // Array that holds game board colors.
        private Brush[] brush = { Brushes.Blue, Brushes.Green, Brushes.DarkGreen, Brushes.YellowGreen, Brushes.Yellow, Brushes.Orange, Brushes.White, Brushes.Yellow };

        // The current color ID being used.
        private int color = 1;

        // List of all points already used for x.
        private List<float> usedX = new List<float>();

        // List of all points already used for y.
        private List<float> usedY = new List<float>();

        // Random number generator.
        Random rdm = new Random();

        private Hexagon[,] tiles;

        // Redraw the grid.
        private void picGrid_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            // Colors the selected hexagons.
            foreach (PointF point in Hexagons)
            {
                color = tiles[(int)Math.Round(point.X), (int)Math.Round(point.Y)].type;
                e.Graphics.FillPolygon(brush[color],
                    HexToPoints(HexHeight, point.X, point.Y));
                usedX.Add(point.X);
                usedY.Add(point.Y);
            }

            // Colors 50x50 hexagons.
                for (float y = 0; y <= picGrid.ClientSize.Height; y++)
                {
                    for (float x = 0; x <= picGrid.ClientSize.Width; x++)
                    {
                        if (x < 50 && y < 50)
                        {
                            // Bool true when hex hasn't been colored.
                            bool okay = true;

                            // Checks arrays for x and ys that have specified color.
                            for (int i = 0; i < usedX.Count; i++)
                            {
                                if (x == usedX[i])
                                {
                                    if (y == usedY[i])
                                    {
                                        okay = false;
                                    }
                                }
                            }

                            // As long as okay == true, hex can be colored.
                            if (okay)
                            {
                            e.Graphics.FillPolygon(Brushes.Blue,
                                HexToPoints(HexHeight, x, y));
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }

            // Draw the grid.
            DrawHexGrid(e.Graphics, Pens.Black,
                0, picGrid.ClientSize.Width,
                0, picGrid.ClientSize.Height,
                HexHeight);
        }

        // Draw a hexagonal grid for the indicated area.
        // (You might be able to draw the hexagons without
        // drawing any duplicate edges, but this is a lot easier.)
        private void DrawHexGrid(Graphics gr, Pen pen,
            float xmin, float xmax, float ymin, float ymax,
            float height)
        {
            // Loop until a hexagon won't fit.
            for (int row = 0; ; row++)
            {
                // Get the points for the row's first hexagon.
                PointF[] points = HexToPoints(height, row, 0);

                // If it doesn't fit, we're done.
                if (points[4].Y > ymax) break;

                // Draw the row.
                for (int col = 0; ; col++)
                {
                    // Get the points for the row's next hexagon.
                    points = HexToPoints(height, row, col);

                    // If it doesn't fit horizontally,
                    // we're done with this row.
                    if (points[3].X > xmax) break;

                    // If it fits vertically, draw it.
                    if (points[4].Y <= ymax)
                    {
                        gr.DrawPolygon(pen, points);
                    }
                }
            }
        }

        private void picGrid_Resize(object sender, EventArgs e)
        {
            picGrid.Refresh();
        }

        // Display the row and column under the mouse.
        private void picGrid_MouseMove(object sender, MouseEventArgs e)
        {
            int row, col;
            PointToHex(e.X, e.Y, HexHeight, out row, out col);
            this.Text = "(" + row + ", " + col + ")";
        }

        // Add the clicked hexagon to the Hexagons list.
        private void picGrid_MouseClick(object sender, MouseEventArgs e)
        {
            int row, col;
            PointToHex(e.X, e.Y, HexHeight, out row, out col);
            Hexagons.Add(new PointF(row, col));
            picGrid.Refresh();
        }

        // Return the width of a hexagon.
        private float HexWidth(float height)
        {
            return (float)(4 * (height / 2 / Math.Sqrt(3)));
        }

        // Return the row and column of the hexagon at this point.
        private void PointToHex(float x, float y, float height,
            out int row, out int col)
        {
            // Find the test rectangle containing the point.
            float width = HexWidth(height);
            col = (int)(x / (width * 0.75f));

            if (col % 2 == 0)
                row = (int)(y / height);
            else
                row = (int)((y - height / 2) / height);

            // Find the test area.
            float testx = col * width * 0.75f;
            float testy = row * height;
            if (col % 2 == 1) testy += height / 2;

            // See if the point is above or
            // below the test hexagon on the left.
            bool is_above = false, is_below = false;
            float dx = x - testx;
            if (dx < width / 4)
            {
                float dy = y - (testy + height / 2);
                if (dx < 0.001)
                {
                    // The point is on the left edge of the test rectangle.
                    if (dy < 0) is_above = true;
                    if (dy > 0) is_below = true;
                }
                else if (dy < 0)
                {
                    // See if the point is above the test hexagon.
                    if (-dy / dx > Math.Sqrt(3)) is_above = true;
                }
                else
                {
                    // See if the point is below the test hexagon.
                    if (dy / dx > Math.Sqrt(3)) is_below = true;
                }
            }

            // Adjust the row and column if necessary.
            if (is_above)
            {
                if (col % 2 == 0) row--;
                col--;
            }
            else if (is_below)
            {
                if (col % 2 == 1) row++;
                col--;
            }
        }

        // Return the points that define the indicated hexagon.
        private PointF[] HexToPoints(float height, float row, float col)
        {
            // Start with the leftmost corner of the upper left hexagon.
            float width = HexWidth(height);
            float y = height / 2;
            float x = 0;

            // Move down the required number of rows.
            y += row * height;

            // If the column is odd, move down half a hex more.
            if (col % 2 == 1) y += height / 2;

            // Move over for the column number.
            x += col * (width * 0.75f);

            // Generate the points.
            return new PointF[]
                {
                    new PointF(x, y),
                    new PointF(x + width * 0.25f, y - height / 2),
                    new PointF(x + width * 0.75f, y - height / 2),
                    new PointF(x + width, y),
                    new PointF(x + width * 0.75f, y + height / 2),
                    new PointF(x + width * 0.25f, y + height / 2),
                };
        }

        public void Generate()
        {
            tiles = this.map.ranMap.Generate();
            for (int y = 0; y < tiles.GetLength(0); y++)
            {
                for (int x = 0; x < tiles.GetLength(1); x++)
                {
                    int row, col;
                    PointToHex(x, y, HexHeight, out row, out col);
                    Hexagons.Add(new PointF(x, y));
                    picGrid.Refresh();
                }
            }
        }

        private void btnRdm_Click(object sender, EventArgs e)
        {
            Generate();
        }
    }
}

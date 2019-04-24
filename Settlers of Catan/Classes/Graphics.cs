using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOCForm.Classes
{
    class Graphics
    {
        private static void BlendPictures(Bitmap one, Bitmap two, int deltaX, int deltaY)
        {
            for (int y = 0; y < one.Height; y++)
            {
                for (int x = 0; x < one.Width; x++)
                {
                    if (one.GetPixel(x, y).A < 255)
                    {
                        Color newColor = one.GetPixel(x + deltaX, y + deltaY);
                        two.SetPixel(x, y, newColor);
                    }
                }
            }
        }
        public static void BlendPictures(PictureBox back, PictureBox front)
        {
            int leftDifference = Math.Abs(back.Left - front.Left);
            int topDifference = Math.Abs(back.Top - front.Top);

            BlendPictures((Bitmap)back.Image, (Bitmap)front.Image, leftDifference, topDifference);
        }
    }
}

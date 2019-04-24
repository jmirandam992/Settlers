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
        public void Standard(List<PictureBox> background, Hexagon[] grid)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                Hexagon thisHex = grid[i];
                if (thisHex.Layer > 0)
                {
                    int reference = i - thisHex.FirstTouchingCnt;
                    Hexagon referenceHex = grid[reference];
                    PictureBox thisPic = background[i];
                    PictureBox referencePic = background[reference];
                    if (thisHex.Touching == "both")
                    {
                        PictureBox preRefPic = background[reference - 1];
                        preRefPic.Controls.Add(thisPic);
                        referencePic.Controls.Add(thisPic);
                    }
                    if (thisHex.Touching == "left")
                    {
                        referencePic.Controls.Add(thisPic);
                    }
                    if (thisHex.Touching == "right")
                    {
                        referencePic.Controls.Add(thisPic);
                    }
                }
            }
        }
    }
}

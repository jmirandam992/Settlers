using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOCForm.Classes
{
    public class Hexagon
    {
        public string[] Path = {"Media\\field.png", "Media\\forest.png", "Media\\field.png", "Media\\forest.png", "Media\\forest.png", "Media\\desert.png", };
        public int Type;
        public int LocX;
        public int LocY;
        public int Width;
        public int Height;
        public int Layer;
        public string Touching;
        public int FirstTouchingCnt;
    }
}

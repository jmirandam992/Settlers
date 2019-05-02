using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOCForm.Classes
{
    public class ButtonInfo
    {
        public ButtonInfo(Form1 form, Hexagon[] grid, PiecePlacement Place, bool IsRoad, int index, int hexloc, int location)
        {
            this.Index = index;
            this.Form = form;
            this.Grid = grid;
            this.place = Place;
            this.isRoad = IsRoad;
            this.Hexscape = hexloc;
            this.Location = location;
        }

        public int Index;
        public Form1 Form;
        public int Location;
        public int Hexscape;
        public bool isRoad;
        public Hexagon[] Grid;
        private PiecePlacement place;

        public void click()
        {
            if (isRoad)
            {
                place.Road(Form, Grid, Hexscape, Location);
            }
            else
            {
                place.Town(Form, Grid, Hexscape, Location);
            }

            //MessageBox.Show(Grid[Hexscape].LocX.ToString() + " " + Grid[Hexscape].LocY.ToString());
            //MessageBox.Show(Index.ToString() + " " + Location.ToString() + " " + Hexscape.ToString() + " " + isRoad.ToString());
        }
    }
}

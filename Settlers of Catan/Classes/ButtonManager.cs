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
        private int townSize = 84;
        private int roadWidth = 66;
        private int roadHeight = 68;
        private int roadWidth3 = 36;
        private int roadHeight3 = 62;
        private int shift = 9;
        int townCnt = 0;
        int roadCnt = 0;
        public List<ButtonInfo> Buttons = new List<ButtonInfo>(); 
        private PiecePlacement place;
        private Color btnColor = Color.Red;

        public void genAllBtn(Form1 form, Hexagon[] Grid, PiecePlacement Place)
        {
            place = Place;
            for (int i = 0; i < Grid.Length; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (i > 2)
                    {
                        if (j != 0 || j != 1 || j != 5)
                        {
                            this.TownBtnLcn(form, Grid, i, j);
                        }
                    }
                    else
                    {
                        this.TownBtnLcn(form, Grid, i, j);
                    }
                }
                for (int j = 0; j < 6; j++)
                {
                    if (i > 2)
                    {
                        if (j != 0 || j != 1 || j != 5)
                        {
                            this.RoadBtnLcn(form, Grid, i, j);
                        }
                    }
                    else
                    {
                        this.RoadBtnLcn(form, Grid, i, j);
                    }
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
        public void RoadBtnLcn(Form1 form, Hexagon[] Grid, int hexRef, int loc)
        {
            if (loc == 0)
            {
                RoadGen(form, Grid, loc, hexRef, ((hexSize / 2) + (hexSize / 4) - (btnSize / 2)), btnSize - shift);
            }
            if (loc == 1)
            {
                RoadGen(form, Grid, loc, hexRef, (hexSize - btnHalf), (hexSize / 2) - btnHalf);
            }
            if (loc == 2)
            {
                RoadGen(form, Grid, loc, hexRef, ((hexSize / 2) + (hexSize / 4) - (btnSize / 2)), (hexSize / 2) + (hexSize / 3) - (btnHalf / 3));
            }
            if (loc == 3)
            {
                RoadGen(form, Grid, loc, hexRef, (hexSize / 4) - (btnSize / 2), (hexSize / 2) + (hexSize / 3) - (btnHalf / 3));
            }
            if (loc == 4)
            {
                RoadGen(form, Grid, loc, hexRef, -btnHalf, (hexSize / 2) - btnHalf);
            }
            if (loc == 5)
            {
                RoadGen(form, Grid, loc, hexRef, (hexSize / 4) - (btnSize / 2), btnSize - shift);
            }
        }
        private void HouseGen(Form1 form, Hexagon[] Grid, int loc, int hexRef, int x, int y)
        {
            ButtonInfo thisBtn = new ButtonInfo(form, Grid, place, false, roadCnt, hexRef, loc);
            Buttons.Add(thisBtn);

            Point newLoc = new Point(Grid[hexRef].LocX + x, Grid[hexRef].LocY + y); // Set whatever you want for initial location
            Button b = new Button();
            b.Height = btnSize;
            b.Width = btnSize;
            b.Location = newLoc;
            b.BackColor = btnColor;
            b.Tag = townCnt + roadCnt;
            b.Name = "houseBtn" + townCnt.ToString();
            newLoc.Offset(0, b.Height + 5);
            b.Click += new EventHandler(this.btnHandeler);
            form.Controls.Add(b);
            townCnt++;
            b.BringToFront();
        }
        private void RoadGen(Form1 form, Hexagon[] Grid, int loc, int hexRef, int x, int y)
        {
            ButtonInfo thisBtn = new ButtonInfo(form, Grid, place, true, roadCnt, hexRef, loc);
            Buttons.Add(thisBtn);

            Point newLoc = new Point(Grid[hexRef].LocX + x, Grid[hexRef].LocY + y);
            Button b = new Button();
            b.Size = new Size(btnSize, btnSize);
            b.Location = newLoc;
            b.BackColor = btnColor;
            b.Tag = townCnt + roadCnt;
            b.Name = "roadBtn, " + roadCnt.ToString();
            newLoc.Offset(0, b.Height + 5);
            b.Click += new EventHandler(this.btnHandeler);
            form.Controls.Add(b);
            roadCnt++;
            b.BringToFront();
            
        }

        private void btnHandeler(object sender, EventArgs e)
        {
            Button thisBtn = (Button)sender;
            Buttons[(int)thisBtn.Tag].click();
        }

        private void myButton_Click(object sender, EventArgs e)
        {
            string ButtonName;

            ButtonName = ((Button)sender).Name;

            //Perform required logic here
            MessageBox.Show("Test");
        }
    }
}

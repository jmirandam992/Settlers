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
        public int clicks = 0;
        private List<PictureBox> Background;
        public List<ButtonInfo> Buttons = new List<ButtonInfo>();
        public List<Button> townBtns = new List<Button>();
        public List<Button> roadBtns = new List<Button>();
        public List<int> disabledBtns = new List<int>();
        private PiecePlacement place;
        private Color btnColor = Color.Red;
        public List<int> pressedTowns = new List<int>();
        public List<int> pressedRoads = new List<int>();

        public void genAllBtn(Form1 form, Hexagon[] Grid, List<PictureBox> Background, PiecePlacement Place)
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
                            this.TownBtnLcn(form, Grid, Background, i, j);
                        }
                    }
                    else
                    {
                        this.TownBtnLcn(form, Grid, Background, i, j);
                    }
                }
                for (int j = 0; j < 6; j++)
                {
                    if (i > 2)
                    {
                        if (j != 0 || j != 1 || j != 5)
                        {
                            this.RoadBtnLcn(form, Grid, Background, i, j);
                        }
                    }
                    else
                    {
                        this.RoadBtnLcn(form, Grid, Background, i, j);
                    }
                }
            }
            for (int i = 0; i < roadCnt; i++)
            {
                roadBtns[i].SendToBack();
                roadBtns[i].Enabled = false;
            }
        }
        public void TownBtnLcn(Form1 form, Hexagon[] Grid, List<PictureBox> Background, int hexRef, int loc)
        {
            this.Background = Background;
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
        public void RoadBtnLcn(Form1 form, Hexagon[] Grid, List<PictureBox> Background, int hexRef, int loc)
        {
            this.Background = Background;
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
            ButtonInfo thisBtn = new ButtonInfo(form, Grid, Background, this, place, false, townCnt, hexRef, loc);
            Buttons.Add(thisBtn);

            Point newLoc = new Point(Background[hexRef].Location.X + x, Background[hexRef].Location.Y + y); 
            Button b = new Button();
            b.Height = btnSize;
            b.Width = btnSize;
            b.Location = newLoc;
            b.BackColor = btnColor;
            b.Tag = townCnt + roadCnt;
            b.Name = "houseBtn" + townCnt.ToString();
            newLoc.Offset(0, b.Height + 5);
            b.Click += new EventHandler(this.btnHandeler);
            townBtns.Add(b);
            form.Controls.Add(townBtns[townCnt]);
            townBtns[townCnt].BringToFront();
            townCnt++;
        }
        private void RoadGen(Form1 form, Hexagon[] Grid, int loc, int hexRef, int x, int y)
        {
            ButtonInfo thisBtn = new ButtonInfo(form, Grid, Background, this, place, true, roadCnt, hexRef, loc);
            Buttons.Add(thisBtn);

            Point newLoc = new Point(Background[hexRef].Location.X + x, Background[hexRef].Location.Y + y);
            Button b = new Button();
            b.Size = new Size(btnSize, btnSize);
            b.Location = newLoc;
            b.BackColor = btnColor;
            b.Tag = townCnt + roadCnt;
            b.Name = "roadBtn, " + roadCnt.ToString();
            b.Click += new EventHandler(this.btnHandeler);
            roadBtns.Add(b);
            form.Controls.Add(roadBtns[roadCnt]);
            roadBtns[roadCnt].BringToFront();
            roadCnt++;
            
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

        public void click()
        {
            clicks++;
            if (clicks == 2)
            {
                for (int i = 0; i < townBtns.Count; i++)
                {
                    townBtns[i].SendToBack();
                    townBtns[i].Enabled = false;
                }
                for (int i = 0; i < disabledBtns.Count; i++)
                {
                    roadBtns[disabledBtns[i]].BringToFront();
                    roadBtns[disabledBtns[i]].Enabled = true;
                }
            }
            place.toFront();

        }
    }
}

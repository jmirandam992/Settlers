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
using Graphics = SOCForm.Classes.Graphics;
using System.Data.SqlClient;
using System.Configuration;

namespace SOCForm
{
    public partial class Form1 : Form
    {
        Players play = new Players(4);
        PlayerTurns turns = new PlayerTurns();

        public Form1(int players, int ai, int difficulty)
        {

            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            Gameboard.HexSize = hexSize;
            Gameboard.StartHex = startingHex;
            Gen.hexSize = hexSize;
            btnManage.hexSize = hexSize;
            place = new PiecePlacement(hexSize);
            Generate();
            dieP1.BackgroundImage = Properties.Resources.one;
            dieP2.BackgroundImage = Properties.Resources.one;
            tradeButtonHider(currentPlayer);
            play.initializePlayerData();
            play.getTraderData(this, currentPlayer);


        }

        Dice dice = new Dice();


        private int currentPlayer = 1;
        private int tradingPlayer;

        // Checks if the hexagons have been generated.
        private bool generated = false;

        // Random number generator.
        Random rdm = new Random();

        // Stores information about the map tiles
        private Hexagon[,] tiles;

        // Store the height and width for the hexagons.
        private int hexSize = 300;

        // Store the starting location of the first land tile.
        private int startingHex = 300;

        // Store the info for the tile pieces.
        public Hexagon[] Grid = new Hexagon[19];

        // For generating teh picture boxes
        private List<PictureBox> background = new List<PictureBox>();

        // Stores the info for the last generated hexagon.
        private Hexagon lastHex;

        // Stores the maps that can be used.
        private Maps Gameboard = new Maps();

        // A class used to make png backgrounds transparent.
        private Generation Gen = new Generation();

        // A class for managing the buttons.
        private ButtonManager btnManage = new ButtonManager();

        //private PlayerTurns turn = new PlayerTurns(this, 1,  "AI");
        // A new instance of generation for pieces.
        private PiecePlacement place;
        private int rollValue;

        public void Generate()
        {

            // Fills all the information needed to generate a grid.
            Gameboard.Standard(Grid);

            // Generates a grid background.
            Gen.Standard(this, background, Grid);

            // Places pieces.
            /*
            for (int i = 0; i < Grid.Length; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    place.Town(this, Grid, i, j);
                    place.Road(this, Grid, i, j);
                }
            }
            */
            btnManage.genAllBtn(this, Grid, background, place);
        }

        //private void btnGenerate_Click_1(object sender, EventArgs e)
        //{
        //    Generate();
        //}


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void diceRollBtn_Click(object sender, EventArgs e)
        {
            rollValue = dice.RollDie(dieP1, dieP2);

        }


        private void playerDataPnlBtn_Click(object sender, EventArgs e)
        {
            if (playerData.Visible != true)
            {
                playerData.Show();
            }
            else
            {
                playerData.Hide();
            }
        }



        private void fillCardData(int PlayerID, Form1 game)
        {


        }

        private void tradeButtonHider(int currentPlayer)
        {
            switch (currentPlayer)
            {
                case 1:
                    player2Select.Enabled = true;
                    player3Select.Enabled = true;
                    player4Select.Enabled = true;
                    player1Select.Enabled = false;
                    break;
                case 2:
                    player1Select.Enabled = true;
                    player2Select.Enabled = false;
                    player3Select.Enabled = true;
                    player4Select.Enabled = true;
                    break;
                case 3:
                    player1Select.Enabled = true;
                    player2Select.Enabled = true;
                    player3Select.Enabled = false;
                    player4Select.Enabled = true;
                    break;
                case 4:
                    player1Select.Enabled = true;
                    player2Select.Enabled = true;
                    player3Select.Enabled = true;
                    player4Select.Enabled = false;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            fillCardData(1, this);
        }

        private void player1Select_Click(object sender, EventArgs e)
        {
            play.getPlayerTradeeData(this, 1);
            tradingPanel.Show();
            tradingPlayer = 1;
        }

        private void player2Select_Click(object sender, EventArgs e)
        {
            play.getPlayerTradeeData(this, 2);
            tradingPanel.Show();
            tradingPlayer = 2;
        }

        private void player3Select_Click(object sender, EventArgs e)
        {
            play.getPlayerTradeeData(this, 3);
            tradingPanel.Show();
            tradingPlayer = 3;
        }

        private void player4Select_Click(object sender, EventArgs e)
        {
            play.getPlayerTradeeData(this, 4);
            tradingPanel.Show();
            tradingPlayer = 4;

        }

        private void endTurnBtn_Click(object sender, EventArgs e)
        {
            tradingPanel.Hide();
            if (currentPlayer < 4)
            {
                currentPlayer++;
            }
            else
            {
                currentPlayer = 1;
            }

            tradeButtonHider(currentPlayer);
            play.getTraderData(this, currentPlayer);
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            int tl1, tb1, tw1, to1, tg1;
            int tdl1, tdb1, tdw1, tdo1, tdg1;
            int tl2, tb2, tw2, to2, tg2, tdl2, tdb2, tdw2, tdo2, tdg2;

            if (int.TryParse(tradeeLumberVlu.Text, out tl1) && int.TryParse(tradeeLumberQty.Text, out tl2) && tl2 > tl1)
            {
               
                if (int.TryParse(tradeeBrkVlu.Text, out tb1) && int.TryParse(tradeeBrickQty.Text, out tb2) && tb2 > tb1)
                {
                   if (int.TryParse(tradeeWlVlu.Text, out tw1) && int.TryParse(tradeeWoolQty.Text, out tw2) && tw2 > tw1)
                    {
                        if (int.TryParse(tradeeOreVlu.Text, out to1) && int.TryParse(tradeeOreQty.Text, out to2) && to2 > to1)
                        {
                            if (int.TryParse(tradeeGrnVlu.Text, out tg1) && int.TryParse(tradeeGrainQty.Text, out tg2) && tg2 > tg1)
                            {
                                //data for stuff being traded from current player
                                if (int.TryParse(traderLumbOffer.Text, out tdl1) && int.TryParse(traderLumQty.Text, out tdl2) && tdl2 > tdl1)
                                {
                                    if (int.TryParse(traderBrickOffer.Text, out tdb1) && int.TryParse(traderBrickQty.Text, out tdb2) && tdb2 > tdb1)
                                    {
                                        if (int.TryParse(traderWoolOffer.Text, out tdw1) && int.TryParse(traderWoolQty.Text, out tdw2) && tdw2 > tdw1)
                                        {
                                           if (int.TryParse(traderOreOffer.Text, out tdo1) && int.TryParse(traderOreQty.Text, out tdo2) && tdo2 > tdo1)
                                            {
                                                if (int.TryParse(traderGrainOffer.Text, out tdg1) && int.TryParse(traderGrainQty.Text, out tdg2) && tdg2 > tdg1)
                                                {
                                                   
                                                    /*
                                                         int tl1, tb1, tw1, to1, tg1;
                                                         int tdl1, tdb1, tdw1, tdo1, tdg1;
                                                         int tl2, tb2, tw2, to2, tg2, tdl2, tdb2, tdw2, tdo2, tdg2;
                                                     */
                                                    //trader lumber total
                                                    int tdl1f = tdl2 - tdl1 + tl1;
                                                    //tradee lumber total
                                                    int tlf2 = tl2 - tl1 + tdl1;
                                                    //trader brick total
                                                    int tdb1f = tdb2 - tdb1 + tb1;
                                                    //tradee brick total
                                                    int tlbf = tb2 - tb1 + tdb1;
                                                    //trader wool total
                                                    int tdwf = tdw2 - tdw1 + tw1;
                                                    //tradee wool totals
                                                    int tlwf = tw2 - tw1 + tdw1;
                                                    //trader ore totals
                                                    int tdof = tdo2 - tdo1 + tw1;
                                                    //tradee ore totals
                                                    int tlof = tw2 - tw1 + tdo1;
                                                    //trader grain totals
                                                    int tdgf = tdg2 - tdg1 + tg1;
                                                    //tradee grain totals
                                                    int tlgf = tg2 - tg1 + tdg1;
                                                     

                                                    tl1 = tl2 - tl1 + tdl1;
                                                    turns.acceptTrade(tlf2, tlbf, tlwf, tlof, tlgf, tdl1f, tdb1f, tdwf, tdof,
                                                        tdgf, currentPlayer, tradingPlayer);
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter only numbers");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please enter only numbers");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please enter only numbers");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please enter only numbers");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please enter only numbers");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter only numbers");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter only numbers");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter only numbers");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter only numbers");


                }

            }
            else
            {
                MessageBox.Show("Please enter only numbers");

            }
        }
    }
}


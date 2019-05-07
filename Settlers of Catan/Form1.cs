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
            Players play = new Players(4);
            
        }

        Dice dice = new Dice();

        
        private int currentPlayer = 1;
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

        private void button3_Click(object sender, EventArgs e)
        {
            
            fillCardData(1, this);
        }
    }
}


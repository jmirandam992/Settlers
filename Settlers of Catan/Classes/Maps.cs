using System.Security.Cryptography.X509Certificates;

namespace SOCForm.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Maps
    {
        // Size of Hexes.
        public int HexSize;

        // Half of Hex Size.
        private int halfHex;

        // 3/4 hex size.
        private int threeQuarHex;

        // Starting hex for land tiles.
        public int StartHex;

        // Current hex program is on.
        Hexagon thisHex;

        // The last generated hex.
        private Hexagon lastHex;

        // Random Number Generator.
        Random rdm = new Random();

        // Counts for Tiletype.
        /*
         * 0 = Fields
         * 1 = Forest
         * 2 = Pasture
         * 3 = Mountains
         * 4 = Hills
         * 5 = Desert
         */
        private Tile[] tiles;
         
        // Generates the standard map.
        public void Standard(Hexagon[] Grid)
        {
            // Set vale for a half hex.
            halfHex = HexSize / 2;

            // Set values for three quarter hex.
            threeQuarHex = halfHex + (halfHex / 2);

            // Fill the array of tiles.
            tiles = new Tile[6];

            // Set the max tiles for the tiles array.
            int[] max = {4, 4, 4, 3, 3, 1};

            // Set the max tiles for the tiles array.
            for (int i = 0; i < tiles.Length; i++)
            {
                tiles[i] = new Tile();
                tiles[i].Maxtiles = max[i];
            }

            // Set properties for hex on first y.
            Grid[0] = new Hexagon();
            thisHex = Grid[0];
            thisHex.LocX = StartHex;
            thisHex.LocY = StartHex;
            thisHex.Layer = 0;
            FillReferenceHex(Grid);

            // Loop fills the y.
            for (int i = 1; i < 3; i++)
            {
                Grid[i] = new Hexagon();
                Grid[i].Layer = 0;
                FillHex(i, Grid);
            }

            // Set properties for hex on second y.
            Grid[3] = new Hexagon();
            thisHex = Grid[3];
            thisHex.LocX = StartHex - halfHex;
            thisHex.LocY = StartHex + threeQuarHex;
            thisHex.Layer = 1;
            thisHex.Touching = "right";
            thisHex.FirstTouchingCnt = 3;
            FillReferenceHex(Grid);

            // Loop fills the y.
            for (int i = 4; i < 7; i++)
            {
                Grid[i] = new Hexagon();
                Grid[i].Layer = 1;
                if (i < 6)
                {
                    Grid[i].Touching = "both";
                    Grid[i].FirstTouchingCnt = 3;
                }
                else
                {
                    Grid[i].Touching = "left";
                    Grid[i].FirstTouchingCnt = 4;
                }
                Grid[i].Touching = "both";
                FillHex(i, Grid);
            }

            // Set properties for hex on second y.
            Grid[7] = new Hexagon();
            thisHex = Grid[7];
            thisHex.LocX = StartHex - halfHex - halfHex;
            thisHex.LocY = StartHex + threeQuarHex + threeQuarHex;
            thisHex.Layer = 2;
            thisHex.Touching = "right";
            thisHex.FirstTouchingCnt = 4;
            FillReferenceHex(Grid);

            // Loop fills the y.
            for (int i = 8; i < 12; i++)
            {
                Grid[i] = new Hexagon();
                Grid[i].Layer = 2;
                if (i < 11)
                {
                    Grid[i].Touching = "both";
                    Grid[i].FirstTouchingCnt = 4;
                }
                else
                {
                    Grid[i].Touching = "left";
                    Grid[i].FirstTouchingCnt = 5;
                }
                FillHex(i, Grid);
            }

            // Set properties for hex on second y.
            Grid[12] = new Hexagon();
            thisHex = Grid[12];
            thisHex.LocX = StartHex - halfHex;
            thisHex.LocY = StartHex + threeQuarHex + threeQuarHex + threeQuarHex;
            thisHex.Layer = 3;
            thisHex.Touching = "both";
            thisHex.FirstTouchingCnt = 4;
            FillReferenceHex(Grid);

            // Loop fills the y.
            for (int i = 13; i < 16; i++)
            {
                Grid[i] = new Hexagon();
                Grid[i].Layer = 3;
                Grid[i].Touching = "both";
                Grid[i].FirstTouchingCnt = 4;
                FillHex(i, Grid);
            }

            // Set properties for hex on second y.
            Grid[16] = new Hexagon();
            thisHex = Grid[16];
            thisHex.LocX = StartHex;
            thisHex.LocY = StartHex + threeQuarHex + threeQuarHex + threeQuarHex + threeQuarHex;
            thisHex.Layer = 4;
            thisHex.Touching = "both";
            thisHex.FirstTouchingCnt = 3;
            FillReferenceHex(Grid);

            // Loop fills the y.
            for (int i = 17; i < 19; i++)
            {
                Grid[i] = new Hexagon();
                Grid[i].Layer = 4;
                Grid[i].Touching = "both";
                Grid[i].FirstTouchingCnt = 3;
                FillHex(i, Grid);
            }
        }

        public void FillReferenceHex(Hexagon[] Grid)
        {
            thisHex.Height = HexSize;
            thisHex.Width = HexSize;
            rdmNext();
            lastHex = thisHex;
        }

        private void FillHex(int i, Hexagon[] Grid)
        {
            thisHex = Grid[i];
            thisHex.Height = HexSize;
            thisHex.Width = HexSize;
            thisHex.LocX = lastHex.LocX + HexSize;
            thisHex.LocY = lastHex.LocY;
            rdmNext();
            lastHex = thisHex;
        }

        private void rdmNext()
        {
            thisHex.Type = -1;
            
            while (thisHex.Type == -1)
            {
                int nextRan = rdm.Next(0, 6);
                if (tiles[nextRan].Maxtiles > tiles[nextRan].Count)
                {
                    thisHex.Type = nextRan;
                    tiles[nextRan].Count++;
                }
            }
        }
    }
}

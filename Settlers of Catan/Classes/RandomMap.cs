using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOCForm.Classes
{
    public class RandomMap
    {
        public RandomMap()
        {
            for (int y = 0; y < tiles.GetLength(0); y++)
            {
                for (int x = 0; x < tiles.GetLength(1); x++)
                {
                    tiles[x,y] = new Hexagon();
                }
            }
        }

        // Changing these ints will influence the size of the random map.
        private Hexagon[,] tiles = new Hexagon[12, 12];

        // Random number generator. 
        Random rdm = new Random();

        // This var is used when a tile ahsn't been generated yet.
        private bool needsTileType;

        // Percentage of next tile being same if it has one match.
        private int oneMatchingPercentage = 15;

        // Percentage of next tile being same if it has two matches.
        private int twoMatchingPercentage = 35;

        // Percentage of next tile being same if it has three matches.
        private int threeMatchingPercentage = 85;

        // Checks how many neighbors are of one tile type.
        private void CheckLast(int lastTile, Hexagon one, Hexagon two, int x, int y, int matchOne, int matchTwo, int matchThree)
        {
            if (one.type == lastTile)
            {
                if (two.type == lastTile)
                {
                    RandomOutcome(matchThree, lastTile, x, y);
                }
            }
            else
            {
                if (two.type == lastTile)
                {
                    RandomOutcome(matchTwo, lastTile, x, y);
                }
                else
                {
                    RandomOutcome(matchOne, lastTile, x, y);
                }
            }
        }

        // This method works with the random number generator.
        // to determine what kind of tile will be generated. 
        private void RandomOutcome(int chance, int lastTile, int x, int y)
        {
            if (rdm.Next(1, 101) < chance)
            {
                tiles[x, y].type = lastTile;
            }
            else
            {
                randomTile(x, y);
            }
            needsTileType = false;
        }

        // This method generates a completely random tile.
        private void randomTile(int x, int y)
        {
            if (rdm.Next(0, 4) == 1)
            {
                tiles[x, y].type = 0;
            }
            else
            {
                tiles[x, y].type = rdm.Next(0, 8);
            }
        }

        public Hexagon[,] Generate()
        {
            // Go through the 'tiles' array.
            for (int y = 0; y < tiles.GetLength(0); y++)
            {
                for (int x = 0; x < tiles.GetLength(1); x++)
                {
                    if (!(y == 0 || x == 0))
                    {
                        // Determins positions of neighboring tiles. 
                        Hexagon tileDiag = tiles[x - 1, y - 1];
                        Hexagon tileBefore = tiles[x - 1, y];
                        Hexagon tileTop = tiles[x, y - 1];
                        int lastTile = tileDiag.type;
                        needsTileType = true;

                        // Runs methods and checks for Hexagons.
                        if (tileDiag.type == lastTile)
                        {
                            CheckLast(lastTile, tileBefore, tileTop, x, y, oneMatchingPercentage, twoMatchingPercentage, threeMatchingPercentage);
                        }
                        if (tileBefore.type == lastTile)
                        {
                            CheckLast(lastTile, tileDiag, tileTop, x, y, oneMatchingPercentage, twoMatchingPercentage, threeMatchingPercentage);
                        }
                        if (tileTop.type == lastTile)
                        {
                            CheckLast(lastTile, tileDiag, tileBefore, x, y, oneMatchingPercentage, twoMatchingPercentage, threeMatchingPercentage);
                        }
                        lastTile = tileBefore.type;
                        if (tileDiag.type == lastTile)
                        {
                            CheckLast(lastTile, tileBefore, tileTop, x, y, oneMatchingPercentage, twoMatchingPercentage, threeMatchingPercentage);
                        }
                        if (tileBefore.type == lastTile)
                        {
                            CheckLast(lastTile, tileDiag, tileTop, x, y, oneMatchingPercentage, twoMatchingPercentage, threeMatchingPercentage);
                        }
                        if (tileTop.type == lastTile)
                        {
                            CheckLast(lastTile, tileDiag, tileBefore, x, y, oneMatchingPercentage, twoMatchingPercentage, threeMatchingPercentage);
                        }
                        lastTile = tileTop.type;
                        if (tileDiag.type == lastTile)
                        {
                            CheckLast(lastTile, tileBefore, tileTop, x, y, oneMatchingPercentage, twoMatchingPercentage, threeMatchingPercentage);
                        }
                        if (tileBefore.type == lastTile)
                        {
                            CheckLast(lastTile, tileDiag, tileTop, x, y, oneMatchingPercentage, twoMatchingPercentage, threeMatchingPercentage);
                        }
                        if (tileTop.type == lastTile)
                        {
                            CheckLast(lastTile, tileDiag, tileBefore, x, y, oneMatchingPercentage, twoMatchingPercentage, threeMatchingPercentage);
                        }
                        if (needsTileType)
                        {
                            randomTile(x, y);
                        }
                    }
                    else
                    {
                        tiles[x, y].type = 0;
                    }
                }
            }

            // Sends back the tiles array.
            return tiles;
        }
    }
}

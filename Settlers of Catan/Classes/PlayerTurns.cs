using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOCForm.socDataSetTableAdapters;
using System.Configuration;
using System.Deployment.Application;

namespace SOCForm.Classes
{
    public class PlayerTurns
    {
        //this is the initial player turn. They will need to place 2 roads and 2 settlements
        public PlayerTurns(int playerID, string playerType)
        {

        }

        public PlayerTurns()
        {

        }


        //name of current player
        private string playerName;

        //id of current player
        private int playerID;

        //name of nextplayer
        private string nextPlayer;

        //id of next player
        private int nextPlayerID;


        private void fillCardData(int PlayerID, Form1 game)
        {
            game.lmbCntLbl.Text = "0";
            game.brkCntLbl.Text = "0";
            game.grnCntLbl.Text = "0";
            game.oreCntLbl.Text = "0";
            game.woolCntLbl.Text = "0";
            game.traderLumQty.Text = "0";
            game.traderBrickQty.Text = "0";
            game.traderGrainQty.Text = "0";
            game.traderOreQty.Text = "0";
            game.traderWoolQty.Text = "0";

            string connectionString = ConfigurationManager
                .ConnectionStrings["SOCForm.Properties.Settings.socConnectionString"].ConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                try
                {


                    for (int i = 1; i < 6; i++)
                    {
                        SqlDataReader cards = null;
                        SqlCommand fillCard =
                            new SqlCommand(
                                "SELECT QTY, CARD_ID FROM PLAYER_CARDS WHERE(CARD_ID = @VALUE) AND(PLAYER_ID = @PLAYER_ID)",
                                myConnection);
                        //fillCard.Parameters.Add(new SqlParameter("@CARD_ID", System.Data.SqlDbType.Int, 10, "CARD_ID"));
                        //fillCard.Parameters.Add(new SqlParameter("@PLAYER_ID", System.Data.SqlDbType.Int, 10,
                        //    "PLAYER_ID"));
                        fillCard.Parameters.AddWithValue("@VALUE", i);
                        fillCard.Parameters.AddWithValue("@PLAYER_ID", PlayerID);

                        myConnection.Open();
                        using (cards = fillCard.ExecuteReader())
                        {
                            while (cards.Read())
                            {
                                var myString = cards.GetInt32(0).ToString();

                                switch (i)
                                {
                                    case 1:
                                        game.lmbCntLbl.Text = myString.ToString();
                                        game.traderLumQty.Text = myString;
                                        break;
                                    case 2:
                                        game.woolCntLbl.Text = myString.ToString();
                                        game.traderWoolQty.Text = myString;
                                        break;
                                    case 3:
                                        game.grnCntLbl.Text = myString.ToString();
                                        game.traderGrainQty.Text = myString;
                                        break;
                                    case 4:
                                        game.brkCntLbl.Text = myString.ToString();
                                        game.traderBrickQty.Text = myString;
                                        break;
                                    case 5:
                                        game.oreCntLbl.Text = myString.ToString();
                                        game.traderOreQty.Text = myString;
                                        break;
                                }
                            }
                        }

                        myConnection.Close();
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

            }
        }

        //private void drawResourceCards(int cardQty)
        //{

        //}

        //private void build()
        //{
        //    data for user building including drawing development cards via purchase
        //}

        //private void endTurn(int currentPlayer, int nextPlayer)
        //{

        //}
        //private void longestRoadCheck(int playerID, int roadID)
        //{

        //}

        //private void victoryPointsCheck(int playerID, int victoryPoints)
        //{

        //}

        public void acceptTrade(int lumber, int bricks, int wool, int ore, int grain, int lumber2, int bricks2, int wool2, int ore2, int grain2, int PlayerID, int tradingPlayer)
        {

            string connectionString = ConfigurationManager
                .ConnectionStrings["SOCForm.Properties.Settings.socConnectionString"].ConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                try
                {
                    int[] cpData = new[] { lumber2, bricks2, wool2, ore2, grain2};
                    int[] tpData = new[] { lumber, bricks, wool, ore, grain};

                    myConnection.Open();
                    for (int i = 0; i < cpData.Length; i++)
                    {
                        for (int j = 1; j < 5; j++)
                        {
                            SqlCommand updateCurrentPlayer =
                                new SqlCommand(
                                    "UPDATE PLAYER_CARDS SET QTY = @CPL1 WHERE PLAYER_ID = @PLAYER_ID AND CARD_ID = @CARD_ID",
                                    myConnection);

                            updateCurrentPlayer.Parameters.AddWithValue("@PLAYER_ID", PlayerID);
                            updateCurrentPlayer.Parameters.AddWithValue("@cpl1", cpData[i]);
                            updateCurrentPlayer.Parameters.AddWithValue("@CARD_ID", j);
                            updateCurrentPlayer.ExecuteNonQuery();
                        }
                    }

                    for (int i = 0; i < tpData.Length; i++)
                    {
                        for (int j = 1; j < 5; j++)
                        {
                            SqlCommand updateTradingPlayer = new SqlCommand("UPDATE PLAYER_CARDS SET QTY = @CPL1 WHERE PLAYER_ID = @PLAYER_ID AND CARD_ID = @CARD_ID",
                                myConnection);
                            updateTradingPlayer.Parameters.AddWithValue("@TRADING_PLAYER", tradingPlayer);
                            updateTradingPlayer.Parameters.AddWithValue("@tpl1", tpData[i]);
                            updateTradingPlayer.Parameters.AddWithValue("@CARD_ID", j);
                            updateTradingPlayer.ExecuteNonQuery();
                        }
                    }

                    myConnection.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

            }
        }

    }
}

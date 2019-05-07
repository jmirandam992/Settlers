using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace SOCForm.Classes
{
    public class Players
    {
        public Players(int Players)
        {

            initializePlayerData();
        }

        //initialize all players with default data(only to be used at game start)
        private void initializePlayerData()
        {
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
                                "UPDATE Players SET Victory_Points = 0, Longest_Road = 0, ROAD_COUNT = 15 WHERE PLAYER_ID = @PLAYER_ID",
                                myConnection);
                        SqlCommand deleteCards = new SqlCommand("DELETE FROM PLAYER_CARDS", myConnection);
                        SqlCommand deleteRoads = new SqlCommand("DELETE FROM ROADS", myConnection);

                        fillCard.Parameters.AddWithValue("@PLAYER_ID", i);

                        myConnection.Open();
                        deleteCards.ExecuteNonQuery();
                        deleteRoads.ExecuteNonQuery();
                        using (cards = fillCard.ExecuteReader())
                        {
                            while (cards.Read())
                            {
                               
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
       
        //data for the current players trading
        private void getTraderData(Form1 game, int playerID)
        {
            
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
                        fillCard.Parameters.AddWithValue("@VALUE", i);
                        fillCard.Parameters.AddWithValue("@PLAYER_ID", playerID);

                        myConnection.Open();
                        using (cards = fillCard.ExecuteReader())
                        {
                            while (cards.Read())
                            {
                                var myString = cards.GetInt32(0).ToString();

                                switch (i)
                                {
                                    case 1:
                                        game.traderLumQty.Text = myString;
                                        break;
                                    case 2:
                                        game.traderWoolQty.Text = myString;
                                        break;
                                    case 3:
                                       game.traderGrainQty.Text = myString;
                                        break;
                                    case 4:
                                       game.traderBrickQty.Text = myString;
                                        break;
                                    case 5:
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

        //data for the selected tradee
        private void getPlayerTradeeData(Form1 game, int playerID)
        {
            game.tradeeLumberQty.Text = "0";
            game.tradeeBrickQty.Text = "0";
            game.tradeeWoolQty.Text = "0";
            game.tradeeOreQty.Text = "0";
            game.tradeeGrainQty.Text = "0";
           

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
                       
                        fillCard.Parameters.AddWithValue("@VALUE", i);
                        fillCard.Parameters.AddWithValue("@PLAYER_ID", playerID);

                        myConnection.Open();
                        using (cards = fillCard.ExecuteReader())
                        {
                            while (cards.Read())
                            {
                                var myString = cards.GetInt32(0).ToString();

                                switch (i)
                                {
                                    case 1:
                                       
                                        game.tradeeLumberQty.Text = myString;
                                        break;
                                    case 2:
                                        
                                        game.traderWoolQty.Text = myString;
                                        break;
                                    case 3:
                                        
                                        game.traderGrainQty.Text = myString;
                                        break;
                                    case 4:
                                        
                                        game.traderBrickQty.Text = myString;
                                        break;
                                    case 5:
                                       
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








    }
}

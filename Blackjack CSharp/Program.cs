using System;

namespace Blackjack_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;                             //hit, stand, shows stats, or exit based on input
            int aceChoose = 0;                          //determine whether an ace counts as a 1 or 11
            double gameNumber = 1;                      //number shown in "START GAME #X"
            double playerWins = 0;                      //number of times the player wins
            int dealerWins = 0;                         //number of times the dealer wins
            int tieGames = 0;                           //number of tied games
            int playerHand = 0;                         //Sum of cards in player's current hand
            bool success = false;					    //allows for error checking when choosing the value of an ace
            //     Console.ReadKey(true);

            while (true)                                //allows for successive games
            {

                Random randomNumber1 = new Random();                    //creates random number object used for the rest of the game
                Console.WriteLine("START GAME #{0}", (int)gameNumber);
                Console.WriteLine("");
                playerHand = randomNumber1.Next(1, 13);                 //starting card #

                switch (playerHand)                     //in case of each card number
                {
                    case 1:
                        {
                            Console.WriteLine("Your card is a 1!");
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Your card is a 2!");
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Your card is a 3!");
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Your card is a 4!");
                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine("Your card is a 5!");
                            break;
                        }

                    case 6:
                        {
                            Console.WriteLine("Your card is a 6!");
                            break;
                        }

                    case 7:
                        {
                            Console.WriteLine("Your card is a 7!");
                            break;
                        }

                    case 8:
                        {
                            Console.WriteLine("Your card is an 8!");
                            break;
                        }

                    case 9:
                        {
                            Console.WriteLine("Your card is a 9!");
                            break;
                        }

                    case 10:
                        {
                            Console.WriteLine("Your card is a 10!");
                            break;
                        }

                    case 11:
                        {
                            playerHand = 10;
                            Console.WriteLine("Your card is a JACK!");
                            break;
                        }

                    case 12:
                        {
                            playerHand = 10;
                            Console.WriteLine("Your card is a QUEEN!");
                            break;
                        }

                    case 13:
                        {
                            playerHand = 10;
                            Console.WriteLine("Your card is a KING!");
                            break;
                        }
                }

                Console.WriteLine("Your hand is:{0}", playerHand);
                Menu();
                //break;    FIXME: stops while loop so you can judge execution
                
            }
        }

        static void Menu()      //this method prints the game's menu
        {    
            Console.WriteLine("");
            Console.WriteLine("1. Get another card");
            Console.WriteLine("2. Hold hand");
            Console.WriteLine("3. Print statistics");
            Console.WriteLine("4. Exit");
            Console.WriteLine("");
            Console.WriteLine("Choose another option: ");
            Console.ReadKey(true);
        }
    }
}    

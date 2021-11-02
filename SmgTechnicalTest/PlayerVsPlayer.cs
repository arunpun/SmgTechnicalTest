using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmgTechnicalTest
{
    class PlayerVsPlayer
    {
        //Calls the StartPvp function
        public static void Main()
        {
            StartPvp();
        }

        //This runs the game
        private static void StartPvp()
        {
            //Instantiate variables for a player object and user's choice to play again
            bool playAgain = true;
            String answer;

            while (playAgain)
            {
                //Reset values on a new game 
                answer = "";
                var p1 = new Player(); //Is this necessary?
                var p2 = new Player();
                int roundsOfTurns = 0;
                int rockChosen = 0;
                int paperChosen = 0;
                int scissorsChosen = 0;

                //Game calls the two functions below to get player's info
                p1 = GetPlayerOneInfo();
                p2 = GetPlayerTwoInfo();

                //////Testing purposes
                //Console.WriteLine($"{p1.playerName} chose {p1.playerChoice} & {p2.playerName} chose {p2.playerChoice}");

                //Determine the outcome of the game

                switch (p1.playerChoice)
                {
                    //Player 1 chose rock
                    case "rock":

                        rockChosen += 1;

                        //If player 2 also chose rock
                        if (p2.playerChoice == "rock")
                        {
                            rockChosen += 1;
                            roundsOfTurns += 1;
                            Console.WriteLine("***********************************************************************************************************************");
                            Console.WriteLine();
                            Console.WriteLine("You both threw rock, its a draw!");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                            Console.WriteLine();
                            Console.WriteLine("Stats for this game: ");
                            Console.WriteLine();
                            Console.WriteLine($"Most used move: Rock - {rockChosen} times");
                            Console.WriteLine();
                            Console.WriteLine($"The game drew in the {roundsOfTurns}st turn");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                        }

                        //If player 2 chose paper
                        else if (p2.playerChoice == "paper")
                        {
                            paperChosen += 1;
                            roundsOfTurns += 1;
                            Console.WriteLine("***********************************************************************************************************************");
                            Console.WriteLine();
                            Console.WriteLine($"{p2.playerName} threw paper, paper covers rock. {p2.playerName} wins!");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                            Console.WriteLine();
                            Console.WriteLine("Stats for this game: ");
                            Console.WriteLine();
                            Console.WriteLine($"Rock chosen - {rockChosen}, Paper chosen - {paperChosen}, Scissors chosen - {scissorsChosen}");
                            Console.WriteLine();
                            Console.WriteLine($"The game ended in the {roundsOfTurns}st turn. ");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                        }

                        //Else player two chose scissors
                        else
                        {
                            scissorsChosen += 1;
                            roundsOfTurns += 1;
                            Console.WriteLine("***********************************************************************************************************************");
                            Console.WriteLine();
                            Console.WriteLine($"{p2.playerName} threw scissors, rock crushes scissors. You win!");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                            Console.WriteLine();
                            Console.WriteLine("Stats for this game: ");
                            Console.WriteLine();
                            Console.WriteLine($"Rock chosen - {rockChosen}, Paper chosen - {paperChosen}, Scissors chosen - {scissorsChosen}");
                            Console.WriteLine();
                            Console.WriteLine($"The game ended in the {roundsOfTurns}st turn. ");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                        }
                        break;

                    //Player 1 chose paper
                    case "paper":

                        paperChosen += 1;

                        //If player 2 chose rock
                        if (p2.playerChoice == "rock")
                        {
                            rockChosen += 1;
                            roundsOfTurns += 1;
                            Console.WriteLine("***********************************************************************************************************************");
                            Console.WriteLine();
                            Console.WriteLine($"{p2.playerName} threw rock, paper covers rock. {p1.playerName} wins!");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                            Console.WriteLine();
                            Console.WriteLine("Stats for this game: ");
                            Console.WriteLine();
                            Console.WriteLine($"Rock chosen - {rockChosen}, Paper chosen - {paperChosen}, Scissors chosen - {scissorsChosen}");
                            Console.WriteLine();
                            Console.WriteLine($"The game ended in the {roundsOfTurns}st turn");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                        }

                        //If player 2 also chose paper
                        else if (p2.playerChoice == "paper")
                        {
                            paperChosen += 1;
                            roundsOfTurns += 1;
                            Console.WriteLine("***********************************************************************************************************************");
                            Console.WriteLine();
                            Console.WriteLine("You both threw paper, its a draw!");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                            Console.WriteLine();
                            Console.WriteLine("Stats for this game: ");
                            Console.WriteLine();
                            Console.WriteLine($"Most used move: Paper - {paperChosen} times");
                            Console.WriteLine();
                            Console.WriteLine($"The game drew in the {roundsOfTurns}st turn. ");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                        }

                        //Else player two chose scissors
                        else
                        {
                            scissorsChosen += 1;
                            roundsOfTurns += 1;
                            Console.WriteLine("***********************************************************************************************************************");
                            Console.WriteLine();
                            Console.WriteLine($"{p2.playerName} threw scissors, scissors cuts paper. {p2.playerName} wins!");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                            Console.WriteLine();
                            Console.WriteLine("Stats for this game: ");
                            Console.WriteLine();
                            Console.WriteLine($"Rock chosen - {rockChosen}, Paper chosen - {paperChosen}, Scissors chosen - {scissorsChosen}");
                            Console.WriteLine();
                            Console.WriteLine($"The game ended in the {roundsOfTurns}st turn. ");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                        }
                        break;

                    //Player 1 chose scissors
                    case "scissors":

                        scissorsChosen += 1;

                        //If player 2 chose rock
                        if (p2.playerChoice == "rock")
                        {
                            rockChosen += 1;
                            roundsOfTurns += 1;
                            Console.WriteLine("***********************************************************************************************************************");
                            Console.WriteLine();
                            Console.WriteLine($"{p2.playerName} threw rock, rock crushes scissors. {p2.playerName} wins!");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                            Console.WriteLine();
                            Console.WriteLine("Stats for this game: ");
                            Console.WriteLine();
                            Console.WriteLine($"Rock chosen - {rockChosen}, Paper chosen - {paperChosen}, Scissors chosen -  {scissorsChosen}");
                            Console.WriteLine();
                            Console.WriteLine($"The game ended in the {roundsOfTurns}st turn.");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                        }

                        //If player 2 chose paper
                        else if (p2.playerChoice == "paper")
                        {
                            paperChosen += 1;
                            roundsOfTurns += 1;
                            Console.WriteLine("***********************************************************************************************************************");
                            Console.WriteLine();
                            Console.WriteLine($"{p2.playerName} threw paper, scissors cuts paper. {p1.playerName} wins!");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                            Console.WriteLine();
                            Console.WriteLine("Stats for this game: ");
                            Console.WriteLine();
                            Console.WriteLine($"Rock chosen - {rockChosen}, Paper chosen -  {paperChosen} , Scissors chosen -  {scissorsChosen}");
                            Console.WriteLine();
                            Console.WriteLine($"The game ended in the {roundsOfTurns}st turn. ");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                        }

                        //Else player 2 two chose scissors
                        else
                        {
                            scissorsChosen += 1;
                            roundsOfTurns += 1;
                            Console.WriteLine("***********************************************************************************************************************");
                            Console.WriteLine();
                            Console.WriteLine("You both threw scissors, its a draw!");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                            Console.WriteLine();
                            Console.WriteLine("Stats for this game: ");
                            Console.WriteLine();
                            Console.WriteLine($"Most used move: Scissors {scissorsChosen} times");
                            Console.WriteLine();
                            Console.WriteLine($"The game drew in the {roundsOfTurns}st turn. ");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                        }
                        break;
                }
               
                //Ask the user if they want to play again
                while (answer != "y" && answer != "n")
                {
                    Console.WriteLine();
                    Console.WriteLine("Would you like to play again? Please enter (y for yes or n for no): ");
                    answer = Console.ReadLine();
                    answer.ToLower();
                }

                //Restart or end the game
                if (answer == "y")
                {
                    playAgain = true;
                    roundsOfTurns = 0;
                    rockChosen = 0;
                    paperChosen = 0;
                    scissorsChosen = 0;
                    Console.WriteLine();
                    Console.WriteLine("***********************************************************************************************************************");
                    Console.WriteLine();
                }
                else
                {
                    playAgain = false;
                    Console.WriteLine("");
                }
            }

            //Function to get player one's info
            static Player GetPlayerOneInfo()
            {
                Player p1 = new Player();

                Console.WriteLine("Please enter a name for Player 1: ");
                p1.playerName = Console.ReadLine();
                p1.playerName.ToLower();
                Console.WriteLine();


                while (p1.playerChoice is not "rock" and not "paper" and not "scissors")
                {
                    Console.WriteLine($"What does {p1.playerName} choose? Please type rock, paper or scissors: ");
                    p1.playerChoice = Console.ReadLine();
                    Console.WriteLine();
                }

                return p1;
            }

            //Function to get player two's info

            static Player GetPlayerTwoInfo()
            {
                Player p2 = new Player();

                Console.WriteLine("Please enter a name for Player 2: ");
                p2.playerName = Console.ReadLine();
                p2.playerName.ToLower();
                Console.WriteLine();


                while (p2.playerChoice is not "rock" and not "paper" and not "scissors")
                {
                    Console.WriteLine($"What does {p2.playerName} choose? Please type rock, paper or scissors: ");
                    p2.playerChoice = Console.ReadLine();
                    Console.WriteLine();
                }

                return p2;
            }
        }
    }
}


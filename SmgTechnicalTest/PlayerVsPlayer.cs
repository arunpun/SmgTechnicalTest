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
            var p1 = new Player();
            var p2 = new Player();

            while (playAgain)
            {
                //Reset play again answer
                answer = "";

                //Game calls the two functions below to get player's info
                p1 = GetPlayerOneInfo();
                p2 = GetPlayerTwoInfo();

                ////Testing purposes
                //Console.WriteLine($"{p1.playerName} chose {p1.playerChoice} & {p2.playerName} chose {p2.playerChoice}");

                //Determine the outcome of the game

                //Player one chooses rock 
                if (p1.playerChoice == "rock")
                    //If player two also chose rock
                    if (p2.playerChoice == "rock")
                    {
                        Console.WriteLine($"You both chose rock, its a draw!");
                        Console.WriteLine();
                        Console.WriteLine("***********************************************************************************************************************");
                    }
                    //If player two chose paper
                    else if (p2.playerChoice == "paper")
                    {
                        Console.WriteLine($"{p1.playerName} chose rock and {p2.playerName} chose paper. Paper wraps rock, {p2.playerName} wins!");
                        Console.WriteLine();
                        Console.WriteLine("***********************************************************************************************************************");
                    }
                    //If player two chose scissors
                    else if (p2.playerChoice == "scissors")
                    {
                        Console.WriteLine($"{p1.playerName} chose rock and {p2.playerName} chose scissors. Rock crushes scissors, {p1.playerName} wins!");
                        Console.WriteLine();
                        Console.WriteLine("***********************************************************************************************************************");
                    }

                //Player one chose paper 
                if (p1.playerChoice == "paper")
                    //Player two chose rock
                    if (p2.playerChoice == "rock")
                    {
                        Console.WriteLine($"{p1.playerName} chose paper and {p2.playerName} chose rock. Paper wraps rock, {p1.playerName} wins!");
                        Console.WriteLine();
                        Console.WriteLine("***********************************************************************************************************************");
                    }
                    else if (p2.playerChoice == "paper")
                    {
                        Console.WriteLine($"You both chose paper, its a draw!");
                        Console.WriteLine();
                        Console.WriteLine("***********************************************************************************************************************");
                    }
                    else if (p2.playerChoice == "scissors")
                    {
                        Console.WriteLine($"{p1.playerName} chose paper and {p2.playerName} chose scissors. Scissors cuts paper, {p2.playerName} wins!");
                        Console.WriteLine();
                        Console.WriteLine("***********************************************************************************************************************");
                    }

                //Player one chose scissors 
                if (p1.playerChoice == "scissors")
                    //Player two chose rock
                    if (p2.playerChoice == "rock")
                    {
                        Console.WriteLine($"{p1.playerName} chose scissors and {p2.playerName} chose rock. Rock crushes scissors, {p2.playerName} wins!");
                        Console.WriteLine();
                        Console.WriteLine("***********************************************************************************************************************");
                    }
                    else if (p2.playerChoice == "paper")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{p1.playerName} chose scissors and {p2.playerName} chose paper. Scissors cuts paper, {p1.playerName} wins!");
                        Console.WriteLine();
                        Console.WriteLine("***********************************************************************************************************************");
                    }
                    else if (p2.playerChoice == "scissors")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"You both chose scissors, its a draw!");
                        Console.WriteLine();
                        Console.WriteLine("***********************************************************************************************************************");
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

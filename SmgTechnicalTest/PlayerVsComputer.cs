using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmgTechnicalTest
{
    class PlayerVsComputer
    {
        public static void Main()
        {
            ////For testing 
            //Console.WriteLine("PlayerVsComputer main method is now running");

            //Create an instance of Random and declare variables
            Random random = new Random();
            bool playAgain = true;
            String playerChoice;
            String computerChoice;
            String answer;

            while (playAgain)
            {
                //Reset player's, computer's choice & answer
                playerChoice = "";
                computerChoice = "";
                answer = "";

                //Ask user to enter their choice whilst checking that the input is valid
                while (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
                {
                    Console.WriteLine();
                    Console.Write("Please enter rock, paper or scissors:");
                    Console.WriteLine();
                    playerChoice = Console.ReadLine();
                    playerChoice.ToLower();
                }

                Console.WriteLine();
            
                //Generate a selection for computer
                switch (random.Next(1,4))
                {
                    //Computer gets 1(rock)
                    case 1:
                        computerChoice = "rock";
                        break;

                    //Computer gets 2(paper)
                    case 2:
                        computerChoice = "paper";
                        break;

                    //Computer gets 3(paper)
                    case 3:
                        computerChoice = "scissors";
                        break;        
                }

                //Compare the selections, determine and display the results
                switch (playerChoice)
                {
                    //Player threw rock
                    case "rock":
                        //If computer's choice is rock
                        if (computerChoice == "rock")
                        {
                            Console.WriteLine($"The computer also threw rock, its a draw");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                        }

                        //If computer's choice is paper
                        else if (computerChoice == "paper")
                        {
                            Console.WriteLine($"The computer threw paper, it covers rock. Computer wins!");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                        }

                        //If computer's choice is scissors
                        else
                        {
                            Console.WriteLine($"The computer threw scissors, rock crushes the scissors. You win!");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                        }
                        break;

                    //Player threw paper
                    case "paper":
                        //If computer's choice is rock
                        if (computerChoice == "rock")
                        {
                            Console.WriteLine($"The computer threw rock, paper covers rock. You win! ");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                        }

                        //If computer's choice is paper
                        else if (computerChoice == "paper")
                        {
                            Console.WriteLine($"The computer also threw paper, its a draw!");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                        }

                        //If computer's choice is scissors
                        else
                        {
                            Console.WriteLine($"The computer threw scissors, scissors cuts paper. Computer wins!");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                        }
                        break;

                    //Player threw scissors
                    case "scissors":
                        //If computer's choice is rock
                        if (computerChoice == "rock")
                        {
                            Console.WriteLine($"The computer threw rock, rock crushes scissors. Computer wins! ");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                        }

                        //If computer's choice is paper
                        else if (computerChoice == "paper")
                        {
                            Console.WriteLine($"The computer threw paper, scissors cuts paper. You win!");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                        }

                        //If computer's choice is scissors
                        else
                        {
                            Console.WriteLine($"The computer also threw scissors, its a draw!");
                            Console.WriteLine();
                            Console.WriteLine("***********************************************************************************************************************");
                        }
                        break;
                }

                //Ask the user if they want to play again
                Console.WriteLine();
                Console.WriteLine("Would you like to play again? Please enter (Y for yes or N for no): ");
                answer = Console.ReadLine();
                answer.ToLower();

                //
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
                }
            }
        }
    }
}

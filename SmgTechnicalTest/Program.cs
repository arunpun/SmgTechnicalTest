using System;

namespace SmgTechnicalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determine PVC or PVP
            String pvc = "1 - Player vs Player";
            String pvp = "2 - Player vs Computer";

            Console.WriteLine("Welcome to Arun's attempt at the SMG's technical test");
            Console.WriteLine("\n");
            Console.WriteLine("Please see the game options below:");
            Console.WriteLine("\n" + pvc);
            Console.WriteLine("\n" + pvp);
            Console.WriteLine("\n");

            String userChoice;
            bool userChoiceIsInvalid = true;

            //Get and check if the user's input is valid
            while (userChoiceIsInvalid)
            {
                //Ask the user for a valid input
                Console.WriteLine("Please select an option by entering 1 or 2");

                userChoice = Console.ReadLine();
                int userChoiceInt = Int32.Parse(userChoice);
                Console.WriteLine(); //For spacing

                if (userChoiceInt == 1 || userChoiceInt == 2)
                {
                    userChoiceIsInvalid = false;

                    switch (userChoiceInt)
                    {
                        //If PVC, run PVC's main method
                        case 1:
                            Console.WriteLine("***********************************************************************************************************************");
                            Console.WriteLine();
                            Console.WriteLine($"You chose {userChoiceInt} - Player vs Player");
                            Console.WriteLine();
                            PlayerVsPlayer.Main();
                            break;

                        //Else it is PVP, run PVP's main method
                        case 2:
                            Console.WriteLine($"You chose {userChoiceInt} - Player vs Computer");
                            Console.WriteLine();
                            PlayerVsComputer.Main();
                            break;
                    }
                }
            }
        }
    }
}
   


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");

        //Initiate classes
        Game backend = new Game();

        int userChoice = 0;
        while (userChoice != 4)
        {
            //Clear the menu after an option has been chosen
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Load Game");
            Console.WriteLine("3. View Achievements");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the memu: ");

            try
            {
                string userEntry = Console.ReadLine();
                userChoice = int.Parse(userEntry);
                Console.WriteLine();

                if (userChoice == 1)
                {
                    backend.NewGame();
                }
                else if (userChoice == 2)
                {
                    backend.LoadGame();
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("View Achievements");
                }
                else if (userChoice == 4)
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("The choice made was not one of the options. Please try again");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
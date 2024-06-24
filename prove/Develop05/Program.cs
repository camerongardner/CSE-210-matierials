using System;

class Program
{
    static void Main(string[] args)
    {
        //Access the classes
        Goals newGoal = new Goals();

        newGoal.LoadEntries();

        Console.WriteLine("Hello Develop05 World!\n");

        int userChoice = 0;
        while (userChoice != 7)
        {
            Console.WriteLine("\nYou have " + newGoal.ReturnTally() + " points.\n");
            //Clear the menu after an option has been chosen
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Delete a goal");
            Console.WriteLine("7. Quit");
            Console.Write("Select a choice from the memu: ");

            try
            {
                string userEntry = Console.ReadLine();
                userChoice = int.Parse(userEntry);
                Console.WriteLine();

                if (userChoice == 1)
                {
                    newGoal.DisplayGoalMenu();
                }
                else if (userChoice == 2)
                {
                    newGoal.ListGoals();
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("Saving goals...");
                }
                else if (userChoice == 4)
                {
                    newGoal.LoadEntries();
                }
                else if (userChoice == 5)
                {
                    newGoal.RecordEvent();
                }
                else if (userChoice == 6)
                {
                    newGoal.DeleteGoal();
                }
                else if (userChoice == 7)
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
using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        // Create an instance of the Activities class
        Activities activities = new Activities();
        Breathing breathing = new Breathing();
        Reflection reflection = new Reflection();
        Listing listing = new Listing();

        // Setup the while loop
        int userChoice = 0;
        activities.Clear();
        
        while (userChoice !=4)
        {
            //Clear the menu after an option has been chosen
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1 = Start breathing exercises");
            Console.WriteLine("2 = Start reflection exercises");
            Console.WriteLine("3 = Start listing exercises");
            Console.WriteLine("4 = Quit the application");
            Console.Write("Please select an option: ");

            try
            {
                string userEntry = Console.ReadLine();
                userChoice = int.Parse(userEntry);
                Console.WriteLine();

                if (userChoice == 1)
                {
                    breathing.StartBreathing();

                }
                else if (userChoice == 2)
                {
                    reflection.StartReflection();
                }
                else if (userChoice == 3)
                {
                    listing.StartListing();
                }
                else if (userChoice == 4)
                {
                    activities.Clear();
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
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        // Create an instance of the Journal class
        Journal myJournal = new Journal("My Journal");
        myJournal.LoadEntries();

        // Have the loop begin
        int userChoice = -1;

        // User interface options and loop to use the app
        while (userChoice != 0)
        {
            // Menu options list
            Console.WriteLine();
            Console.WriteLine("0 = Terminate the program.");
            Console.WriteLine("1 = Create a journal entry");
            Console.WriteLine("2 = List all entries");
            Console.WriteLine("3 = Delete an entry");
            Console.Write("Please select an option: ");

            try
            {
                string userEntry = Console.ReadLine();
                userChoice = int.Parse(userEntry);
                Console.WriteLine();

                // Logic for user choices
                if (userChoice == 1)
                {
                    // Call the CreateEntry method to create a new entry
                    Entry newEntry = Create.CreateEntry(myJournal);

                    // Add the new entry to the journal
                    myJournal.AddEntry(newEntry);

                    // Notify the user
                    Console.WriteLine();
                    Console.WriteLine("Entry added successfully!");
                    Console.WriteLine();
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("All Entries:");
                    foreach (var entry in myJournal.ListEntries())
                    {
                        Console.WriteLine(entry);
                    }
                    Console.WriteLine();
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("Which entry would you like to delete?");
                    foreach (var entry in myJournal.ListEntries())
                    {
                        Console.WriteLine(entry);
                    }
                    Console.WriteLine();
                    Console.Write("Which journal entry needs to be deleted: ");

                    try
                    {
                        int deleteId = int.Parse(Console.ReadLine());
                        Delete.DeleteEntry(myJournal, deleteId);

                        // Show updated journal entry list
                        userChoice = 2; // List all entries after deletion
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid entry ID. Please enter a valid integer.");
                    }
                }
                else if (userChoice == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Thank you for writing in your journal");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer option.");
            }
        }
    }
}

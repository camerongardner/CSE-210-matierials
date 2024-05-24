using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        // Get the scripture from the user
        Console.Write("What is the scripture? ");
        string scriptureInput = Console.ReadLine();
        // Set a default if the user does not provide a scripture
        string scripture = string.IsNullOrEmpty(scriptureInput) ? "I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days." : scriptureInput;
        string reference;
        if (string.IsNullOrEmpty(scriptureInput))
        {
            reference = "1 Nephi 1:1";
        }
        else 
        {
            Console.Write("What is the book that the scripture is from (example 1 Nephi)? ");
            string book = Console.ReadLine();
            Console.Write("What is the chapter number for the scriptire? ");
            string chapterNumInput = Console.ReadLine();
            int chapterNum = int.Parse(chapterNumInput);
            Console.Write("What is/are the verse number(s)");
            string versesInput = Console.ReadLine();

            reference = $"{book} {chapterNum}:{versesInput}";
        }

        //Call the classes to be used
        Scripture scripture1 = new Scripture(scripture, reference);

        Randomizer randomize = new Randomizer();

        //Runs the loop to have the program work
        Console.WriteLine("Press enter to hide a word. Type 'quit' to exit.");
        while (true)
        {
            string userInput = Console.ReadLine();
            //Checks if the user typed quit and or if all the words have been hidden
            if (userInput.ToLower() == "quit" || scripture1.AllWordsHidden())
            {
                break;
            }

            //Hide a random word
            randomize.HideRandomWord(scripture1);
            //Display the updated scripture(s)
            scripture1.Display();
        }

        Console.WriteLine("I hopoe that you were able to memoroze the scripture!");
    
    }
}

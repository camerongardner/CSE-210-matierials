using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // Get the Magic number
        // Console.Write("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int magicNumberInt = int.Parse(magicNumber);

        // Keep track of user attepts to guess
        int attempts = 0;

        // Computer creates the random number
        Random randomGenerator = new Random();
        int magicNumberInt = randomGenerator.Next(1, 100);

        // Get the user guess of the magic number
        Console.Write("What is your guess? ");
        string userGuess = Console.ReadLine();
        int userGuessInt = int.Parse(userGuess);

        // Continuous play?
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            // Computer creates the random number
            magicNumberInt = randomGenerator.Next(1, 100);

            // While the the magic number and user input do not match loop
            while (magicNumberInt != userGuessInt)
            {
                // Add 1 to the attempts value
                attempts ++;

                // Display the comparison results
                if (magicNumberInt > userGuessInt)
                {
                    Console.WriteLine("Higher");
                    // Get the user guess of the magic number
                    Console.Write("What is your guess? ");
                    userGuess = Console.ReadLine();
                    userGuessInt = int.Parse(userGuess);
                }
                else if (magicNumberInt < userGuessInt)
                {
                    Console.WriteLine("Lower");
                    Console.Write("What is your guess? ");
                    userGuess = Console.ReadLine();
                    userGuessInt = int.Parse(userGuess);
                }
            }
            // You guessed the magic number print out
            Console.WriteLine($"You guessed it in {attempts + 1} attempts!");

            // Asking the user if they want to play again
            Console.Write("Do you want to play again (yes/no)? ");
            playAgain = Console.ReadLine();

            // Reset the attempts value
            attempts = -1;
        }
    }
}
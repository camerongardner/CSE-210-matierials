using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        //Example of a function
        // returnType FunctionName(dataType parameter1, dataType parameter2)
        // {
             // function_body
        // }
        
        //If a function dopes not have parameters or a return type follow below
        // void DisplayMessage()
        // {
             // Console.WriteLine("Hello world!");
        // }

        //Example that accepts a single string parameter
        //void DisplayPersonalMessage(string userName)
        // {
             // Console.WriteLine($"Hello {userName}");
        // }

        // The next example shows a function that accepts two integers as 
        // parameters. It adds them together and returns the result. Notice 
        // that the function specifies a return value of int at the beginning 
        // of the definition.

        // int AddNumbers(int first, int second)
        // {
        //     int sum = first + second;
        //     return sum;
        // }

        // To define a standalone function in C#, use the static keyword 
        // before the return type:

        // static void DisplayMessage()
        // {
        //     Console.WriteLine("Hello world!");
        // }

        // static void DisplayPersonalMessage(string userName)
        // {
        //     Console.WriteLine($"Hello {userName}");
        // }

        // static int AddNumbers(int first, int second)
        // {
        //     int sum = first + second;
        //     return sum;
        // }

        // Welcome users to the program
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();

            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string favoriteNumber = Console.ReadLine();
            int number = int.Parse(favoriteNumber);

            return number;
        }
        static int SquareNumber(int number)
        {
            int sqrtNum = number * number;

            return sqrtNum;
        }
        static void DisplayResult(int sqrtNum, string name)
        {
            Console.WriteLine($"{name}, the square of your number is {sqrtNum}");
        }
        static void Main()
        {
            DisplayWelcome();
            int num = PromptUserNumber();
            string name = PromptUserName();
            int square = SquareNumber(num);
            DisplayResult(square, name);
        }
        Main();
    }
}
using System;
using System.Collections.Generic; // This is esential to use lists
using System.Dynamic;
using System.Linq; // This is to easily get the largest value in the list

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        // Examples of creating variables to hold lists.
        // List<int> numbers = new List<int>();
        List<string> words = new List<string>();
        //Examples of adding data into a list
        words.Add("phone");
        words.Add("keyboard");
        words.Add("mouse");

       // The easiest (and safest) way to iterate through a list in 
       //C# is to use the foreach loop: C#
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // Project

        //Variables
        int sum = 0;

        //List for user values
        List<int> numbers = new List<int>();

        //Begining sentence
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userEntryNum = -1;

        // Add user entries to the numbers list
        while (userEntryNum != 0)
        {
            //user value input
            Console.Write("Enter number: ");
            string userEntry = Console.ReadLine();
            userEntryNum = int.Parse(userEntry);
            if (userEntryNum != 0)
            {
                numbers.Add(userEntryNum);
            }
        }

        //Get the sum of the numbers lit
        foreach (int number in numbers)
        {
            sum += number;
        }

        //Get the average of the numbers

        float average = ((float)sum) / numbers.Count;

        //Get the largest number entered
        int max = numbers.Max();

        // Get the smallest number larger than 0
        //The "Where" condition indicates further logic is to be
        //implemented. The => means that the left value needs to be
        // in accordance wth the logic attached the right side of the
        // =>. The .Min is going through the list to get the smallest
        //value
        int min = numbers.Where(n => n > 0).Min();

        //Print the numbers from the list
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest non-negative number is: {min}");
        //Print the numbers from least to greatest
        numbers.Sort();
        Console.WriteLine("The list of numbers from least to greatest.");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        

    }
}
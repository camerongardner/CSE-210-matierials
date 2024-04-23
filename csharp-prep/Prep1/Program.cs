using System;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.Write("What is your first name? ");
        String First_Name = Console.ReadLine();
        Console.Write("What is your last name? ");
        String Last_Name = Console.ReadLine();
        Console.WriteLine("");

        Console.WriteLine($"Your name is {Last_Name}, {First_Name} {Last_Name}");

        // Prep #2
        string letter = "";

        Console.Write("What is your grade percentage? ");
        string gradeTxt = Console.ReadLine();
        int gradeNum = int.Parse(gradeTxt);

        if (gradeNum >= 90)
        {
            letter = "A";
        }
        else if (gradeNum >= 80)
        {
            letter = "B";
        }
        else if (gradeNum >= 70)
        {
            letter = "C";
        }
        else if (gradeNum >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int parse = gradeNum % 10;
        string bonus = "";

        if (parse >= 7 && gradeNum >= 60 && gradeNum < 90)
        {
            bonus = "+";
        }
        else if (parse < 3 && gradeNum >= 60 && gradeNum < 90)
        {
            bonus = "-";
        }
        else
        {
            bonus = "";
        }

        if (gradeNum >= 70)
        {
            Console.WriteLine($"Congragulations you passed the class with a {letter}{bonus}.");
        }
        else
        {
            Console.WriteLine($"I appologize but you did not pass the course. You got a {letter}{bonus}, and needed at least a 70%");
        }
    }
}
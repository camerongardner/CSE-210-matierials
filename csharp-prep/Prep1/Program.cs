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

    }
}
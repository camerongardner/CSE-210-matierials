using System;
using System.Runtime.InteropServices;
public class Breathing : Activities
{
    public void StartBreathing()
    {
        GetUserInput(1);
        Clear();
        Console.WriteLine(DisplayActivity());
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
        Start();

        // Breathing exercise
        while (DateTime.Now < _duration)
        {

            Console.Write("Breathe in...");
            Console.Write("3\b");
            Thread.Sleep(1000);
            Console.Write("2\b");
            Thread.Sleep(1000);
            Console.Write("1\b");
            Thread.Sleep(1000);
            Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r"); // Clear the line
            Console.Write("Breathe in...");

            Console.WriteLine();
            Console.Write("Breathe out...");
            Console.Write("3\b");
            Thread.Sleep(1000);
            Console.Write("2\b");
            Thread.Sleep(1000);
            Console.Write("1\b");
            Thread.Sleep(1000);
            Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r"); // Clear the line
            Console.Write("Breathe out...");
        }
        ClosingActivity();
               // Clear();
    }
}
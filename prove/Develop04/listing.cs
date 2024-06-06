using System;
using System.Diagnostics.CodeAnalysis;

public class Listing : Activities
{
    public void StartListing()
    {
        GetUserInput(3);
        Clear();
        Console.WriteLine(DisplayActivity());
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");
        Start();

        Random random = new Random();
        string[] prompts = {
            "List as many things as you can that make you happy.",
            "Write down all the things you are grateful for.",
            "List all the people in your life that you love.",
            "Write down all the things you have accomplished.",
            "List all the things you are proud of.",
            "Write down all the things you are looking forward to.",
            "List all the things you have learned.",
            "Write down all the things you are excited about.",
            "List all the things you have overcome.",
            "Write down all the things you are passionate about.",
            "When have you felt the Holy Ghost this month?",
            "When were you able to see the hand of the Lord in your life this week?",
            "What were the tendermercies you experienced today?"
        };

        int index = random.Next(prompts.Length);
        string prompt = prompts[index];
        string border = new string('-', prompt.Length);

        Console.WriteLine("+" + border + "+");
        Console.WriteLine("|" + prompt + "|");
        // Allow user to indicate when they are ready
        Console.WriteLine("+" + border + "+\n");

        //Begin countdown
        CountdownTimer();

        int responseCount = 0; // Variable to keep track of the number of responses

        while (DateTime.Now < _duration)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responseCount++; // Increment the response count for each response
        }

        Console.WriteLine($"You listed {responseCount} items!");
        ClosingActivity();
    }
}
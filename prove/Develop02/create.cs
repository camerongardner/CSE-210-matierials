using System;
using System.Collections.Generic;

public class Create
{
    public static List<string> _prompts = new List<string>
    {
        "What was the highlight of your day?",
        "Write about a place you'd like to visit and why.",
        "Describe a recent dream you remember.",
        "What are you grateful for today?",
        "Discuss your current favorite hobby or activity.",
        "What was a challenging moment today and how did you handle it?",
        "Write about someone who inspires you."
    };
    public static Random _random = new Random();

    public static Entry CreateEntry(Journal journal)
    {
        int _entryID = journal.GetNextEntryId();  // Get the next unique ID from Journal
        string _prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"Today's prompt is {_prompt}");
        string _entryContent = Console.ReadLine();
        Console.WriteLine(_prompt);

        return new Entry(_entryID, _entryContent);

    }
}

using System;

public class ChecklistGoal : NewGoal
{
    public override void Create(string filename)
    {
        _DefaultFileName = filename;
        Start();
        Console.Write("How many times does this goal need to be acomplished for a bonus? ");
        string userEntry = Console.ReadLine();
        while (userEntry == "0" || userEntry == "")
        {
            Console.Write("Please enter a number: ");
            userEntry = Console.ReadLine();
        }
        _bonusRequirement = int.Parse(userEntry);
        Console.Write("What is the bonus for acomplishing it that many times? ");
        userEntry = Console.ReadLine();
        _bonusPoints = int.Parse(userEntry);
        SaveToCSV();

    }
}
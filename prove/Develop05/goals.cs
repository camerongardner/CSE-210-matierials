using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

public class Goals
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints;
    protected int _bonusRequirement;
    protected int _bonusPoints;
    protected string _DefaultFileName;
    protected string _result;
    private int _tally = 0;
    protected string _isComplete = "false";
    protected int _checklistCount = -1;
    protected int _isEternal = 0;


    public List<string> _entries = new List<string>();

    //Show memu for for choosing option 1
    public void DisplayGoalMenu()

    {
        int goalOption = 0;
        while (goalOption != 4)
        {
            Console.WriteLine("The types of goals are:");
            Console.WriteLine("1. Simple goal");
            Console.WriteLine("2. Eternal goal");
            Console.WriteLine("3. Checklist goal");
            Console.Write("Select a choice from the menu: ");

            try
            {
                string userEntry = Console.ReadLine();
                goalOption = int.Parse(userEntry);
                Console.WriteLine();

                NewGoal goal = null;

                switch (goalOption)
                {
                    case 1:
                        goal = new SimpleGoal();
                        goal.Create(_DefaultFileName);
                        return;
                    case 2:
                        goal = new EternalGoal();
                        goal.Create(_DefaultFileName);
                        return;
                    case 3:
                        goal = new ChecklistGoal();
                        goal.Create(_DefaultFileName);
                        return;
                    default:
                        Console.WriteLine("The choice made was not one of the options. Please try again.");
                        continue;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
    //Start a new goal
    public void Start()
    {

        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write("What is the ammount of points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
        _bonusPoints = 0;
        _bonusRequirement = 0;
        _isEternal = 0;

    }
    //Save the goal to a CSV file
    public void SaveToCSV()
    {
        bool fileExists = File.Exists(_DefaultFileName);
        // Data is being overwritten each time the file is saved
        // Also where are we saving the new entries to the _entries list?
        using (StreamWriter file = new StreamWriter($"{_DefaultFileName}", true))
        {
            if (!fileExists)
            {
             file.WriteLine($"{_isComplete},{_goalName},({_goalDescription}),{_bonusRequirement},{_goalPoints},{_bonusPoints}, {_tally}, {_isEternal}");
            }
            if(_bonusRequirement == 0)
            {
                file.WriteLine($"{_isComplete},{_goalName},({_goalDescription}),{_bonusRequirement},{_goalPoints},{_bonusPoints},{_checklistCount}, {_isEternal}");
            }
            else
            {
                _checklistCount = 0;
                file.WriteLine($"{_isComplete},{_goalName},({_goalDescription}),{_bonusRequirement},{_goalPoints},{_bonusPoints},{_checklistCount}, {_isEternal}");
            }
        }

    }
    public void LoadEntries()
    {
        _entries.Clear();
        Console.Write("Enter a desired goals file name or press Enter to use the default file name. ");
        string userEntry = Console.ReadLine();

        if (string.IsNullOrEmpty(userEntry))
        {
            _result = "goals.csv";
            _DefaultFileName = _result;
        }
        else
        {
            _result = $"{userEntry}.csv";
            _DefaultFileName = _result;
        }
        if (File.Exists(_DefaultFileName))
        {
            string[] lines = File.ReadAllLines(_DefaultFileName);
            if (lines.Length > 1)
            {
                _tally = int.Parse(lines[0].Split(",")[6]);

                for (int i = 1; i < lines.Length; i++) // Skip the header
                {
                    _entries.Add(lines[i]);
                }
            }
        }
        else
        {
            File.Create(_DefaultFileName).Close();  // Create the file if it does not exist and close it immediately
            Console.WriteLine($"No existing journal found. A new journal has been created, named {_DefaultFileName}.");
            // Optionally write the header to the new file
            using (StreamWriter sw = new StreamWriter(_DefaultFileName))
            {
                sw.WriteLine($"IsComplete,Name,Description,Bonus_Requirements,Points,Bonus_Points,{_tally},Checklist_Count,IsEternal");
            }

            

        }
    }
    public void ListGoals()
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(_DefaultFileName);
        if (lines.Length > 1)
        {
            for (int i = 1; i < lines.Length; i++) // Skip the header
            {
                _entries.Add(lines[i]);
            }
        }

        GoalDisplay();
    }
    public void RecordEvent()
    {
         _entries.Clear();
        string[] lines = File.ReadAllLines(_DefaultFileName);
        if (lines.Length > 1)
        {
            for (int i = 1; i < lines.Length; i++) // Skip the header
            {
                _entries.Add(lines[i]);
            }
        }

        if (_entries.Count == 0)
        {
            Console.WriteLine("No goals found.");
        }
        else
        {
            GoalDisplay();
        }
        Console.Write("Which goal did you accomplish? ");
        string userEntry = Console.ReadLine();
        int goalIndex = int.Parse(userEntry) - 1;

        //Completion indicator
        var parts = _entries[goalIndex].Split(',');

        // Logic needs to be fixed for eternal goals
        if (parts[7] == " 1")
        {
            Console.WriteLine("It was a success");
        }
        else if (_entries[goalIndex].Split(',')[3] == "0" && parts[7] == " 0")
        {
            // var parts = _entries[goalIndex].Split(',');
            string isComplete = parts[0];
            parts[0] = "true";
            lines[goalIndex + 1] = string.Join(",", parts);
            File.WriteAllLines(_DefaultFileName, lines);

        }
        else
        {
            _checklistCount = int.Parse(parts[6]);
            string _checkItem = parts[6];
            parts[6] = (_checklistCount + 1).ToString();
            lines[goalIndex + 1] = string.Join(",", parts);
            File.WriteAllLines(_DefaultFileName, lines);


            goalIndex = int.Parse(userEntry) - 1;

            Console.WriteLine($"What is parts 0 {parts[0]}");

            if ((parts[6] == parts[3]) && (parts[0] == "false"))
            { 
                Console.WriteLine($"What is parts 0 {parts[0]}");
                parts[0] = "true";
                lines[goalIndex + 1] = string.Join(",", parts);
                File.WriteAllLines(_DefaultFileName, lines);
                _tally += int.Parse(parts[5]);
            }
        }

        // Points system
        var entriesParts = _entries[goalIndex].Split(',');
        int addPoints = int.Parse(entriesParts[4]);
        _tally += addPoints;
        
        var pointLine = File.ReadAllLines(_DefaultFileName).ToList();
        var values = lines[0].Split(',');
        values[6] = _tally.ToString();
        lines[0] = string.Join(",", values);
        File.WriteAllLines(_DefaultFileName, lines);
    }
    public int ReturnTally()
    {
        return _tally;
    }
    public void GoalDisplay()
    {
        int counter;
        if (_entries.Count == 0)
        {
            Console.WriteLine("No goals found.");
        }
        else
        {
            counter = 1;
            Console.WriteLine("The goals are:");
            foreach (var entry in _entries)
            {
                var entryParts = entry.Split(',');
                if (entryParts[0] == "false" && entryParts[3] == "0")
                    Console.WriteLine($"{counter}. [ ] {entryParts[1]} ({entryParts[2]})");
                else if (entryParts[0] == "false" && (entryParts[3] != "0"))
                {
                    Console.WriteLine($"{counter}. [ ] {entryParts[1]} ({entryParts[2]}) - currenty completed: {entryParts[6]}/{entryParts[3]} ");
                }
                else if (entryParts[0] == "true" && entryParts[3] == "0")
                    Console.WriteLine($"{counter}. [X] {entryParts[1]} ({entryParts[2]})");
                else if (entryParts[0] == "true" && (entryParts[3] != "0"))
                    Console.WriteLine($"{counter}. [X] {entryParts[1]} ({entryParts[2]}) - currenty completed: {entryParts[6]}/{entryParts[3]} ");
                else
                    Console.WriteLine($"{counter}. [ ] {entryParts[1]} ({entryParts[2]})");
                counter++;
            }
            Console.WriteLine();
        }
    }

}
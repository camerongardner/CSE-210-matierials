using System.Diagnostics;

public class Activities
{
    //Save the user input
    protected int _userChoice ;

    //Save the duration of the activity
    protected DateTime _duration;
    //Save the duration in seconds
    protected int _seconds;

    //List of activities
    private string[] _activityList = new string[] { "breathing exercise", "reflection exercise", "listing exercise"};

    //Random number generator for loading animation
    private Random _random = new Random();

    //List of random amounts of seconds for loading animation
    List<int> _randomSeconds = new List<int> { 2500, 5000, 7500, 10000 };
    List<int> _randomSecondsFast = new List<int> {500, 750, 1000, 1250};

    // Select a random value from the list
    private int GetRandomSeconds()
    {
        return _randomSeconds[_random.Next(_randomSeconds.Count)];
    }
    private int GetRandomSecondsFast()
    {
        return _randomSecondsFast[_random.Next(_randomSeconds.Count)];
    }

    //Loading animation
    protected void Load()
    {
        int counter = 250;
        int count = 0;
        while (count < GetRandomSeconds())
        {
            Console.Write("|\b");
            Thread.Sleep(counter);
            Console.Write("/\b");
            Thread.Sleep(counter);
            Console.Write("-\b");
            Thread.Sleep(counter);
            Console.Write("\\\b");
            Thread.Sleep(counter);
            count += counter * 4;
            Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r"); // Clear the line
        }
    }
    protected void LoadFast()
    {
        int counter = 250;
        int count = 0;
        while (count < GetRandomSecondsFast())
        {
            Console.Write("|\b");
            Thread.Sleep(counter);
            Console.Write("/\b");
            Thread.Sleep(counter);
            Console.Write("-\b");
            Thread.Sleep(counter);
            Console.Write("\\\b");
            Thread.Sleep(counter);
            count += counter * 4;
            Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r"); // Clear the line
        }
    }
    //Begin timer
    protected void CountdownTimer()
    {
        Console.Write("You may begin in: ");
        Console.Write("9\b");
        Thread.Sleep(1000);
        Console.Write("8\b");
        Thread.Sleep(1000);
        Console.Write("7\b");
        Thread.Sleep(1000);
        Console.Write("6\b");
        Thread.Sleep(1000);
        Console.Write("5\b");
        Thread.Sleep(1000);
        Console.Write("4\b");
        Thread.Sleep(1000);
        Console.Write("3\b");
        Thread.Sleep(1000);
        Console.Write("2\b");
        Thread.Sleep(1000);
        Console.Write("1\b");
        Thread.Sleep(1000);
        Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r"); // Clear the line
        Console.WriteLine("You may begin in:\n");

        _duration = DateTime.Now.AddSeconds(_seconds);
    }

    //Clear the console
    public void Clear()
    {
        // Thread.Sleep(5000);
        Console.Clear();
    }
        //Display the activity message
    public string DisplayActivity()
    {
            // UserChoiceConvert();
            return $"Welcome to the {_activityList[_userChoice]} activity.\n";
    }
    //Get the user input
    public int GetUserInput(int input)
    {
        _userChoice = input - 1; // This will alloow the list to start at 1
        return _userChoice;
    }
    //Display closing activity message
    public void ClosingActivity()
    {
        Console.WriteLine("\nWell done!");
        Load();
        Console.WriteLine($"\nYou have completed another {_seconds} seconds of the {_activityList[_userChoice]} activity.");
        Load();
        Clear();
    }
    //Get the duration of the activity
    public DateTime GetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session ");
        int duration = int.Parse(Console.ReadLine());
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        _duration = futureTime;  // Store the end time
        _seconds = duration; // Store the duration
        // GetReady();
        return futureTime;
    }
    //Display get ready message
    public void GetReady()
    {
        Console.WriteLine("Get ready...");
        Load();
        Console.WriteLine();
    }
    //Start the activities
    public void Start()
    {
        GetDuration();
        Clear();
        GetReady();
    }

    public string borders(string prompt)
    {
        string border = new string('-', prompt.Length);
        Console.WriteLine("+" + border + "+");
        Console.WriteLine("|" + prompt + "|");
        // Allow user to indicate when they are ready
        Console.WriteLine("+" + border + "+\n");
        return border;
    }

}
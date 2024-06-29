public class Backend
{
    protected int _alreadyStarted = 0;

    //Save the game to a file
    protected string _fileName;

    //User stats memory
    protected List<string> _gameData = new List<string>();

    //Use the following to get key values from the game data
    // _gameData[0].Split(",")[0] --- Replace the second 0 
    // with the index of the value you want to get

    //Game stats
    protected string _playerName;
    protected int _playerScore;
    protected int _playerLevel;
    protected int _playerTime;
    protected int _fertilizer;
    protected int _water;
    protected int _weed;
    protected int _pests;
    protected int _disease;
    protected int _harvested;
    protected int _totalHarvested;
    protected int _totalWeed;
    protected int _totalPests;
    protected int _totalDisease;
    protected int _totalWater;
    protected int _totalFertilizer;
   
   //Menu options
    public void Start()
    {

        //Initiate the classes
        Yard yard = new Yard();

        //Clear terminal before starting the game
        ClearTerminal();

        Console.WriteLine("Game Started");

        int userChoice = 0;
        while (userChoice != 3)
        {
            //Clear the menu after an option has been chosen
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Take care of your grass");
            Console.WriteLine("2. Go to the store");
            Console.WriteLine("3. Quit");
            Console.Write("Select a choice from the memu: ");

            try
            {
                string userEntry = Console.ReadLine();
                userChoice = int.Parse(userEntry);
                Console.WriteLine();

                if (userChoice == 1)
                {
                    ClearTerminal();
                    yard.ShowYard();
                }
                else if (userChoice == 2)
                {
                    ClearTerminal();
                    Console.WriteLine("Go to the store");
                }
                else if (userChoice == 3)
                {
                    ClearTerminal();
                    Console.WriteLine("Pause");
                }
                else
                {
                    Console.WriteLine("The choice made was not one of the options. Please try again");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }

    public void LoadGame()
    {
        //Clear terminal before loading the game
        // ClearTerminal();
        _gameData.Clear();


        //Load the game data and save the data to be worked with
        LoadSavedGame();
        SaveGame();
        Start();

    }
    //Menu updates
    private void ClearTerminal()
    {
        Console.Clear();
    }
    public void NewGame()
    {
        //Clear terminal before starting a new game
        ClearTerminal();
        _gameData.Clear();
        // Initiate the polymorphic class to start the game
        Console.WriteLine("Welcome to the start of your grass growong adventure!");
        _alreadyStarted = 1;
        Console.Write($"What is your character's name? ");
        _playerName = Console.ReadLine();
        _playerScore = 0;
        _playerLevel = 1;
        _playerTime = 0;
        _fertilizer = 0;
        _water = 0;
        _weed = 0;
        _pests = 0;
        _disease = 0;
        _harvested = 0;
        _totalHarvested = 0;
        _totalWeed = 0;
        _totalPests = 0;
        _totalDisease = 0;
        _totalWater = 0;
        _totalFertilizer = 0;
        _gameData.Add($"{_playerName},{_playerScore},{_playerLevel},{_playerTime},{_alreadyStarted},{_fertilizer},{_water},{_weed},{_pests},{_disease},{_harvested},{_totalHarvested},{_totalWeed},{_totalPests},{_totalDisease},{_totalWater},{_totalFertilizer}");

        // Save the new game instance 
        LoadSavedGame();
        SaveGame();
        Start();
    }

    public void LoadSavedGame()
    {
        Progress update = null;
        update = new LoadGame();
        update.Update(_fileName, _gameData);
        _fileName = ((LoadGame)update)._dataSave;
        _alreadyStarted = ((LoadGame)update)._alreadyStartedChild;
        _gameData.AddRange(((LoadGame)update)._gameDataChild);
    }
    public void SaveGame()
    {
        Progress update = null;
        update = new SaveGame();
        update.Update(_fileName, _gameData);
    }
    public void ResetVariables()
    {
        _playerName = "";
        _playerScore = 0;
        _playerLevel = 1;
        _playerTime = 0;
        _fertilizer = 0;
        _water = 0;
        _weed = 0;
        _pests = 0;
        _disease = 0;
        _harvested = 0;
        _totalHarvested = 0;
        _totalWeed = 0;
        _totalPests = 0;
        _totalDisease = 0;
        _totalWater = 0;
        _totalFertilizer = 0;
    }
}
public class LoadGame : Progress
{
    //Variable to store the file name (This is needed to allow the parent class to access the file path)
    public string _dataSave;
    public int _alreadyStartedChild;
    public List<string> _gameDataChild = new List<string>();

    public override void Update(string _fileName, List <string> _gameData)
    {
        Console.WriteLine("LoadGame");

        //Reset the game Cache

        //Load the game data from the file
        Console.WriteLine($"Enter a desired save file name or press Enter to use the default file name. ");
        string _saveFile = Console.ReadLine();

        //Check for the save file
        if (string.IsNullOrEmpty(_saveFile))
        {
            _saveFile = "SaveGame.csv";
            _fileName = _saveFile;
        }
        else
        {
            _fileName = _saveFile + ".csv";
        }

        //Check if the file exists
        if (File.Exists(_fileName))
        {
            //Read the file
            string[] lines = File.ReadAllLines(_fileName);
            if (lines.Length > 1)
            {
                for (int i = 1; i < lines.Length; i++) // Skip the header
                {
                    _gameDataChild.Add(lines[i]);
                }
            }
            _alreadyStartedChild = 1;
        }
        else
        {
            //Create the file and close it
            File.Create(_fileName).Close();

            Console.WriteLine($"There was no exsisting save file named {_fileName}. A new save file has been created.");

            using (StreamWriter sw = File.AppendText(_fileName))
            {
                sw.WriteLine("Name,Score,Level,Time,AlreadyStarted,Fertilizer,Water,Weed,Pests,Disease,Harvested,TotalHarvested,TotalWeed,TotalPests,TotalDisease,TotalWater,TotalFertilizer");
            }
        }

        //Save the file path to be accessed in the parent class
        _dataSave = _fileName;

    }
}
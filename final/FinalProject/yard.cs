using System.Runtime.CompilerServices;

public class Yard
{

    //Initiate the Backend class
    Game backend = new Game();
    //Grass ASCII art
    private string _healthyGrass = @"
        v  v  v
    v v v v v
    v  v  v  v
    v  v  v  v  v
    v  v  v  v  v  v
    ";
    private string _soSoGrass = @"
        v  v
    v v  v
    v  v  v
    v  v  v  v
    v  v  v  v  v
    ";
    private string _deadGrass = @"
        v
    v v
    v  v
    v  v
    v  v
    ";
    //Yard values
public int[] _artChoices = new int[9];

private string _yardValuesToString;

        public string SaveYard(string test)
    {
        for (int i = 0; i < test.Length; i++)
        {
            _yardValuesToString += test[i].ToString() + ",";
        }
        return _yardValuesToString;
    }



    public void ShowYard()
    {
        Console.WriteLine("Yard");

        if (_artChoices.Length != 9)
        {
            throw new ArgumentException("Please provide exactly 9 values.");
        }

        // Convert integer choices to corresponding ASCII art
        string[][] chosenArts = new string[9][];
        for (int i = 0; i < 9; i++)
        {
            switch (_artChoices[i])
            {
                case 3:
                    chosenArts[i] = _healthyGrass.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    break;
                case 2:
                    chosenArts[i] = _soSoGrass.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    break;
                case 1:
                    chosenArts[i] = _deadGrass.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    break;
                default:
                    throw new ArgumentException("Values must be between 1 and 3.");
            }
        }

        // Print the 3x3 square
        string _fence = new string('-', 60);
        Console.WriteLine($"+{_fence}+");
        for (int row = 0; row < 3; row++)
        {
            for (int line = 0; line < chosenArts[0].Length; line++)
            {
                string resultLine = "";
                for (int col = 0; col < 3; col++)
                {
                    int index = row * 3 + col;
                    resultLine += chosenArts[index][line] + ""; // Add some spacing between segments
                }
                while (resultLine.Length < 60)
                {
                    resultLine += " ";
                }
                Console.WriteLine("|"+resultLine+"|");

            }
        }
        Console.WriteLine($"+{_fence}+");
    }
}
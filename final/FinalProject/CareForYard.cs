using System.ComponentModel.Design.Serialization;

public class CareForYard
{
    public CareForYard(List<string> _gameData)
    {
        //Split the second element of _gameData
        string[] yardValues = _gameData[0].Split(',');
        // Covert fertilizer to int
        int _fertilizer = int.Parse(yardValues[5]);
        int _water = int.Parse(yardValues[6]);

        //Index of the yard values setter
        int idx = -1;

        while (_fertilizer > 0 || _water > 0)
        {
            Console.WriteLine("You have " + _fertilizer + " fertilizer left.");
            Console.WriteLine("You have " + _water + " water left.");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Fertilize the grass");
            Console.WriteLine("2. Water the grass");
            Console.WriteLine("3. Return to the main menu");
            Console.Write("Select a choice from the menu: ");
            string userEntry = Console.ReadLine();
            int userChoice = int.Parse(userEntry);
            Console.WriteLine();

            if (userChoice == 1)
            {
                if (_fertilizer == 0)
                {
                    Console.WriteLine("You do not have enough fertilizer to care for your yard.");
                    break;
                }
                idx = 5;
                _fertilizer -= 1;
                int currentFertilizer = int.Parse(yardValues[5]);
                currentFertilizer -= 1;
                yardValues[5] = currentFertilizer.ToString();
                _gameData[0] = string.Join(",", yardValues);
                for (int i = 0; i < 2; i++)
                {
                    IncreaseHealth health = new IncreaseHealth(_gameData);
                }

                Console.WriteLine("You have successfully cared for your yard.");
            }
            else if (userChoice == 2)
            {
                if (_water == 0)
                {
                    Console.WriteLine("You do not have enough water to care for your yard.");
                    break;
                }
                idx = 6;
                _water -= 1;
                int currentWater = int.Parse(yardValues[6]);
                currentWater -= 1;
                yardValues[6] = currentWater.ToString();
                _gameData[0] = string.Join(",", yardValues);
                IncreaseHealth health = new IncreaseHealth(_gameData);
                Console.WriteLine("You have successfully cared for your yard.");
            }
            else if (userChoice == 3)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }    
    }
}
public class Store
{
    public Store(List<string> _gameData)
    {
        // Split the first element of _gameData
        string[] yardValues = _gameData[0].Split(',');
        Console.WriteLine("Welcome to the store!");

        string _storeASCII = @"
        ______________________________________________________
        |                                                    |
        |                       STORE                        |
        |____________________________________________________|
        |        _________                 _________         |
        |       |         |               |         |        |
        |       |  _____  |               |  _____  |        |
        |       | |     | |               | |     | |        |
        |       | |_____| |               | |_____| |        |
        |       |   Sale  |               |         |        |
        |       |_________|               |_________|        |
        |____________________________________________________|
        |        _________                 _________         |
        |       |         |               |         |        |
        |       |         |               |         |        |
        |       |_________|               |_________|        |
        |____________________________________________________|";
        Console.WriteLine(_storeASCII);
        Console.WriteLine($"You have ${yardValues[1]} and {yardValues[5]} fertilizer and {yardValues[6]} water.");

        if (int.Parse(yardValues[1]) == 0)
        {
            Console.WriteLine("You are out of money. You cannot buy anything.");
            return;
        }
        else 
        {
            while ((int.Parse(yardValues[1])) > 0)
            {
                Console.WriteLine("What would you like to buy?");
                Console.WriteLine("1. Fertilizer");
                Console.WriteLine("2. Water");
                Console.WriteLine("3. Exit");
                string userEntry = Console.ReadLine();
                int userChoice = int.Parse(userEntry);
                if (userChoice == 1)
                {
                    Console.WriteLine("How much fertilizer would you like to buy?");
                    string userEntryFertilizer = Console.ReadLine();
                    int userChoiceFertilizer = int.Parse(userEntryFertilizer);

                    while (userChoiceFertilizer * 20 > int.Parse(yardValues[1]))
                    {
                        Console.WriteLine("You do not have enough money to buy that much fertilizer.\n");
                        Console.Write("How much fertilizer would you like to buy? ");
                        userEntryFertilizer = Console.ReadLine();
                        userChoiceFertilizer = int.Parse(userEntryFertilizer);
                    }

                    int score = int.Parse(yardValues[1]);
                    score -= userChoiceFertilizer * 20;
                    yardValues[1] = score.ToString();
                    int fertilizer = int.Parse(yardValues[5]);
                    fertilizer += userChoiceFertilizer;
                    yardValues[5] = fertilizer.ToString();
                    Console.WriteLine($"You now have {yardValues[5]} fertilizer.");
                    break;
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("How much water would you like to buy?");
                    string userEntryWater = Console.ReadLine();
                    int userChoiceWater = int.Parse(userEntryWater);

                    while (userChoiceWater * 10 > int.Parse(yardValues[1]))
                    {
                        Console.WriteLine("You do not have enough money to buy that much water.\n");
                        Console.Write("How much water would you like to buy? ");
                        userEntryWater = Console.ReadLine();
                        userChoiceWater = int.Parse(userEntryWater);
                    }

                    int score = int.Parse(yardValues[1]);
                    score -= userChoiceWater * 10;
                    yardValues[1] = score.ToString();
                    int water = int.Parse(yardValues[6]);
                    water += userChoiceWater;
                    yardValues[6] = water.ToString();
                    Console.WriteLine($"You now have {yardValues[6]} water.");
                    break;
                }
                else if (userChoice == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The choice made was not one of the options. Please try again");
                }
            }
        }

        // Join the array back into a string
        _gameData[0] = string.Join(",", yardValues);
        return;
    }

}
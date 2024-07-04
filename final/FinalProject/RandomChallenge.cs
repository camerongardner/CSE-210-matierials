public class Challenge
{
    Random _random = new Random();

    //List to have the yard values saved into it
    //This is so 1 random yard value can change at a time
    private List<string> _changeYard = new List<string>();
    public Challenge(List<string> _gameData)
    {
        // Split the first element of _gameData
        string[] yardValues = _gameData[0].Split(',');

        //List random occurable challenges
        string[] _challengeOccured = {
            "Pests have invaded your yard. You must find a way to get rid of them.",
            "Your grass is dryinying out. You must find a way to revive it.",
            "Your grass is overgrown. You must find a way to cut it.",
        };

        if (_random.NextDouble() < 0.5)
        {
            // Subtract 1 from one of the yard values
                int idx = -1;
                while ((idx = _random.Next(yardValues[3].Length)) >= 0 && yardValues[3][idx] <= '1');
                yardValues[3] = yardValues[3].Remove(idx, 1).Insert(idx, (char)(yardValues[3][idx] - 1) + "");
                int _challengeChossen = _random.Next(_challengeOccured.Length);
                Console.WriteLine(_challengeOccured[_challengeChossen]);

                // Add 10 points to the score
                int score = int.Parse(yardValues[1]);
                score += 10;
                yardValues[1] = score.ToString();
                
        }

        // Join the array back into a string
        _gameData[0] = string.Join(",", yardValues);
        return;
    }
}

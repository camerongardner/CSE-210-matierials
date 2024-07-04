public class IncreaseHealth
{
    public IncreaseHealth(List<string> _gameData)
    {
        int idx = -1;
        Random _random = new Random();

        string[] yardValues = _gameData[0].Split(',');
            while ((idx = _random.Next(yardValues[3].Length)) >= 0 && yardValues[3][idx] == '3');
            yardValues[3] = yardValues[3].Remove(idx, 1).Insert(idx, (char)(yardValues[3][idx] + 1) + "");

            // Add 10 points to the score
                int score = int.Parse(yardValues[1]);
                score += 10;
                yardValues[1] = score.ToString();

            // Join the array back into a string
            _gameData[0] = string.Join(",", yardValues);
            Console.WriteLine("You have successfully cared for your yard.");
            return;
    }
}
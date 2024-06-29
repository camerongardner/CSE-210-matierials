public class SaveGame : Progress
{
    public override void Update(string _fileName, List<string> _gameData)
    {

        List<string> lines = new List<string>();

        if (File.Exists(_fileName))
        {
            lines = File.ReadAllLines(_fileName).ToList();
            if (lines.Count > 1)
            {
                // Replace the first data row with updated data
                lines[1] = _gameData[0];
            }
            else
            {
                // If there is only a header, add the new data row
                lines.Add(_gameData[0]);
                // lines.Add($"{_playerName},{_playerScore},{_playerLevel},{_playerTime},{_alreadyStarted},{_fertilizer},{_water},{_weed},{_pests},{_disease},{_harvested},{_totalHarvested},{_totalWeed},{_totalPests},{ _totalDisease},{_totalWater},{_totalFertilizer}");
            }
        }
        else
        {
            // If file doesn't exist, create it with a header and the new data row
            lines.Add("Name,Score,Level,Time,AlreadyStarted,Fertilizer,Water,Weed,Pests,Disease,Harvested,TotalHarvested,TotalWeed,TotalPests,TotalDisease,TotalWater,TotalFertilizer ");
            lines.Add($"{_playerName},{_playerScore},{_playerLevel},{_playerTime},{_alreadyStarted},{_fertilizer},{_water},{_weed},{_pests},{_disease},{_harvested},{_totalHarvested},{_totalWeed},{_totalPests},{ _totalDisease},{_totalWater},{_totalFertilizer}");
        }

        File.WriteAllLines(_fileName, lines);
    }
}
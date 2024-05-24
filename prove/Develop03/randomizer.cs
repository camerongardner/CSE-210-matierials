class Randomizer
{
    private Random _random;

    public Randomizer()
    {
        //Create a random instance so the words can be randomly selected
        _random = new Random();
    }

    //Get the scripture from the Scripture class
    public void HideRandomWord(Scripture scripture)
    {
        //Call the Word class to get the list of words that make up the scripture
        List<Word> words = scripture.GetWords();
        List<Word> visibleWords = words.Where(w => !w.IsHidden()).ToList();
        if (visibleWords.Count > 0)
        {
            //Select a random word to hide
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }
}
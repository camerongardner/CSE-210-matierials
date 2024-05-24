using System.Xml.XPath;

class Scripture
{
   private string _scripture;
   private string _reference;

   private List<Word> _words;

   public Scripture(string scripture, string reference)
   {
        _scripture = scripture;
        _reference = reference;
        //Split the words in the _scripture variable by a " " then add it to a list
        _words = _scripture.Split(' ').Select(word => new Word(word)).ToList();
        //Clean up formatting for when the scriptire is first displayed
        Console.WriteLine();
        Console.WriteLine($"{_reference} {_scripture}");
        Console.WriteLine();

   }
   //Return a list of words that make up the scripture to the Word class
   public List<Word> GetWords()
    {
        return _words;
    }
    public void Display()
    {
        Console.WriteLine($"{_reference} {string.Join(" ", _words.Select(w => w.GetText()))}");
    }
    public bool AllWordsHidden()
    {
        //Iterates through all the words in the scripture and returns true if all the words have been hidden
        return _words.All(w => w.IsHidden());
    }
}
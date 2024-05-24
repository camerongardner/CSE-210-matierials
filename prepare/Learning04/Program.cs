using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        List<int> hiddenIndices = new List<int>(); // To keep track of hidden word indices
        
        Random random = new Random();
        
        Console.WriteLine("Press Enter to hide a random word, or type 'exit' to quit.");
        
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
            {
                break;
            }
            
            int randomIndex;
            do
            {
                randomIndex = random.Next(words.Length);
            } while (hiddenIndices.Contains(randomIndex));
            
            hiddenIndices.Add(randomIndex);
            
            string modifiedSentence = ReplaceWordWithUnderscores(sentence, words, hiddenIndices);
            Console.WriteLine($"Modified sentence: {modifiedSentence}");
        }
    }
    
    static string ReplaceWordWithUnderscores(string sentence, string[] words, List<int> hiddenIndices)
    {
        string[] modifiedWords = (string[])words.Clone();
        foreach (int index in hiddenIndices)
        { 
            modifiedWords[index] = new string('_', words[index].Length);
        }
        
        return string.Join(' ', modifiedWords);
    }
}
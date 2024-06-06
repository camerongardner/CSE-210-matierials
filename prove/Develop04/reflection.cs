using System;

public class Reflection : Activities
{
    public void StartReflection()
    {
        GetUserInput(2);
        Clear();
        Console.WriteLine(DisplayActivity());
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your l ife.\n");
        Start();

        // Reflection prompts
        Random random = new Random();
        string[] prompts = {
            "Think about a time when you faced a difficult challenge and overcame it.",
            "Reflect on a moment when you showed kindness to someone.",
            "Consider a situation where you had to make a tough decision and explain how you handled it.",
            "Recall a time when you achieved a personal goal and describe the steps you took to reach it.",
            "Think about a mistake you made and what you learned from it.",
            "Reflect on a moment when you felt proud of yourself and explain why.",
            "Consider a time when you had to adapt to a new situation and describe how you managed it.",
            "Recall a moment when you helped someone else and how it made you feel.",
            "Think about a time when you received constructive feedback and explain how you used it to improve.",
            "Reflect on a situation where you had to work as part of a team and describe your role and contribution."
        };
        //Questions to guide answers to the prompts
        Random questionRandom = new Random();
        string[] questions = {
            "What was the situation?",
            "What challenges did you face?",
            "How did you feel during the experience?",
            "What did you learn from the situation?",
            "How did you grow as a result?",
            "What would you do differently next time?",
            "How can you apply what you learned to other areas of your life?"
        };

        int index = random.Next(prompts.Length);
        string prompt = prompts[index];
        string border = new string('-', prompt.Length);

        Console.WriteLine("+" + border + "+");
        Console.WriteLine("|" + prompt + "|");
        // Allow user to indicate when they are ready
        Console.WriteLine("+" + border + "+\n");
        Console.Write("When you are ready, press Enter to continue.\n");
        Console.ReadLine();

        Console.WriteLine("Reflect on the following questions to help guide your answers:\n");
        CountdownTimer();
        Clear();

        // Initialize the list of remaining questions outside the loop
        List<string> remainingQuestions = new List<string>(questions);

        while (DateTime.Now < _duration)
        {
            // Pick a random question from the remaining questions
            int index1 = questionRandom.Next(remainingQuestions.Count);
            string question = remainingQuestions[index1];
            Console.Write(question + " ");
            LoadFast();
            Console.WriteLine(question);


            // Remove the used question from the list
            remainingQuestions.RemoveAt(index1);

            // If all prompts have been used at least once, reset the list
            if (remainingQuestions.Count == 0)
            {
                remainingQuestions = new List<string>(questions);
            }

            // Add a delay to prevent the infinite loop
            Thread.Sleep(1); // Delay for 1 second
        }
        Console.WriteLine();
        ClosingActivity();



    }
}
public class Instructions
{
    private string _instructions = @"
 I  N   N  SSSS  TTTTT  RRRR   U   U   CCCC  TTTTT  III   OOO   N   N   SSSS
 I  NN  N  S       T    R   R  U   U  C        T     I   O   O  NN  N  S    
 I  N N N   SSS    T    RRRR   U   U  C        T     I   O   O  N N N   SSS 
 I  N  NN      S   T    R  R   U   U  C        T     I   O   O  N  NN      S
 I  N   N  SSSS    T    R   R   UUU    CCCC    T    III   OOO   N   N   SSSS";
    public Instructions()
    {
        Console.WriteLine(_instructions + "\n\n");

        TypeWrite("Welcome to the Yard Care Simulator!\n");
        TypeWrite("In this game, you will be tasked with taking care of your yard.\n");
        TypeWrite("You will do this by using resources that can be purchased at the store.\n");
        TypeWrite("These resources have different strengths and costs.\n");
        TypeWrite(" - Fertilizer is more expensive but has a greater effect on the yard.\n");
        TypeWrite(" - Water is cheaper but has a smaller effect on the yard.\n\n");
        TypeWrite("You will also encounter random challenges that will affect your yard.\n");
        TypeWrite("These challenges will occur at random times whenever you go to take care of your yard.\n\n");
        TypeWrite("The game will end if your yard is completely dead.\n");
        TypeWrite("Further, there is no end to the game it can go on forever.\n");
        TypeWrite(" ");

        static void TypeWrite(string message)
        {
            Random random = new Random();
            int delay = random.Next(25, 75); // Random delay between 25 and 75 milliseconds
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instances of the Fraction class
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(2, 4);

        Console.WriteLine("Hello Learning03 World!");
        
        // Print results
        Console.WriteLine(fraction1.Compute());
        Console.WriteLine(fraction2.Compute());
        Console.WriteLine(fraction3.Compute());
    }
}
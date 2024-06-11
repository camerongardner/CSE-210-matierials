using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Green", 5);
        Console.WriteLine("Color: " + square.GetColor());
        Console.WriteLine("Area: " + square.Area());

        Circle circle = new Circle("Purple", 2);
        Console.WriteLine("Color: " + circle.GetColor());
        Console.WriteLine("Area: " + circle.Area());

        Rectangle rectangle = new Rectangle("Red", 3, 4);
        Console.WriteLine("Color: " + rectangle.GetColor());
        Console.WriteLine("Area: " + rectangle.Area());

        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);

    }
}
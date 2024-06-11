public class Rectangle : Shape
{
    private double _width;
    private double _height;

    public Rectangle(string color, double width, double height) : base(color)
    {
        _width = width;
        _height = height;
    }

    public double GetWidth()
    {
        return _width;
    }

    public void SetWidth(double width)
    {
        _width = width;
    }

    public double GetHeight()
    {
        return _height;
    }

    public void SetHeight(double height)
    {
        _height = height;
    }

    public override double Area()
    {
        return _width * _height;
    }
}
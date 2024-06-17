using System;


abstract class Shape
{
    public abstract double GetArea();
}


class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}


class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);

        Console.WriteLine($"Area of the circle with radius {circle.Radius}: {circle.GetArea():F2}");
        Console.WriteLine($"Area of the rectangle with width {rectangle.Width} and height {rectangle.Height}: {rectangle.GetArea():F2}");
    }
}

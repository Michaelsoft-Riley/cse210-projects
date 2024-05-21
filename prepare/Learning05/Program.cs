using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square(3, "green"));
        shapes.Add(new Rectangle(3, 4, "orange"));
        shapes.Add(new Circle(3, "pink"));

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"Color: {color}   Area: {area}");
        }
    }
}
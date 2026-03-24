using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes= new List<Shape>();


        Square square = new Square("Yellow", 5);
        Rectangle rectangle = new Rectangle("Red", 7, 3);
        Circle circle = new Circle("Blue", 5);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()} shape has an area of {shape.GetArea()}");
        }
    }
}
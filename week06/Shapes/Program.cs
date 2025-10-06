using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>();
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Square square = new Square("Red", 3);
        Rectangle rectangle = new Rectangle("Blue", 4, 5);
        Circle circle = new Circle("Green", 6);
        shapeList.Add(square);
        shapeList.Add(rectangle);
        shapeList.Add(circle);

        foreach (Shape shape in shapeList)
        {
            Console.WriteLine(shape.getColor());
            Console.WriteLine(shape.getArea());
            Console.WriteLine();
        }
    }
}
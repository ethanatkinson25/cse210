using System;

public class Square : Shape
{
    private double _side;

    public Square(string color, double side)
    {
        _side = side;
        _color = color;
    }

    public override double getArea()
    {
        double area = _side * _side;
        return area;
    }
}
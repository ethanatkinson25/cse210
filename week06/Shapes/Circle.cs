using System;
using System.Formats.Asn1;

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius)
    {
        _radius = radius;
        _color = color;
    }

    public override double getArea()
    {
        double area = _radius * _radius * Math.PI;
        return area;
    }
}
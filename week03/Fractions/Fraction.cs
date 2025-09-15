using System;
using System.ComponentModel;

public class Fraction
{
    private double _numerator;
    private double _denominator;

    private string constructor1()
    {
        _numerator = 1;
        _denominator = 1;
        return $"{_numerator} / {_denominator}";
    }

    private string constructor2(int passedVar = 5)
    {
        _numerator = passedVar;
        _denominator = 1;
        return $"{_numerator} / {_denominator}";
    }

    private string constructor3(int passedNum = 3, int passedDenom = 4)
    {
        _numerator = passedNum;
        _denominator = passedDenom;
        return $"{_numerator} / {_denominator}";
    }

    public void printconstructors()
    {
        Console.WriteLine(constructor1());
        Console.WriteLine(constructor2());
        Console.WriteLine(constructor3());
    }

    public double getNumerator()
    {
        return _numerator;
    }

    public double getDenominator()
    {
        return _denominator;
    }

    public string getFractionString()
    {
        return constructor3();

    }

    public double getDecimalValue()
    {
        double result = _numerator / _denominator;
        return result;
    }
}
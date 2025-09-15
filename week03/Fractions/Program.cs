using System;

class Program
{
    static void Main(string[] args)
    {
        var fraction = new Fraction();

        fraction.printconstructors();
        Console.WriteLine();
        Console.WriteLine(fraction.getNumerator());
        Console.WriteLine(fraction.getDenominator());

        Console.WriteLine();
        Console.WriteLine(fraction.getFractionString());
        Console.WriteLine(fraction.getDecimalValue());
    }
}
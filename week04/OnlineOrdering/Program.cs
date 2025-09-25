using System;

class Program
{
    static void Main(string[] args)
    {
        var firstOrder = new Order();
        var secondOrder = new Order();

        firstOrder.printShippingLabel();
        Console.WriteLine("First Order:");
        firstOrder.printPackingLabel();
        Console.WriteLine();
        Console.WriteLine();
        secondOrder.printShippingLabel();
        Console.WriteLine("Second Order:");
        secondOrder.printPackingLabel();
    }
}
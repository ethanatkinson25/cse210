using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a numbet to add it to the list.Type 0 to end list.");
        Console.WriteLine();
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        int newNumber = int.Parse(input);
        int count = 1;
        int sum = newNumber;
        int greatest = newNumber;

        while (newNumber != 0)
        {
            Console.Write("Enter a number: ");
            input = Console.ReadLine();
            newNumber = int.Parse(input);
            numbers.Add(newNumber);
            count = count + 1;
            sum = sum + newNumber;
        }

        foreach (int number in numbers)
        {
            if (number > greatest)
            {
                greatest = number;
            }
        }

        float average = sum / count;
        Console.WriteLine($"The total sum is: {sum}");
        Console.WriteLine($"The average of the list is: {average}");
        Console.WriteLine($"The greatest number in your list is: {greatest}");
        Console.WriteLine($"The total amount of items in your list is: {count} items");
    }
}
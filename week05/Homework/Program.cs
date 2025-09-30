using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Ethan", "Science");
        MathAssignment mathAssignment = new MathAssignment("Ethan", "Math", "Section 5", "1-10");
        WritingAssignment writingAssignment = new WritingAssignment("Ethan", "English", "A Guide to a Well Written Essay");

        Console.WriteLine(assignment.getSummary());
        Console.WriteLine();
        Console.WriteLine(mathAssignment.getSummary());
        Console.WriteLine(mathAssignment.getHomeworkList());
        Console.WriteLine();
        Console.WriteLine(writingAssignment.getSummary());
        Console.WriteLine(writingAssignment.getWritingInfo());
    }
}
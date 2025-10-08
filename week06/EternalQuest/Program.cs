using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goalList = new List<Goal>();
        string input = "";
        int totalPoints = 0;
        Console.WriteLine("Welcome to the Eternal Quest Program!");
        Console.WriteLine();
        Console.WriteLine();

        while (input != "5")
        {
            Console.Clear();
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.Write("> ");
            Console.WriteLine();

            if (input == "1")
            {
                input = "";
                Console.Clear();
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("1. Simple goals");
                Console.WriteLine("2. Eternal goals");
                Console.WriteLine("3. Checklist goals");
                Console.Write("> ");
                Console.WriteLine();
                if (input == "1")
                {
                    string goalName = "";
                    string description = "";
                    string pointsString = "";
                    int points = 0;
                    SimpleGoal simpleGoal = new SimpleGoal();

                    Console.WriteLine("What do you want the name of your goal to be?");
                    Console.Write("> ");
                    goalName = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Write a short description of what you want to do to acheive this goal:");
                    Console.Write("> ");
                    description = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("How many points should this goal be worth?");
                    Console.Write("> ");
                    pointsString = Console.ReadLine();
                    points = int.Parse(pointsString);

                    simpleGoal.setGoalName(goalName);
                    simpleGoal.setGoalDescription(description);
                    simpleGoal.setPoints(points);
                    goalList.Add(simpleGoal);
                }
                else if (input == "2")
                {
                    string goalName = "";
                    string description = "";
                    string pointsString = "";
                    int points = 0;
                    EternalGoal eternalGoal = new EternalGoal();

                    Console.WriteLine("What do you want the name of your goal to be?");
                    Console.Write("> ");
                    goalName = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Write a short description of what you want to do to acheive this goal:");
                    Console.Write("> ");
                    description = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("How many points should this goal be worth every time you complete it?");
                    Console.Write("> ");
                    pointsString = Console.ReadLine();
                    points = int.Parse(pointsString);

                    eternalGoal.setGoalName(goalName);
                    eternalGoal.setGoalDescription(description);
                    eternalGoal.setPoints(points);
                    goalList.Add(eternalGoal);
                }
                else if (input == "3")
                {
                    string goalName = "";
                    string description = "";
                    string pointsString = "";
                    int points = 0;
                    string completionString = "";
                    int completions = 0;
                    ChecklistGoal checklistGoal = new ChecklistGoal();

                    Console.WriteLine("What do you want the name of your goal to be?");
                    Console.Write("> ");
                    goalName = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Write a short description of what you want to do to acheive this goal:");
                    Console.Write("> ");
                    description = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("How many points should this goal be worth?");
                    Console.Write("> ");
                    pointsString = Console.ReadLine();
                    points = int.Parse(pointsString);
                    Console.WriteLine("How many times should you complete this goal?");
                    Console.Write("> ");
                    completionString = Console.ReadLine();
                    completions = int.Parse(pointsString);

                    checklistGoal.setGoalName(goalName);
                    checklistGoal.setGoalDescription(description);
                    checklistGoal.setPoints(points);
                    checklistGoal.setCompletionAmount(completions);
                    goalList.Add(checklistGoal);
                }
                else
                {
                    Console.WriteLine("Please enter a valid input.");
                }
            }
            else if (input == "2")
            {
                int itemCount = 0;
                foreach (Goal goal in goalList)
                {
                    itemCount += 1;
                    Console.WriteLine($"{itemCount}. {goal.getGoalName()}: {goal.getGoalDescription()} \nCompleted: {goal.IsComplete()}");
                    Console.WriteLine();
                }
            }
            else if (input == "3")
            {

            }
            else if (input == "4")
            {

            }
            else if (input == "5")
            {

            }
            else if (input == "6")
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid input.");
            }
        }
    }
}
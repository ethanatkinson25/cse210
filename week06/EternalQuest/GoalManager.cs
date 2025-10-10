using System;
using System.IO; 

public class GoalManager {
    private List<Goal> goalList = new List<Goal>();
    private string _input;
    private int _totalPoints;



    public void start()
    {
        _input = "";
        while (_input != "5")
        {
            // Console.Clear();
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.Write("> ");
            _input = Console.ReadLine();

            if (_input == "1")
            {
                createGoal();
            }
            else if (_input == "2")
            {
                displayGoalList();
            }
            else if (_input == "3")
            {
                saveGoal();
            }
            else if (_input == "4")
            {
                loadGoal();
            }
            else if (_input == "5")
            {
                markGoal();
            }
            else if (_input == "6")
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid input.");
            }
        }
    }

    public void createGoal()
    {
        _input = "";
        // Console.Clear();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple goals");
        Console.WriteLine("2. Eternal goals");
        Console.WriteLine("3. Checklist goals");
        Console.Write("> ");
        _input = Console.ReadLine();
        if (_input == "1")
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
        else if (_input == "2")
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
        else if (_input == "3")
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

    public void displayGoalList()
    {
        int itemCount = 0;
        foreach (Goal goal in goalList)
        {
            itemCount += 1;
            Console.WriteLine($"{itemCount}. {goal.getGoalName()}: {goal.getGoalDescription()} \nCompleted: {goal.IsComplete()}");
            Console.WriteLine();
        }
        Console.WriteLine("Goals saved!");
    }

    public void saveGoal()
    {
        string filename = "C:/Users/threa/OneDrive/Documents/Projects/cse210/week06/EternalQuest/goals.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            int itemCount = 0;
            foreach (Goal goal in goalList)
            {
                itemCount += 1;
                outputFile.WriteLine($"{itemCount}. {goal.getGoalName()}: {goal.getGoalDescription()} \nCompleted: {goal.IsComplete()}~");
            }
            
        }
    }


    public void loadGoal()
    {
        string filename = "C:/Users/threa/OneDrive/Documents/Projects/cse210/week06/EternalQuest/goals.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        for (int line = 0; line < lines.Length; line++)
        {
            string[] parts = lines[line].Split("~");

            foreach (string str in parts)
            {
                Console.WriteLine(str);
            }
        }
    }

    public void displayPoints()
    {
        
    }
    
    public void markGoal()
    {
        
    }
}
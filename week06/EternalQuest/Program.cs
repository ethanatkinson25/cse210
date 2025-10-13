// I added a level system to the program. For every 100 points you earn, you increase your level
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalMenu = new GoalManager();

        goalMenu.start();
    }
}
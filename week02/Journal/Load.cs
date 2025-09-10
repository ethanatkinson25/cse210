using System;
using System.Text;
public class Load
{
    //This object will allow the user to save their entries onto a txt file, display enteries, and pull saved entries from the txt file
    private readonly IReadOnlyList<Entry> _entries;
    private readonly Entry entry;

    public Load(IReadOnlyList<Entry> entries)
    {
        _entries = entries;

    }

    
    public string GetTempSave()
    {
        var builder = new StringBuilder();
        foreach (var item in _entries)
        {
            builder.Append(item.Simplify());
            builder.Append("| ");
        }
        string result = builder.ToString().TrimEnd(' ', '|');
        return result;
    }

    public void Display()
    {
        string input = GetTempSave();
        var parts = new List<string>(input.Split("|"));
        Console.WriteLine();
        if (input.Count() == 0)
        {
            Console.WriteLine("Your journal is empty! Try making your first entry by selecting option 1!");
            Console.WriteLine();
        }
        else
        {
            for (int i = 0; i < parts.Count; i++)
            {
                Console.WriteLine($"{parts[i]} \n");
            }
        }
        
    }
}
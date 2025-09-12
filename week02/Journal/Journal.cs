using System;
using System.Text;

public class Journal
{
    public List<Entry> _entryList = new List<Entry>();
    public IReadOnlyList<Entry> Entries => _entryList;
    private static PromptGenerator _promptObj = new PromptGenerator();
    public string generatedPrompt;
    public string _entry;


    public string WritePrompt()
    {
        generatedPrompt = _promptObj.QuestionsListDefault();
        Console.WriteLine(generatedPrompt);
        Console.WriteLine();
        _entry = Console.ReadLine();
        return _entry;

    }
    public void TempSaveEntry()
    {
        var newEntry = new Entry(generatedPrompt, _entry);
        _entryList.Add(newEntry);

    }

    public string GetTempSave()
    {
        var builder = new StringBuilder();
        foreach (var item in _entryList)
        {
            builder.Append(item.Simplify());
            builder.AppendLine();
        }
        string result = builder.ToString();
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
                Console.WriteLine($"{parts[i]}" + "\n");
                Console.WriteLine();
            }
        }

    }

    public void SaveFile()
    {
        Console.WriteLine("What file would you like to save to?");
        Console.WriteLine();
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename, append: true))
        {
            outputFile.WriteLine(GetTempSave());
            Console.WriteLine("Saving to: " + Path.GetFullPath(filename));
        }
    }

    public void LoadFile()
    {
        Console.WriteLine("What file would you like to load from?");
        Console.WriteLine();
        string filename = Console.ReadLine();
        Console.WriteLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("\n");
            string totalEntry = parts[0].Trim();
            Console.WriteLine(totalEntry);
        }
        
        Console.WriteLine();
        Console.WriteLine("Loaded from: " + Path.GetFullPath(filename));
        
    }
    
}
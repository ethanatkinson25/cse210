using System;
using System.Net;

public class Write
{
    //This object will allow the user to write, temporary save, and display the enteries that are made in the journal.txt file

    public List<string> _questions = new List<string>();
    public  List<string> _entryList = new List<string>();
    public string _prompt;
    public string _entry;
    public int _previousPrompt;
    public int _status;


    public string QuestionsListDefault()
    {
        
        var write1 = new Write();
        write1._questions.Add("What will you remember from today?");
        write1._questions.Add("Who was the most interesting person I interacted with today?");
        write1._questions.Add("What did you eat today?");
        write1._questions.Add("When do you feel was the peak of your day?");
        write1._questions.Add("What went well today? What didn't go well?");
        write1._questions.Add("What are you looking forward to at the moment?");
        write1._questions.Add("Where did your day take you?");
        write1._questions.Add("How do you think today will help you tomorrow?");
        write1._questions.Add("Why is your current lifestyle satisfactory? If it isn’t, why not?");
        write1._questions.Add("Who has done a recent act of kindness for you? Who can you do a random act of kindness to today?");
        write1._questions.Add("When was the last time you were genuinely curious?");
        write1._questions.Add("What is today's motto for you?");
        write1._questions.Add("What sounds like the perfect vacation?");


        var random = new Random();
        int index = random.Next(write1._questions.Count);
        _prompt = write1._questions[index];
        if (_previousPrompt == index)
        {
            _status = 1;
            while (_status == 1)
            {
                random = new Random();
                index = random.Next(write1._questions.Count);
                _prompt = write1._questions[index];
                if (index != _previousPrompt)
                {
                    break;
                }
            }
        }
        _previousPrompt = index;
        return _prompt;
        
    }
    public string write()
    {
        
        _prompt = QuestionsListDefault();
        Console.WriteLine(_prompt);
        Console.WriteLine();
        _entry = Console.ReadLine();
        return _entry;

    }

    public void TemporarySave()
    {
        string tempSavedEntry = _entry;
        string tempSavedPrompt = _prompt;
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        string savedTotal = $"Date: {dateText} Prompt: {tempSavedPrompt} \n  Entry: {tempSavedEntry} ";
        _entryList.Add(savedTotal);
    }

    public string GetTempSave()
    {
        string result = String.Join("| ", _entryList);
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
using System;

public class Journal
{
    //This class will give the user a prompt, take in the entry, temporarily save it in an object list, and run the Load object to save entries onto a txt file
    public List<string> _questions = new List<string>();
    public List<Entry> _entryList = new List<Entry>();
    public IReadOnlyList<Entry> Entries => _entryList;

    public string _prompt;
    public int _previousPrompt;
    public int _status;
    public string _entry;

    public string QuestionsListDefault()
    {
        _questions.Add("What will you remember from today?");
        _questions.Add("Who was the most interesting person I interacted with today?");
        _questions.Add("What did you eat today?");
        _questions.Add("When do you feel was the peak of your day?");
        _questions.Add("What went well today? What didn't go well?");
        _questions.Add("What are you looking forward to at the moment?");
        _questions.Add("Where did your day take you?");
        _questions.Add("How do you think today will help you tomorrow?");
        _questions.Add("Why is your current lifestyle satisfactory? If it isn’t, why not?");
        _questions.Add("Who has done a recent act of kindness for you? Who can you do a random act of kindness to today?");
        _questions.Add("When was the last time you were genuinely curious?");
        _questions.Add("What is today's motto for you?");
        _questions.Add("What sounds like the perfect vacation?");


        var random = new Random();
        int index = random.Next(_questions.Count);
        _prompt = _questions[index];
        if (_previousPrompt == index)
        {
            _status = 1;
            while (_status == 1)
            {
                random = new Random();
                index = random.Next(_questions.Count);
                _prompt = _questions[index];
                if (index != _previousPrompt)
                {
                    break;
                }
            }
        }
        _previousPrompt = index;
        return _prompt;

    }
    
    public string WritePrompt()
    {
        _prompt = QuestionsListDefault();
        Console.WriteLine(_prompt);
        Console.WriteLine();
        _entry = Console.ReadLine();
        return _entry;

    }
    public void TempSaveEntry()
    {
        var newEntry = new Entry(_prompt, _entry);
        _entryList.Add(newEntry);
        
    }

}
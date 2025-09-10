using System;

public class Entry
{

    //This class will store the entry that was recently made until another object uses it
    //This object will allow the user to write entries and add them to the journal object
    public string _prompt { get; }
    public string _entry { get; private set; }
    public DateTime _date { get; }

    public Entry(string prompt, string text)
    {
        _date = DateTime.Now;
        _prompt = prompt;
        _entry = text;
    }



    public string Simplify()
    {
        // string tempSavedEntry = _entry;
        // string tempSavedPrompt = _prompt;
        // DateTime theCurrentTime = DateTime.Now;
        // string dateText = theCurrentTime.ToShortDateString();
        string savedTotal = $"Date: {_date} Prompt: {_prompt} \n  Entry: {_entry} ";
        return savedTotal;
    }

    
}

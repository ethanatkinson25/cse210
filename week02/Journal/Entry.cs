using System;

public class Entry
{
    private string _prompt;
    private string _entry;
    private DateTime _date;

    public Entry(string prompt, string text)
    {
        _date = DateTime.Now;
        _prompt = prompt;
        _entry = text;
    }



    public string Simplify()
    {
        string savedTotal = $"Date: {_date} Prompt: {_prompt} \n  Entry: {_entry} \n";
        return savedTotal;
    }

}

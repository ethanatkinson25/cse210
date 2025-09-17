using System;

public class Word
{
    // Tracks a single word and stores the status of it is hidden or not
    // The word class is responsible for storing its own shown/hidden state

    private string _storedWord;
    private bool _hiddenStatus = false;

    public string getStoredWord()
    {
        return _storedWord;
    }

    public bool changeHiddenStatus()
    {
        _hiddenStatus = true;
        return true;
    }
}
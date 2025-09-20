using System;

public class Word
{

    private string _storedWord;
    private bool _hiddenStatus = false;

    public Word(string word)
    {
        _storedWord = word;
    }

    public void getStoredWord()
    {
        if (_hiddenStatus == true)
        {
            hide();
        }
        else
        {
            Console.Write($"{_storedWord} ");
        }
    }

    public bool changeHiddenStatus()
    {
        _hiddenStatus = true;
        return true;
    }

    public void hide()
    {
        for (int j = 0; j < _storedWord.Length; j++)
        {
            char changedChar = _storedWord[j];
            changedChar = '_';
            Console.Write(changedChar);
        }
        Console.Write(" ");
    }

    public bool getHiddenStatus()
    {
        if (_hiddenStatus == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
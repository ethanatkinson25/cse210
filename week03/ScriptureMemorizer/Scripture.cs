using System;
using Microsoft.VisualBasic;

public class Scripture
{

    private List<Word> _wordList = new List<Word>();
    private Reference _reference = new Reference();

    public void printFullScripture()
    {
        string scriptureRef = $"{_reference.getVerseRef()}\n";
        Console.WriteLine(scriptureRef);
        Console.WriteLine();
        foreach (Word storedWord in _wordList)
        {
            storedWord.getStoredWord();
        }
    }

    public void breakVerse()
    {
        string unbrokenVerse = _reference.getVerseText();
        if (unbrokenVerse.Contains('\n'))
        {
            string[] verses = unbrokenVerse.Split("\n");
            string verse1 = verses[0];
            string verse2 = verses[1];

            string[] wordsInVerse = verse1.Split(' ');
            string[] wordsInVerse2 = verse2.Split(' ');
            foreach (string word in wordsInVerse)
            {
                Word wordObj = new Word(word);
                _wordList.Add(wordObj);
            }
            foreach (string word in wordsInVerse2)
            {
                Word wordObj = new Word(word);
                _wordList.Add(wordObj);
            }
        }
        else
        {
            string[] wordsInVerse = unbrokenVerse.Split(' ');
            foreach (string word in wordsInVerse)
            {
                Word wordObj = new Word(word);
                _wordList.Add(wordObj);
            }
        }
    }

    public void hideWord()
    {
        Random random = new Random();
        Word hiddenWord;

        do
        {
            int randomIndex = random.Next(_wordList.Count);
            hiddenWord = _wordList[randomIndex];
        } while (hiddenWord.getHiddenStatus());

        hiddenWord.changeHiddenStatus();
        for (int i = 0; i < _wordList.Count; i++)
        {
            if (_wordList[i].getHiddenStatus() == hiddenWord.getHiddenStatus())
            {
                if (hiddenWord.getHiddenStatus() == true)
                {
                    hiddenWord.hide();
                }
                else if (hiddenWord.getHiddenStatus() == false)
                {
                    continue;
                }
            }
        }
    }

    public bool isCompletelyHidden()
    {
        for (int i = 0; i < _wordList.Count; i++)
        {
            if (_wordList[i].getHiddenStatus() == false)
            {
                return false;
            }
        }
        return true;
    }
}
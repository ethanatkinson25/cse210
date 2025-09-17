using System;
using Microsoft.VisualBasic;

public class Scripture
{
    // Clear the console screen and display the complete scripture, including the reference and the text.
    // Provide multiple constructors for the scripture reference to handle the case of a single verse and a verse range ("Proverbs 3:5" or "Proverbs 3:5-6").
    // Tells each word object if it is hidden or not
    // Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.

    private List<Word> _wordList = new List<Word>();
    private Reference _reference = new Reference();
    // private Word _word = new Word();
    private int _hideStatus;

    public string printFullScripture()
    {
        breakVerse();
        string fullScripture = $"{_reference.getBook()} {_reference.getChapter()} {_reference.getVerseRef()}\n";

        return fullScripture;
    }

    public string printWordList()
    {
        foreach (Word storedWord in _wordList)
        {
            Console.Write($"{storedWord.getStoredWord()} ");
        }
        return "";
    }

    private void breakVerse()
    {
        string unbrokenVerse = _reference.getVerseText();
        string[] verses = unbrokenVerse.Split("\n");
        string verse1 = verses[0];
        string verse2 = verses[1];

        // Split string, create objects for each word, add word objects to _wordList
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

    public void hideWord()
    {
        // Randomly select a word to hide in the _wordList
        Random random = new Random();
        int randomIndex = random.Next(_wordList.Count);

        Word hiddenWord = _wordList[randomIndex];
        hiddenWord.changeHiddenStatus();
        _hideStatus = 1;
        // Turn the characters of the word into _
        for (int i = 0; i < _wordList.Count; i++)
        {
            if (_wordList[i].getStoredWord() == hiddenWord.getStoredWord())
            {
                for (int j = 0; j < hiddenWord.getStoredWord().Length; j++)
                {
                    char changedChar = hiddenWord.getStoredWord()[j];
                    changedChar = '_';
                    Console.Write(changedChar +" ");
                }
            }
        }
    }
}
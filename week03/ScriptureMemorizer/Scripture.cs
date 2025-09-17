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
    private Word _word = new Word();
    private int _hideStatus;

    public string printFullScripture()
    {
        string fullScripture = $"{_reference.getBook()} {_reference.getChapter()} {_reference.getVerseRef()} {_reference.getVerseText()}";

        return fullScripture;
    }

    public void breakVerse()
    {
        string unbrokenVerse1, unbrokenVerse2 = _reference.getVerseText();
        // Split string, create objects for each word, add word objects to _wordList
    }

    public void hideWord()
    {
        bool hide = _word.changeHiddenStatus();
    }
}
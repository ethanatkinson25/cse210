using System;

public class Reference
{
    // Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".
    // Keeps track of the book, chapter, and verse information.

    private Word _word = new Word();
    private string _book;
    private string _chapter;
    private string _verseRef;
    private string _verseText;

    public Reference()
    {
        _book = "Alma";
        _chapter = "32:";
        _verseRef = "26-27";
        _verseText = "Now, as I said concerning faith—that it was not a perfect knowledge—even so it is with my words. Ye cannot know of their surety at first, unto perfection, any more than faith is a perfect knowledge. ~ But behold, if ye will awake and arouse your faculties, even to an experiment upon my words, and exercise a particle of faith, yea, even if ye can no more than desire to believe, let this desire work in you, even until ye believe in a manner that ye can give place for a portion of my words.";

        // 26 "Now, as I said concerning faith—that it was not a perfect knowledge—even so it is with my words. Ye cannot know of their surety at first, unto perfection, any more than faith is a perfect knowledge.";
        // 27 But behold, if ye will awake and arouse your faculties, even to an experiment upon my words, and exercise a particle of faith, yea, even if ye can no more than desire to believe, let this desire work in you, even until ye believe in a manner that ye can give place for a portion of my words."
    }

    public string getVerseRef()
    {
        return _verseRef;
    }

    public string getVerseText()
    {
        string[] verses = _verseText.Split("~");
        string verse1 = verses[0];
        string verse2 = verses[1];
        return verse1 + " " + verse2;
    }

    public string getBook()
    {
        return _book;
    }

    public string getChapter()
    {
        return _chapter;
    }
}
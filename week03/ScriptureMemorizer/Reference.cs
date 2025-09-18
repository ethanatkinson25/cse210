using System;

public class Reference
{
    // Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".
    // Keeps track of the book, chapter, and verse information.

    private string _book;
    private string _chapter;
    private string _verseRef;
    private string _verseText;

    public Reference()
    {
        _book = "Alma";
        _chapter = "32:";
        _verseRef = "26-27";
        _verseText = "Now, as I said concerning faith—that it was not a perfect knowledge—even so it is with my words. Ye cannot know of their surety at first, unto perfection, any more than faith is a perfect knowledge.\n But behold, if ye will awake and arouse your faculties, even to an experiment upon my words, and exercise a particle of faith, yea, even if ye can no more than desire to believe, let this desire work in you, even until ye believe in a manner that ye can give place for a portion of my words.";

        // Add a couple other verses for the user to work with
    }

    public string getVerseRef()
    {
        string totalRef = $"{_book} {_chapter} {_verseRef}";
        return totalRef;
    }

    public string getVerseText()
    {
        
        return _verseText;
    }
}
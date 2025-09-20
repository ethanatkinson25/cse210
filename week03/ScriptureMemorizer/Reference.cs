using System;

public class Reference
{

    private string _book;
    private string _chapter;
    private string _verseRef;
    private string _verseText;
    private List<(string book, string chapter, string verseRef, string verseText)> _scriptures = new List<(string, string, string, string)>
    {
        ("Alma", "32:", "26-27", "Now, as I said concerning faith—that it was not a perfect knowledge—even so it is with my words. Ye cannot know of their surety at first, unto perfection, any more than faith is a perfect knowledge.\n But behold, if ye will awake and arouse your faculties, even to an experiment upon my words, and exercise a particle of faith, yea, even if ye can no more than desire to believe, let this desire work in you, even until ye believe in a manner that ye can give place for a portion of my words."),
        ("Jacob", "6:", "12", "O be wise; what can I say more?"),
        ("1 Nephi", "3:", "7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
        ("Omni", "1:", "26", "And now, my beloved brethren, I would that ye should come unto Christ, who is the Holy One of Israel, and partake of his salvation, and the power of his redemption. Yea, come unto him, and offer your whole souls as an offering unto him, and continue in fasting and praying, and endure to the end; and as the Lord liveth ye will be saved."),
        ("Helaman", "5:", "50", "And it came to pass that they did go forth, and did minister unto the people, declaring throughout all the regions round about all the things which they had heard and seen, insomuch that the more part of the Lamanites were convinced of them, because of the greatness of the evidences which they had received."),
    };
    public Reference()
    {
        getRandomScripture();
    }

    private void getRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        var selectedScripture = _scriptures[index];
        _book = selectedScripture.book;
        _chapter = selectedScripture.chapter;
        _verseRef = selectedScripture.verseRef;
        _verseText = selectedScripture.verseText;
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
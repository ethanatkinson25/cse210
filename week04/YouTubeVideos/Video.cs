using System;

class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _commentsList = new List<Comment>();


    public Video()
    {
        Random random = new Random();
        string[] titleSelection = {
            "I drove the fastest car in the world!",
            "The best game you've never heard of...",
            "The Future is now",
            "How I discovered Arch Linux",
            "How to create the best C# program",
            "Is AI big brain???",
            "Windows or Linux",
            "Top 10 epic moments of all time (must watch)",
            "Man eats cheeseburger, discoveres something epic"
        };

        string[] authorSelection = {
            "BYU Central",
            "James James",
            "TheEpicReviewer",
            "LinuxFan",
            "KeyBoard Wizard",
            "ContentLIVE"
        };

        int[] lengthSelection = { 1200, 600, 1800, 1500, 30, 5, 480 };

        _title = titleSelection[random.Next(titleSelection.Length)];
        _author = authorSelection[random.Next(authorSelection.Length)];
        _lengthInSeconds = lengthSelection[random.Next(lengthSelection.Length)];

        promptCommentGeneration();
    }

    private void promptCommentGeneration()
    {
        Random random = new Random();
        int numbnerOfComments = random.Next(4, 5);
        for (int i = 0; i < numbnerOfComments; i++)
        {
            var singleComment = new Comment();
            _commentsList.Add(singleComment);
        }
    }

    private int getNumberOfComments()
    {
        int commentCount = 0;
        foreach (var comment in _commentsList)
        {
            commentCount = commentCount + 1;
        }
        return commentCount;
    }

    public void promptPrintComment()
    {
        foreach (var comment in _commentsList)
        {
            comment.displayComment();
            Console.WriteLine();
        }
    }

    public void printVideoInfo()
    {
        Console.WriteLine($"Video Stats: \n{_title} \n{_author} \n{_lengthInSeconds} seconds \n Number of comments: {getNumberOfComments()}");
    }
}
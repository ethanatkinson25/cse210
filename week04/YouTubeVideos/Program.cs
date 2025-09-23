using System;

class Program
{
    static void Main(string[] args)
    {
        var firstVideo = new Video();
        var secondVideo = new Video();
        var thirdVideo = new Video();

        List<Video> videoList = new List<Video>();

        videoList.Add(firstVideo);
        videoList.Add(secondVideo);
        videoList.Add(thirdVideo);

        foreach (var video in videoList)
        {
            video.printVideoInfo();
            Console.WriteLine();
            Console.WriteLine();
            video.promptPrintComment();
        }
    }
}
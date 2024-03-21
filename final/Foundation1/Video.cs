public class Video
{
    private string _videoTitle;
    private string _videoLength;
    private string _videoAuthor;
    public void videos()
    {
        Video video = new Video();
        video._videoAuthor = "Tylar Hill";
        video._videoTitle = "Minecraft lets play";
        video._videoLength = "33:00";
        Console.WriteLine($"{video._videoAuthor} - {video._videoTitle} - {video._videoLength}");

        Video video1 = new Video();
        video._videoAuthor = "Sadie Hanney";
        video._videoTitle = "Making a pot in ceramic";
        video._videoLength = "5:32";
        Console.WriteLine($"{video1._videoAuthor} - {video1._videoTitle} - {video1._videoLength}");

        Video video2 = new Video();
        video._videoAuthor = "Kylie McNiff";
        video._videoTitle = "Art";
        video._videoLength = "77:77";
        Console.WriteLine($"{video2._videoAuthor} - {video2._videoTitle} - {video2._videoLength}");

        Video video3 = new Video();
        video._videoAuthor = "Ashley Widison";
        video._videoTitle = "Flat Earth";
        video._videoLength = "7:11";
        Console.WriteLine($"{video3._videoAuthor} - {video3._videoTitle} - {video3._videoLength}");

    }
    
}
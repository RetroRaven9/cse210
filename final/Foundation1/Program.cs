using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static List<Video> videos = new List<Video>();
    static List<Comment> comments = new List<Comment>();
    static void Main(string[] args)
    {

        videos.Add(new Video());
        videos.Add(new Video());
        videos.Add(new Video());
        videos.Add(new Video());
        comments.Add(new Comment());
        comments.Add(new Comment());
        comments.Add(new Comment());
        comments.Add(new Comment());
        foreach (Video video in videos)
        {
            video.videos();
        }
        foreach (Comment comment in comments)
        {
            comment.comments();
        }



    }
}
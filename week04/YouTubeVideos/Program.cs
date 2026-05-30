using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Morning Routine", "Julia", 300);

        video1.AddComment(new Comment("Ivan", "Great video!"));
        video1.AddComment(new Comment("Hector", "Very helpful."));
        video1.AddComment(new Comment("Francis", "Nice editing!"));

        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Gaming Highlights", "Jonathan", 450);

        video2.AddComment(new Comment("Julia", "This was fun."));
        video2.AddComment(new Comment("Litambezi", "Awesome gameplay!"));
        video2.AddComment(new Comment("Ivan", "I enjoyed this video."));

        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Cooking Pasta", "Francis", 600);

        video3.AddComment(new Comment("Hector", "Looks delicious."));
        video3.AddComment(new Comment("Julia", "I will try this recipe."));
        video3.AddComment(new Comment("Jonathan", "Great instructions!"));

        videos.Add(video3);

        // Display videos
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._commenterName}: {comment._commentText}");
            }

            Console.WriteLine();
        }
    }
}
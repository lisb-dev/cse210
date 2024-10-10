using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some videos
        Video video1 = new Video("Learning C# for Beginners", "Tech with Tim", 600);
        Video video2 = new Video("Top 10 Programming Languages", "CodeAcademy", 900);
        Video video3 = new Video("How to Cook Pasta", "Chef John", 300);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great tutorial, very helpful!"));
        video1.AddComment(new Comment("Bob", "Thanks for the awesome video."));
        video1.AddComment(new Comment("Charlie", "Can you make a follow-up on advanced topics?"));

        // Add comments to video2
        video2.AddComment(new Comment("Dave", "I think Python should be #1."));
        video2.AddComment(new Comment("Eve", "Very insightful, I learned a lot."));
        video2.AddComment(new Comment("Frank", "What about Rust?"));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "This recipe is so easy!"));
        video3.AddComment(new Comment("Heidi", "Thanks, this worked perfectly."));
        video3.AddComment(new Comment("Ivan", "Can I substitute the pasta for gluten-free options?"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information about each video
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}


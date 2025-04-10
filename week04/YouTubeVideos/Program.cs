using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Exploring AI in 2025", "TechTalks", 420);
        Video video2 = new Video("How to Bake Banana Bread", "CookingWithSam", 305);
        Video video3 = new Video("Top 10 Travel Destinations", "Wanderlust", 512);
        Video video4 = new Video("Workout Routine for Beginners", "FitLife", 375);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "This is so futuristic!"));
        video1.AddComment(new Comment("Bob", "Amazing insights."));
        video1.AddComment(new Comment("Charlie", "Loved the explanation!"));

        // Add comments to video2
        video2.AddComment(new Comment("Diana", "Tried it—turned out great!"));
        video2.AddComment(new Comment("Eli", "Delicious and simple."));
        video2.AddComment(new Comment("Fiona", "Thanks for the recipe!"));

        // Add comments to video3
        video3.AddComment(new Comment("George", "Adding these to my bucket list!"));
        video3.AddComment(new Comment("Hannah", "Love the visuals."));
        video3.AddComment(new Comment("Ivan", "Awesome list!"));

        // Add comments to video4
        video4.AddComment(new Comment("Jane", "Perfect for beginners."));
        video4.AddComment(new Comment("Kyle", "Just started this!"));
        video4.AddComment(new Comment("Lily", "Exactly what I needed."));

        // Put videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display details
        foreach (Video video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine(); // Extra spacing between videos
        }
    }
}

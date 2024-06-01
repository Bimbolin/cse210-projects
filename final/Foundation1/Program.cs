class Program
{
    static void Main()
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create and add videos
        videos.Add(new Video("Understanding Maths", "MathsAcademy", 600));
        videos.Add(new Video("Advanced Maths Class", "MathsGuru", 900));
        videos.Add(new Video("C# Design Patterns", "DesignPro", 1200));

        // Add comments to each video
        videos[0].AddComment(new Comment("John", "Great explanation!"));
        videos[0].AddComment(new Comment("Gift", "Helpful tutorial."));
        videos[1].AddComment(new Comment("Charlie", "I learned a lot."));
        videos[1].AddComment(new Comment("Dave", "Can't wait for more!"));
        videos[2].AddComment(new Comment("Eve", "Very insightful."));
        videos[2].AddComment(new Comment("Frank", "Good design patterns."));

        // Display information for each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.UserName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
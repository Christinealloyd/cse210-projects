using System;

class Program
{
    static void Main(string[] args)
    {
        var videos = new List<Video>
        {
            new Video("C# Tutorial - Full Course for Beginners", "Free Code Camp", 14400),
            new Video("C# abstract classes", "Bro Code", 120),
            new Video("Object-oriented Programming for beginners", "dotnet", 1020)
        };

        videos[0].AddComment(new Comment("olpersmak", "He knows about C# he knows about C++, He's younger then me , He's a master he knows how to teach. What a gem he is."));
        videos[0].AddComment(new Comment("stevemcwin", "You are a good man, thank you."));
        videos[0].AddComment(new Comment("jgriffith75", "4 years old, but still an amazing video.  Hands down best instruction and instructor."));

        videos[1].AddComment(new Comment("Fraps224", "your explanations are awesome!"));
        videos[1].AddComment(new Comment("faycaled3058", "After 2 years of coding I've finally understand what is the purpose of this abstract thanks to you !"));

        videos[2].AddComment(new Comment("la.minecraf", "These two men teach me a lot."));
        videos[2].AddComment(new Comment("DB42YT", "Easier way to understand OOP than what I was taught"));

        foreach (var video in videos)
        {
            Console.WriteLine(video);
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}
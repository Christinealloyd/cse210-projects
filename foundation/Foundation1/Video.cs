using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthSeconds { get; set; }
    private List<Comment> Comments { get; set; }

    public Video(string title, string author, int lengthSeconds)
    {
        Title = title;
        Author = author;
        LengthSeconds = lengthSeconds;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public override string ToString()
    {
        var lengthFormatted = $"{LengthSeconds / 60}:{LengthSeconds % 60:D2}";
        return $"Title: {Title}\nAuthor: {Author}\nLength: {lengthFormatted}\nComments: {GetNumberOfComments()}";
    }

    public void DisplayComments()
    {
        foreach (var comment in Comments)
            Console.WriteLine($"- {comment}");
    }
}

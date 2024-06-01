public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string name, string text)
    {
        _comments.Add(new Comment(name, text));
    }

    public int GetCommentCount()
    {
        int count = _comments.Count();
        return count;
    }

    public void Display()
    {
        Console.WriteLine($"{_title} by {_author} ({_length})");
        Console.WriteLine($"Comments ({GetCommentCount()})");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetCommentString()}");
        }
        Console.WriteLine("");
    }
}
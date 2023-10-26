using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private List<int> _verse;

    public string GetBook()
    {return _book;}

    public int GetChapter()
    {return _chapter;}
    
    public List<int> Getverse()
    {return _verse;}

    public void SetReference(string book, int chapter, List<int> verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
}
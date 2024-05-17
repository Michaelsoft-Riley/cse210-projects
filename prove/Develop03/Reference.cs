using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = 0;

    public Reference(string reference)
    // Accepts a string in "book chapter:verse-endVerse" format. (Ex: 1Nephi 1:1) or (Ex: 1Nephi 1:1-2)
    {
        ProcessReference(reference);
    }

    public List<string> GetVersesList()
    // returns a list of verses from _verse to _endVerse
    {
        List<string> verses = new();
        
        if (_endVerse != 0)
        {
            for (int i = _verse; i <= _endVerse; i++)
            {
                verses.Add($"{_book} {_chapter}:{i}");
            }
        }
        else
        {
            verses.Add($"{_book} {_chapter}:{_verse}");
        }
        return verses;
    }

    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }

    public void ProcessReference(string reference)
    // Accepts a string in "book chapter:verse-endVerse" format. (Ex: 1Nephi 1:1-2) or (Ex: 1Nephi 1:1)
    // Splits the string into corresponding variables and saves their values as class attributes.
    // The verse portion of the string can contain two verses, as long as they are separated by a "-".
    {
        reference = reference.Trim();
        string[] parts = reference.Split(" ");

        _book = parts[0];
        parts = parts[1].Split(":");

        _chapter = int.Parse(parts[0]);

        if (parts[1].Contains("-"))
        {
            string[] verses = parts[1].Split("-");
            _verse = int.Parse(verses[0]);
            _endVerse = int.Parse(verses[1]);
        }
        else
        {
        _verse = int.Parse(parts[1]);
        }
    }
}
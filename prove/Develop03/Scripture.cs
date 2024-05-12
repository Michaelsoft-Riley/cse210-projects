using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(string userReference)
    {
        BookofMormonProcessor bookofMormonProcessor = new();

        _reference = new Reference(userReference);
        List<string> references = _reference.GetVersesList();
        foreach (string verseReference in references)
        {
            string verse = bookofMormonProcessor.GetVerse(verseReference);
            VerseToWord(verse);
        }
    }

    private void VerseToWord(string text)
    // Stores each word in a string as a Word instance
    {
        string[] words = text.Split();
        foreach (string word in words)
        {
            Word newWord = new(word);
            _words.Add(newWord);
        }
    }

    public void DisplayScripture()
    {
        Console.Clear();

        string referenceText = _reference.GetDisplayText();
        string DisplayString = $"{referenceText} ";

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                DisplayString += $"{new string('_', word.GetText().Length) } ";
            }
            else
            {
                DisplayString += $"{word.GetText()} ";
            }
        }
        Console.WriteLine(DisplayString);
    }

    public void HideRandomWords()
    // TODO: Exclude punctuation
    {
        for (int i = 0; i < 3; i++)
        {
            Random random = new Random();
            int randomNum = random.Next(_words.Count());

            _words[randomNum].Hide();
        }
    }

    public bool IsAllHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
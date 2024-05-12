using System;

public class BookofMormonProcessor
// Processes mormon13.txt into a dictionary of references and verses
{
    private Dictionary<string, string> _processedBook = new();

    public BookofMormonProcessor()
    {
        LoadVersesFromFile();
    }

    public void LoadVersesFromFile()
    {
        string[] books = {
        "1Nephi", "2Nephi", "Jacob", "Enos", "Jarom", "Omni",
        "WordsofMormon", "Mosiah", "Alma", "Helaman", "3Nephi",
        "4Nephi", "Mormon", "Ether", "Moroni"};

        string sourceText = File.ReadAllText("mormon13.txt");
        
        // Verses in mormon13.txt are separated by empty lines.
        string[] textBlocks = sourceText.Split("\r\n\r\n", StringSplitOptions.RemoveEmptyEntries);

        foreach (string textBlock in textBlocks)
        {
            List<string> lines = textBlock.Split("\r\n").ToList();

            // Check if the line is a reference preceeding a verse
            // This has the added effect of filtering out non-verse text blocks
            if (books.Any(lines[0].Contains) && lines[0].Contains(":"))
            {
                // The first line is the reference. Store it, clean it, and remove it from the list of lines.
                string referenceText = lines[0];
                referenceText = referenceText.Trim();
                lines.RemoveAt(0);

                // Remove the additional verse number at the start of the verse
                lines[0] = lines[0].Remove(0,3);

                // The remaining lines are parts of the verse.
                String verseText = String.Join("\r\n", lines);
                
                // create a dictionary entry using reference and text
                _processedBook.Add(referenceText, verseText);
            }
        }
    }

    public string GetVerse(string reference)
    // Accepts a string in "book chapter:verse" format. (Ex: 1Nephi 1:1)
    {
        return _processedBook[reference];
    }
}
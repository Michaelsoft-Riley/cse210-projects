using System;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }


    public void Save(bool dontOverwrite = true)
    {
        Console.WriteLine("What is the file name?");
        string fileName = Console.ReadLine();

        foreach (Entry entry in _entries)
        {
            using(StreamWriter writetext = new StreamWriter(fileName, dontOverwrite))
            {
                writetext.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
    }


    public List<Entry> Load()
    {
        List<Entry> loadedEntries = new List<Entry>();
        
        Console.WriteLine("What is the file name?");
        string fileName = Console.ReadLine();

        var lines = File.ReadLines(fileName);
        foreach (var line in lines)
        {
            Entry entry = new Entry();

            string[] parts = line.Split('|');
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];

            loadedEntries.Add(entry);
        }
        return loadedEntries;
    }

    
    public void Remove()
    {
        Console.WriteLine("Enter the number of the line that you would like to remove:");
        int lineChoice = Int32.Parse(Console.ReadLine());
        _entries.RemoveAt(lineChoice - 1);
    }
}
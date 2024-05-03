using System;

public class Journal()
{
    List<Entry> _entries= new List<Entry>();

    public void AddEntry()
    {
        Entry entry = new Entry();
        entry.AssignAll();

        _entries.Add(entry);
    }


    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }


    public void Overwrite()
    {
        //TODO: Complete this
    }


    public void LoadFile()
    {
        //TODO
    }
}
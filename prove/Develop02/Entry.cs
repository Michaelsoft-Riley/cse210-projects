using System;

public class Entry()
{
    string _date;
    string _prompt;
    string _entryText;


    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_entryText}");
    }


    public void AssignNewAll()
    {
        NewDate();
        NewPrompt();
        NewText();
    }


    private void NewDate()
    {
        _date = DateTime.Now.ToString("MM/dd/yyyy");
    }

    private void NewPrompt()
    {
        Prompt prompt= new Prompt();
        _prompt = prompt.RandPrompt();
    }

    private void NewText()
    {
        NewPrompt();
        Console.WriteLine($"{_prompt}");
        _entryText = Console.ReadLine();
    }


    public void LoadExistingDate(string date)
    {
        _date = date;
    }

    public void LoadExistingPrompt(string prompt)
    {
        _prompt = prompt;
    }

    public void LoadExistingText(string text)
    {
        _entryText = text;
    }


    public string GetDate()
    {
        return _date;
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public string GetEntryText()
    {
        return _entryText;
    }
}
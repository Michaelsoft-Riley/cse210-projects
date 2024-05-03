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


    public void AssignAll()
    {
        AssignDate();
        AssignPrompt();
        AssignEntryText();
    }


    private void AssignDate()
    {
        //TODO: Format datetime output to match the example video
        _date = DateTime.Now.ToString();
    }


    private void AssignPrompt()
    {
        Prompt prompt= new Prompt();
        _prompt = prompt.RandPrompt();
    }


    private void AssignEntryText()
    {
        AssignPrompt();
        Console.WriteLine($"{_prompt}");
        _entryText = Console.ReadLine();
    }
}
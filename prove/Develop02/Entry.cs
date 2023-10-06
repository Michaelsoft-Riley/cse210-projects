using System;


public class Entry
{
    public string _prompt;
    public string _response;
    public string _date;


    public string RandomPrompt()
    {
        List<string> _prompts = new List<string>()
        {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did you do today that you are proud of?"
        };
        var random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }


    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_response}\n");
    }


    public void NewEntry()
    {
        _prompt = RandomPrompt();
        Console.WriteLine(_prompt);
        _response = Console.ReadLine();
        _date = DateTime.Today.ToString("MM/dd/yyyy");
    }
}
using System;

public class Prompt()
{
    List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };


    public string RandPrompt()
    {
        Random random = new Random();
        int randInt = random.Next(5);
        string _randPrompt = _prompts[randInt];

        return _randPrompt;
    }
}
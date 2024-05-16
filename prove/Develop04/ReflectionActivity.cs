using System;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity",
        "This activity will help you reflect on times in your life" +
        " when you have shown strength and resilience. This will help you recognize the power" +
        " you have and how you can use it in other aspects of your life.")
    {

    }

    public void Run()
    {

    }

    public string GetRandomPrompt()
    {
        // TODO: Implement randomization
        string randomPrompt = "";
        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        // TODO: Implement randomization
        string randomQuestion = "";
        return randomQuestion;
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestion()
    {

    }
}
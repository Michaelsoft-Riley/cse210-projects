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
        StartMessage();
        Run();
        EndMessage();
    }

    public void Run()
    {
        DisplayPrompt();

        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
        CountdownAnimation("You may begin in: ", 5);
        Console.Clear();

        int duration = GetDuration();
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);

        while (currentTime < endTime)
        {
            DisplayQuestion();
            
            currentTime = DateTime.Now;
            if (currentTime >= endTime)
            {
                break;
            }
        }
    }

    public string GetRandomPrompt()
    {
        Random random= new();
        int randomNum = random.Next(0, _prompts.Count());

        string randomPrompt = _prompts[randomNum];
        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        Random random= new();
        int randomNum = random.Next(0, _questions.Count());

        string randomQuestion = _questions[randomNum];
        return randomQuestion;
    }

    public void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n --- {randomPrompt} --- ");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestion()
    {
        string randomQuestion = GetRandomQuestion();
        Console.Write($"> {randomQuestion} ");
        SpinningAnimation();
    }
}
using System;

public class ListingActivity : Activity
{
    private int _count = 0;

    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life " + 
        "by having you list as many things as you can in a certain area.")
    {
        StartMessage();
        Run();
        EndMessage();
    }

    public override void Run()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
        CountdownAnimation("You may begin in: ", 5);

        int duration = GetDuration();
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);

        while (currentTime < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count ++;
            
            currentTime = DateTime.Now;
            if (currentTime >= endTime)
            {
                break;
            }
        }
        Console.WriteLine($"You listed {_count} items!");
    }

    public string GetRandomPrompt()
    {
        Random random = new();
        int randomNum = random.Next(0, _prompts.Count());
        string randomPrompt = _prompts[randomNum];
        return randomPrompt;
    }
}
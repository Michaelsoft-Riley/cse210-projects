using System;

public class ListingActivity : Activity
{
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
        SetIndex(2);
    }

    public override void Run()
    {
        StartMessage();
        
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
        CountdownAnimation("You may begin in: ", 5);

        // Get the current time and set the end time
        int duration = GetDuration();
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);

        // Prompt the user for responses until the end time is reached. Keep track of how many responses they make.
        int count = 0;
        while (currentTime < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count ++;
            
            currentTime = DateTime.Now;
            if (currentTime >= endTime)
            {
                break;
            }
        }
        Console.WriteLine($"You listed {count} items!");
        EndMessage();
        UpdateCount();
    }

    public string GetRandomPrompt()
    {
        Random random = new();
        int randomNum = random.Next(0, _prompts.Count());
        string randomPrompt = _prompts[randomNum];
        return randomPrompt;
    }
}
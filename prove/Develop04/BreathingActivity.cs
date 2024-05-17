using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by walking your through breathing in and out slowly. " +
        "Clear your mind and focus on your breathing.")
    {
        Run();
    }

    public void Run()
    {
        // sets the end time
        int duration = GetDuration();
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);


        while (currentTime < endTime)
        {
            CountdownAnimation("Breathe in...", 4);
            CountdownAnimation("Breathe out...", 6);
            
            currentTime = DateTime.Now;
            if (currentTime >= endTime)
            {
                break;
            }

            Console.WriteLine("\n");
        }
    }
}
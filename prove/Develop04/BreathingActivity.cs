using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by walking your through breathing in and out slowly. " +
        "Clear your mind and focus on your breathing.")
    {
        SetIndex(0);
    }

    public override void Run()
    {
        StartMessage();

        // sets the current and end times
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
            Console.WriteLine("");
        }
        EndMessage();
        UpdateCount();
    }
}
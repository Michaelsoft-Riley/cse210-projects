using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new();

        activities.Add(new RunningActivity("5/3/2023", 90, 3));
        activities.Add(new BikingActivity("5/4/2023", 60, 15));
        activities.Add(new SwimmingActivity("5/5/2023", 20, 5));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities =
        [
            new RunningActivity("5/3/2023", 90, 3),
            new BikingActivity("5/4/2023", 60, 15),
            new SwimmingActivity("5/5/2023", 20, 5),
        ];

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine("");
    }
}
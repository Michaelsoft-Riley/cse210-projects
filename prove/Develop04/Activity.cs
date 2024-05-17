using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        SpinningAnimation();

        Console.WriteLine("");
    }

    public void EndMessage()
    {
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"\nYou've completed another {_duration} seconds of the breathing activity.");
        SpinningAnimation();
    }

    public void CountdownAnimation(string message, int startNum)
    // accepts a message string and an starting number. Displays an animation counting down to 0.
    {
        Console.Write($"{message}...");

        for (int currentNum = startNum; currentNum > 0; currentNum--)
        {
            Console.Write(currentNum);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("");
    }

    public void SpinningAnimation()
    {
        List<char> chars = new List<char>()
        {
            '/', '-', '\\', '|'
        };

        // loop animation 5 times
        for (int i = 0; i < 6; i++)
            foreach (char c in chars)
            {
            Console.Write("\b \b");
            Console.Write(c);
            Thread.Sleep(250);
            }
        Console.WriteLine("");
    }

    public int GetDuration()
    {
        return _duration;
    }
}
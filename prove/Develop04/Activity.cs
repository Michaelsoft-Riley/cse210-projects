using System;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    // number of times that the activity is completed
    private int _count = 0;
    // used when saving and loading the count
    private int _index;

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
        Console.Write($"{message}");

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

    public void SetIndex(int index)
    {
        _index = index;
    }

    public int GetCount()
    {
        return _count;
    }

    public void UpdateCount()
    // This will increase _count by one for each time the activity is ran
    {
        _count += 1;
    }

    public void LoadCount()
    // Load an activity's count from file using the class's index value
    {
        int totalCount = 0;
        string[] lines = File.ReadAllLines("count.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            // TODO: Make sure that this doesn't throw a type error
            totalCount += int.Parse(parts[_index]);  
        }
        _count = totalCount;
    }

    public abstract void Run();
}
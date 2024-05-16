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

        StartMessage();
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
    }

    public void EndMessage()
    {

    }

    public void CountdownAnimation()
    {

    }

    public void SpinningAnimation()
    {
        List<char> chars = new List<char>()
        {
            '/', '-', '\\', '|'
        };

        for (int i = 0; i < 6; i++)
            foreach (char c in chars)
            {
            Console.Write("\b \b");
            Console.Write(c);
            Thread.Sleep(300);
            }
    }
}
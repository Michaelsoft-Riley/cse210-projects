using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {

    };
    private int _count = 0;

    public ListingActivity(int duration) : base(duration, "Listing Activity",
        "This activity will help you reflect on the good things in your life " + 
        "by having you list as many things as you can in a certain area.")
    {

    }

    public void Run()
    {
        _count ++;
        // TODO: make the loop
    }

    public string GetRandomPrompt()
    {
        // TODO: Implement randomization
        string randomPrompt = "";
        return randomPrompt;
    }

    public List<string> GetListFromUser()
    {
        // TODO
        List<string> gratitudeList = new List<string>();
        return gratitudeList;
    }
}
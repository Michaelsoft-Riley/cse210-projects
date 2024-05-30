using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new();
        Video v1 = new("Thing That Happened!", "IceCreamSandwich", 300);
        v1.AddComment("Tim", "Wow, that's crazy!");
        v1.AddComment("Bill", "So cool");
        v1.AddComment("John", "alskdjfh");
        videos.Add(v1);

        Video v2 = new("I Blew Up a Thing!", "DudeWithGun", 900);
        v2.AddComment("Tim", "Wow, that's crazy!");
        v2.AddComment("Bill", "So cool");
        v2.AddComment("John", "alskdjfh");
        videos.Add(v2);

        Video v3 = new("Don't Do This When Visiting!", "PersoninAnotherCountry", 1200);
        v3.AddComment("Tim", "Wow, that's crazy!");
        v3.AddComment("Bill", "So cool");
        v3.AddComment("John", "alskdjfh");
        videos.Add(v3);

        foreach (Video v in videos)
        {
            v.Display();
        }
    }
}
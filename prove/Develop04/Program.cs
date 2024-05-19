using System;

// Stretch Challenge: Program now counts, saves, and loads the number of times each activity has been completed
class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();

        breathingActivity.LoadCount();
        reflectionActivity.LoadCount();
        listingActivity.LoadCount();

        // Menu
        string choice = "";
        while (choice != "4")
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Save and Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                breathingActivity.Run();
            }
            else if (choice == "2")
            {
                reflectionActivity.Run();
            }
            else if (choice == "3")
            {
                listingActivity.Run();
            }
            else if (choice == "4")
            {
                // Save the number of times each activity has been completed to a file
                using (StreamWriter file = new StreamWriter("count.txt"))
                {
                    file.WriteLine($"{breathingActivity.GetCount()},{reflectionActivity.GetCount()},{listingActivity.GetCount()}");
                }
            }
        }
    }
}
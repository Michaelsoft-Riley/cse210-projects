using System;

class Program
{
    static void Main(string[] args)
    {
        // Menu
        string choice = "";
        while (choice != "4")
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity();
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
            }
            else if (choice == "4")
            {

            }
        }
    }
}
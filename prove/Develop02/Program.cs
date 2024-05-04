using System;

// Save functionality was split into "Add to File" and Overwrite
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int choice;

        Console.WriteLine("Welcome to the journal program!");

        do
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Overwrite\n5. Add to File\n6. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                journal.AddEntry();
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                journal.LoadFile();
            }
            else if (choice == 4)
            {
                // Add to file
                journal.Save();
            }
            else if (choice == 5)
            {           
                // Overwrite file     
                journal.Save(true);
            }
            else if (choice == 6)
            {
                Console.WriteLine("Goodbye!");
            }
        } while (choice != 6);
    }
}
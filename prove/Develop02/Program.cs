using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string choice;
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the journal program!");

        do
        {
            //Menu
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine($"1. Write\n2. Display\n3. Load\n4. Save\n5. Remove\n6. Overwrite\n7. Quit");
            Console.WriteLine("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry entry = new Entry();
                entry.NewEntry();
                journal._entries.Add(entry);
            }
            
            else if (choice == "2")
            {
                journal.Display();
            }

            else if (choice == "3")
            {
                journal._entries = journal.Load();
            }

            else if (choice == "4")
            {
                journal.Save();
            }

            else if (choice == "5")
            {
                journal.Remove();
            }

            else if (choice =="6")
            {
                journal.Save(false);
            }

        } while (choice != "7");
    }
}
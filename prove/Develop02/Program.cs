using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int choice;

        Console.WriteLine("Welcome to the journal program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");

        do
        {
            Console.Write("\nWhat would you like to do? ");
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
                journal.Overwrite();
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }
        } while (choice != 5);
    }
}

/*
- Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
- Display the journal - Iterate through all entries in the journal and display them to the screen.
- Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
- Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal.
- Provide a menu that allows the user choose these options
- Your list of prompts must contain at least five different prompts. Make sure to add your own prompts to the list, but the following are examples to help get you started:
    Who was the most interesting person I interacted with today?
    What was the best part of my day?
    How did I see the hand of the Lord in my life today?
    What was the strongest emotion I felt today?
    If I had one thing I could do over today, what would it be?
- Your interface should generally follow the pattern shown in the video demo below.

- Add a file browser to select the file instead of typing it.
- Improve the process of saving and loading to save as a .csv file that could be opened in Excel 
  (make sure to account for quotation marks and commas correctly in your content.)*/
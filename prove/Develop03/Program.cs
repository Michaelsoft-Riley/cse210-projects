using System;

class Program
// Added the option to select from any verse in the book of mormon.
// Added a class for collecting verses from a .txt version of the Book of Mormon obtained from Project Gutenberg.
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a scripture in 'book chapter:verse-endVerse' format.");
        Console.WriteLine("(Ex: 1Nephi 1:1) or (Ex: 1Nephi 1:1-2)");
        string response = Console.ReadLine();

        Scripture scripture = new Scripture(response);

        while (response != "quit")
        {
            Console.Clear();
            scripture.DisplayScripture();

            if (scripture.IsAllHidden())
            {
                break;
            }

            Console.Write($"\nPress enter to continue or type 'quit' to finish: ");
            response = Console.ReadLine();

            scripture.HideRandomWords();
        }
    }
}
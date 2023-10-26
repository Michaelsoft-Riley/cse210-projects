using System;

class Program
{
    static void Main(string[] args)
    {
        string choice;
        bool allHidden = false;

        Scripture scripture = new Scripture();
        

        do
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            choice = Console.ReadLine();

            if (choice == "")
                Console.WriteLine();

            else if (choice == "quit")
                Console.WriteLine("Goodbye!");

            
        } while (choice != "quit" || allHidden != true);

    }
}
using System;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage grade? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        string letter;

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass. You'll get it next time!");
        }
        
        Console.WriteLine($"The letter grade is {letter}");
    }
}
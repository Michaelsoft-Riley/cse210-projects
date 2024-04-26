using System;

class Program
{
    static void Main(string[] args)
    {
        int gradeNum = 0;
        string letter = "";
        bool parsed = false;

        while (parsed == false)
        {
            Console.Write("Enter your grade percentage as an integer: ");
            string answer = Console.ReadLine();
            parsed = int.TryParse (answer, out gradeNum);
        }

        if (gradeNum >= 90)
        {
            letter = "A";
        }
        else if (gradeNum >= 80)
        {
            letter = "B";
        }
        else if (gradeNum >= 70)
        {
            letter = "C";
        }
        else if (gradeNum >= 60)
        {
            letter = "D";
        }
        else if (gradeNum < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (gradeNum >= 70)
        {
            Console.WriteLine("Congrats! You passed!");
        }
        else if (gradeNum < 70)
        {
            Console.WriteLine("It's not a passing grade, but you'll get it next time!");
        }
    }
}
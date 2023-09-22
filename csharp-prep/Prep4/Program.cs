using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int num = 1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (num != 0)
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
                numbers.Add(num);
            }
        }

        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {(float)numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
    }
}
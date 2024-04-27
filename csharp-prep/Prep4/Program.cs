using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        int sum = 0;
        int largest = 0;
        int smallest;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Fill list with user input
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }    
        } while (number != 0);
        
        // Calculate largest and sum. Set smallest to a large value
        largest = numbers.Max();
        smallest = largest;
        sum = numbers.Sum();

        // Find smallest
        foreach (int n in numbers)
        {
            if (n > 0 && n < smallest)
            {
                smallest = n;
            }
        }

        // Calculate average
        int length = numbers.Count;
        float average = (float)sum / length;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");

        Console.WriteLine("The sorted list is:");
        foreach (int i in numbers)
        {Console.WriteLine(i);}
    }
}
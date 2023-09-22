using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randNum = random.Next(0, 50);
        Console.WriteLine(randNum);
        int guessInt;
        
        do
        {
            Console.Write("Guess the number(0-50): ");
            guessInt = int.Parse(Console.ReadLine());

            if(guessInt == randNum)
            {
                Console.WriteLine("You got it!");
            }
            else
            {
                Console.WriteLine("Nope! Try again!");
            }
        } while(guessInt != randNum);
    }
}
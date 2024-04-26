using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGen = new Random();
        int number = randomGen.Next(1, 100);

        int guess;
        int guessCount = 0;
        bool playAgain = true;

        do
        {
            Console.Write("Guess an integer between 0 and 100: ");
            guess = int.Parse(Console.ReadLine());
            guessCount ++;

            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess == number)
            {
                Console.WriteLine("\nYou got it!");
                Console.WriteLine($"Guesses: {guessCount}");

                Console.Write("Would you like to play again?(y/n): ");
                string answer = Console.ReadLine();

                if (answer == "n")
                {
                    playAgain = false;
                }
                else
                {
                    number = randomGen.Next(1, 100);
                    guessCount = 0;
                }
            }

        } while (playAgain == true);

        Console.WriteLine("\nGoodbye!");
    }
}
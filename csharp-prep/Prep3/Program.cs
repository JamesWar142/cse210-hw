using System;

class Program
{
    static void Main(string[] args)
    {
        int total = 0;
        bool status= false;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        while (status != true)
        {
            Console.Write("What is your guess: ");
            int guess = int.Parse(Console.ReadLine());
            total = ++total;
            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine($"You guessed it in {total} tries");
                Console.Write("Do you want to play again? (yes or no?): ");
                string awnser = Console.ReadLine();
                if (awnser == "yes")
                {
                    number = randomGenerator.Next(1, 100);
                    total = 0;
                }
                else
                {
                    status = true;
                }
            }
        }
    }
}
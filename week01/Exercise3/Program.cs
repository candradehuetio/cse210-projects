using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your guess number?: ");
        string x = Console.ReadLine();
        int guessNumber = int.Parse(x);

        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 100);
        

        while (guessNumber != randomNumber)
        {

            if (guessNumber > randomNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (guessNumber < randomNumber)
            {
                Console.WriteLine("Higher");

            }

            else
            {
                Console.WriteLine("You guessed it!");
            }

            Console.Write("What is your guess? ");
            string c = Console.ReadLine();
            guessNumber = int.Parse(c);
        }

        Console.WriteLine("You guessed it!");



    }
}
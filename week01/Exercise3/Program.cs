using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number?: ");
        string x = Console.ReadLine();
        int magicNumber = int.Parse(x);

        Console.Write("What is your guess? ");
        string y = Console.ReadLine();
        int guessNumber = int.Parse(y);

        while (guessNumber != magicNumber)
        {

            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (guessNumber < magicNumber)
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
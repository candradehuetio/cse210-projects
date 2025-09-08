using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        int number = -9999999;
        int largestNumber = 0;
        int sum = 0;

        while (number != 0)
        {

            Console.Write("Enter number: ");
            string x = Console.ReadLine();
            number = int.Parse(x);

            if (number != 0)
            {
                numbers.Add(number);
                sum += number;
            }

            if (number > largestNumber)
                {
                    largestNumber = number;
                }

            if (number == 0)
            {
                int average = sum / numbers.Count;
                Console.WriteLine($"The sum is: {sum}");
                Console.WriteLine($"The average is: {average}");
                Console.WriteLine($"The largest number is: {largestNumber}");

            }

        }


    }
}
using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the grade percentage ");
        string grade = Console.ReadLine();

        int x = int.Parse(grade);
        string letter = "F";

        if (x >= 90)
        {
            letter = letter = "A";
        }

        else if (x >= 80)
        {
            letter = letter = "B";
        }

        else if (x >= 70)
        {
            letter = letter = "C";
        }

        else if (x >= 60)
        {
            letter = letter = "D";
        }

        else
        {
            letter = letter = "F";
        }

        

        if (x >= 70)
        {
            Console.WriteLine($"Congrats! you passed the class with letter grade: {letter}");
        }

        else if (x < 70)
        {
            Console.WriteLine($"You have a {letter} of grade, you must have a C at least, get up and get over yourself next time!");
        }

    }
}
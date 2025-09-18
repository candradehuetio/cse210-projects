using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        void Main()
        {
            Fractions fractions1 = new Fractions();

            Fractions fractions2 = new Fractions(5);

            Fractions fractions3 = new Fractions(3, 4);

            Fractions fractions4 = new Fractions(1, 3);

            double result = fractions1.GetDecimalValue();
            Console.WriteLine(result);

            result = fractions2.GetDecimalValue();
            Console.WriteLine(result);

            result = fractions3.GetDecimalValue();
            Console.WriteLine(result);

            result = fractions4.GetDecimalValue();
            Console.WriteLine(result);


        }

        Main();
    }
}
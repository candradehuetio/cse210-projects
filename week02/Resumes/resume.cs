using System.Collections.Generic;

public class Resume
{
    public string _name = "Carlos Andrade";
    public List<string> jobs = new List<string>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        foreach (string job in jobs)
        {
            Console.WriteLine(job);
        }
    }

}

using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        void Main()
        {
            // job 1 instances
            Job job1 = new Job();
            job1._company = "Microsoft";
            job1._jobTitle = "Software Engineer";
            job1._startYear = 2019;
            job1._endYeaar = 2022;

            // job 2 instances
            Job job2 = new Job();
            job2._company = "Apple";
            job2._jobTitle = "Manager";
            job2._startYear = 2022;
            job2._endYeaar = 2023;


            // Resume instance]
            Resume resume = new Resume();
            resume.jobs.Add($"{job1._jobTitle} ({job1._company}) {job1._startYear}-{job1._endYeaar}");
            resume.jobs.Add($"{job2._jobTitle} ({job2._company}) {job2._startYear}-{job2._endYeaar}");
            resume.Display();

        }

        Main();
      

    }

    
}
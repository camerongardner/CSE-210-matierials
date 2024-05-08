using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "(Apple)";
        job1._startYear = 2015;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "(Microsoft)";
        job2._startYear = 2010;
        job2._endYear = 2020;

        // Console.WriteLine($"{job1._company} and {job2._company}");
        // job1.Display();

        Resume resume1 = new Resume();
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1._name = "Cameron Gardner";

        // Console.WriteLine(resume1._jobs[1]._jobTitle);

        resume1.Display();
    }
}
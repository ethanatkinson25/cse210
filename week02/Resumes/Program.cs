using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        var job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2023;
        job1._endYear = 2024;
        job1.displayJob();

        var job2 = new Job();
        job2._jobTitle = "Web Developer";
        job2._company = "Apple";
        job2._startYear = 2024;
        job2._endYear = 2025;
        job2.displayJob();

        Console.WriteLine();
        Console.WriteLine();

        var myResume = new Resume();
        Console.WriteLine();
        myResume._name = "Ethan Atkinson";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.displayResume();
    }

    public class Job
    {
        //Keeps track of the company, job title, start year, and end year.
        public string _company;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;

        public void displayJob()
        {
            Console.WriteLine($"{_jobTitle}, ({_company}) {_startYear}-{_endYear}");
            Console.WriteLine();
        }
    }

    public class Resume
    {
        //Keeps track of the person's name and a list of their jobs.
        //Will contain Job objects as member variables

        public string _name;
        public List<Job> _jobs = new List<Job>();


        public void displayResume()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs: ");

            foreach (var item in _jobs)
            {
                Console.WriteLine($"{item._jobTitle}, ({item._company}) {item._startYear}-{item._endYear}");

            }
            Console.WriteLine();
        }
    }
}
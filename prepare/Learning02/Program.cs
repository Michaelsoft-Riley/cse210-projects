using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Nintendo";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2002;
        job1._endYear = 2006;

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2007;
        job2._endYear = 2010;

        Resume resume = new Resume();
        resume._name = "John Doe";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}
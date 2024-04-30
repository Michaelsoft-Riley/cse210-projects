using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Michaelsoft";
        job1._jobTitle = "Lv.3 Cheeselord";
        job1._startYear = 1992;
        job1._endYear = 2006;

        Job job2 = new Job();
        job2._company = "Moogle";
        job2._jobTitle = "Professional Monster Slicer";
        job2._startYear = 1998;
        job2._endYear = 2003;

        Resume resume = new Resume();
        resume._name = "Bob";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}
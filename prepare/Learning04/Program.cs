using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Nelson", "Getting Stuff Done Pt3");
        Console.WriteLine(assignment.GetSummary());

        Console.WriteLine();

        MathAssignment mathAssignment= new MathAssignment("Johnathon", "Derivatives", "7.3", "20-21");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment writingAssignment= new WritingAssignment("Billy", "Humor 111", "The Great Cheese Catastrophe");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInfo());
    }
}
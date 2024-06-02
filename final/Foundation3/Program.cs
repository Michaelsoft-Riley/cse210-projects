using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new();

        LectureEvent lecture = new LectureEvent
        ("OOP", "Inheritance", "1/1/2023", "9:00am", "123 Elm St,New York City,NY,USA", "John Doe", 50);
        events.Add(lecture);

        ReceptionEvent reception = new ReceptionEvent
        ("Graduation", "MSD 321 Graduation Party", "6/1/2023", "7:00pm",
        "123 Elm St,New York City,NY,USA", "grad@msd321.com");
        events.Add(reception);

        GatheringEvent gathering = new GatheringEvent
        ("Bridge Tour", "Tour the London Bridge", "10/13/2023", "10:00am",
        "246 Oak Circle,London,England,UK", "Sunny");
        events.Add(gathering);

        foreach (Event e in events)
        {
            string basedetails = e.GetBaseDetails();
            string full = e.GetFullDetails();
            string shortdetails = e.GetShortDetails();

            Console.WriteLine($"{basedetails}\n\n{full}\n\n{shortdetails}");
            Console.WriteLine("=====================\n");

        }
    }
}
using System;

class Program
{
    static void Main()
    {
        // Create events
        var lecture = new Lecture(
            "C# Fundamentals",
            "An introductory course on C# programming.",
            new DateTime(2024, 6, 15),
            new TimeSpan(14, 0, 0),
            new Address("23 Code St", "Rivers", "PH", "75001"),
            "David Lee",
            100);

        var reception = new Reception(
            "Tech Conference 2024",
            "Networking event for tech enthusiasts.",
            new DateTime(2024, 6, 20),
            new TimeSpan(18, 30, 0),
            new Address("456 Innovation Ave", "Rivers", "PH", "75002"),
            "rsvp@techconf.com");

        var outdoorGathering = new OutdoorGathering(
            "Summer Tech Fest",
            "A festival celebrating technology and innovation.",
            new DateTime(2024, 7, 4),
            new TimeSpan(10, 0, 0),
            new Address("789 Park Blvd", "Rivers", "PH", "75003"),
            "Sunny with a chance of showers");

        // Generate and display marketing messages for each event
        Event[] events = { lecture, reception, outdoorGathering };
        foreach (var Event in events)
        {
            Console.WriteLine(Event.GetStandardDetails());
            Console.WriteLine(Event.GetFullDetails());
            Console.WriteLine(Event.GetShortDescription());
            Console.WriteLine();
        }
    }
}
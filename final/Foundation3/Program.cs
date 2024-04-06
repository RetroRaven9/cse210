class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Cityville", "Stateville", "12345");
        Address address2 = new Address("456 Oak Ave", "Townville", "Stateton", "67890");

        Event lecture = new Lecture("Coding Lecture", "Learn about programming", new DateTime(2024, 4, 10), new TimeSpan(14, 0, 0), address1, "John Doe", 50);
        Event reception = new Reception("Networking Reception", "Meet and greet", new DateTime(2024, 4, 15), new TimeSpan(18, 30, 0), address2, "rsvp@example.com");
        Event outdoorGathering = new OutdoorGathering("Picnic in the Park", "Enjoy outdoor activities", new DateTime(2024, 4, 20), new TimeSpan(12, 0, 0), address1, "Sunny skies");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetStandardDetails());

        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetFullDetails());

        Console.WriteLine("\nShort Descriptions:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}
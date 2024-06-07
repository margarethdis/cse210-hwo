class Program
{
    static void Main(string[] args)
    {
        // Crear una dirección
        Address address = new Address("123 Main St", "Cityville", "Stateville", "USA");

        // Crear eventos
        Lecture lecture = new Lecture("Title of Lecture", "Description of Lecture", new DateTime(2024, 6, 10), new TimeSpan(14, 0, 0), address, "John Doe", 50);
        Reception reception = new Reception("Title of Reception", "Description of Reception", new DateTime(2024, 6, 15), new TimeSpan(18, 0, 0), address, "rsvp@example.com");
        OutdoorGathering gathering = new OutdoorGathering("Title of Gathering", "Description of Gathering", new DateTime(2024, 6, 20), new TimeSpan(12, 0, 0), address, "Sunny");

        // Mostrar los mensajes de marketing
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(gathering.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(gathering.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Descriptions:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(gathering.GetShortDescription());
    }
}
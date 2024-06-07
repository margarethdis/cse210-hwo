
// Clase para eventos de conferencia
class Lecture : Event
{
    private string speaker;
    private int capacity;

    // Constructor
    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    // Método para obtener todos los detalles
    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}

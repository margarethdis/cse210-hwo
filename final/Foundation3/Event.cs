// Clase base para los eventos
class Event
{
    private string title;
    private string description;
    private DateTime date;
    private TimeSpan time;
    private Address address;

    // Constructor
    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    // Método para obtener los detalles estándar
    public virtual string GetStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress: {address.GetAddress()}";
    }

    // Método para obtener todos los detalles
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    // Método para obtener la descripción corta
    public virtual string GetShortDescription()
    {
        return $"Type: Event\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}

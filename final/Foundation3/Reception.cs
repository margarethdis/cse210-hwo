
// Clase para eventos de recepción
class Reception : Event
{
    private string rsvpEmail;

    // Constructor
    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    // Método para obtener todos los detalles
    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nType: Reception\nRSVP Email: {rsvpEmail}";
    }
}

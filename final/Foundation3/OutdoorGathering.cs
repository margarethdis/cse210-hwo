// Clase para eventos al aire libre
class OutdoorGathering : Event
{
    private string weatherForecast;

    // Constructor
    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    // Método para obtener todos los detalles
    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nType: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }
}

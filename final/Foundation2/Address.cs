// Clase para las direcciones
class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    // Constructor
    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    // Método para determinar si la dirección está en Estados Unidos
    public bool IsInUSA()
    {
        return country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    // Método para obtener la dirección como string
    public string GetAddressInfo()
    {
        return $"{street}\n{city}, {state}, {country}";
    }
}

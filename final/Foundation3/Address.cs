using System;

// Clase para la dirección
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

    // Método para obtener la dirección como string
    public string GetAddress()
    {
        return $"{street}, {city}, {state}, {country}";
    }
}

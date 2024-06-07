using System;
using System.Collections.Generic;

// Clase para los clientes
class Customer
{
    private string name;
    private Address address;

    // Constructor
    public Customer(string name, Address address)
    {
        name = name;
        address = address;
    }

    // Método para determinar si el cliente está en Estados Unidos
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    // Método para obtener el nombre del cliente
    public string GetName()
    {
        return name;
    }

    // Método para obtener la dirección del cliente
    public string GetAddressInfo()
    {
        return address.GetAddressInfo();
    }
}

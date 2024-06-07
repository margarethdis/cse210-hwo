using System;

class Vehicle
{
    public virtual void Start()
    {
        Console.WriteLine("The vehicle starts.");
    }
}

class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("The car starts.");
    }
}

class Bike : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("The bike starts by pedaling.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle1 = new Vehicle();
        Vehicle vehicle2 = new Car();
        Vehicle vehicle3 = new Bike();

        vehicle1.Start(); // Output: The vehicle starts.
        vehicle2.Start(); // Output: The car starts.
        vehicle3.Start(); // Output: The bike starts by pedaling.
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Crear productos
        Product product1 = new Product("Product 1", "P001", 10.50, 2);
        Product product2 = new Product("Product 2", "P002", 15.75, 3);
        Product product3 = new Product("Product 3", "P003", 8.99, 1);

        // Crear cliente
        Address address1 = new Address("123 Main St", "Cityville", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        // Crear pedido
        List<Product> products1 = new List<Product> { product1, product2 };
        Order order1 = new Order(products1, customer1);

        // Mostrar resultados
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        // Segundo pedido
        List<Product> products2 = new List<Product> { product2, product3 };
        Address address2 = new Address("456 Oak St", "Townville", "NY", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(products2, customer2);

        // Mostrar resultados del segundo pedido
        Console.WriteLine("\n--- Second Order ---");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}
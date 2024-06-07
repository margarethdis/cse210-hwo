// Clase para los pedidos
class Order
{
    private List<Product> products;
    private Customer customer;

    // Constructor
    public Order(List<Product> products, Customer customer)
    {
        products = products;
        customer = customer;
    }

    // Método para calcular el costo total del pedido
    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }
        totalCost += customer.IsInUSA() ? 5 : 35; // Costo de envío
        return totalCost;
    }

    // Método para obtener la etiqueta de embalaje
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.GetProductInfo()}\n";
        }
        return label;
    }

    // Método para obtener la etiqueta de envío
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddressInfo()}";
    }
}

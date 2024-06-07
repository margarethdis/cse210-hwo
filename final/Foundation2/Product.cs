using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; }
    public string ProductId { get; }
    public double Price { get; }
    public int Quantity { get; }

    public Product(string name, string productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public double GetTotalCost()
    {
        return Price * Quantity;
    }

    public string GetProductInfo()
    {
        return $"{Name} (ID: {ProductId})";
    }
}

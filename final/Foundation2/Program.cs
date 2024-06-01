using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create addresses
        var address1 = new Address("3 Post Office Road", "Amadi-Ama", "Port-Harcourt", "NGN");
        var address2 = new Address("47 Orji Drive", "Aboloma", "PH", "NGN");

        // Create customers
        var customer1 = new Customer("Vincent John", address1);
        var customer2 = new Customer("Mathias Adam", address2);

        // Create orders
        var order1 = new Order(customer1);
        var order2 = new Order(customer2);

        // Add products to order1
        order1.AddProduct(new Product("Laptop", "LP123", 999.99m, 1));
        order1.AddProduct(new Product("Mouse", "MS456", 19.99m, 2));

        // Add products to order2
        order2.AddProduct(new Product("Keyboard", "KB789", 49.99m, 1));
        order2.AddProduct(new Product("Monitor", "MN101", 149.99m, 1));
        order2.AddProduct(new Product("Webcam", "WC202", 89.99m, 1));

        // Display the results for order1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price for Order 1: {order1.CalculateTotalPrice():C}\n");

        // Display the results for order2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price for Order 2: {order2.CalculateTotalPrice():C}");
    }
}
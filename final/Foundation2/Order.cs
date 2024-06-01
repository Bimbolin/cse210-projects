public class Order
{
    private List<Product> Products { get; }
    private Customer Customer { get; }
    private const decimal ShippingCostNGN = 5m;
    private const decimal ShippingCost = 35m;

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal CalculateTotalPrice()
    {
        decimal totalCost = 0;
        foreach (var product in Products)
        {
            totalCost += product.CalculateTotalCost();
        }
        totalCost += Customer.IsInNGN() ? ShippingCostNGN : ShippingCost;
        return totalCost;
    }

    public string GetPackingLabel()
    {
        var packingLabel = "Packing Label:\n";
        foreach (var product in Products)
        {
            packingLabel += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return packingLabel.TrimEnd();
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{Customer.Name}\n{Customer.Address.GetFullAddress()}";
    }
}
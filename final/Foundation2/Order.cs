public class Order
{
    private List<Product> _products = new();
    private Customer _customer;

    public Order(string customerName, string address)
    {
        _customer = new(customerName, address);

    }

    public void AddProduct(string name, string id, double price, int quantity)
    {
        _products.Add(new Product(name, id, price, quantity));
    }

    public double GetTotal()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetProductCost();
        }

        // get shipping cost
        if (_customer.IsUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public void DisplayPackagingLabel()
    {
        Console.WriteLine("Packing Label");
        Console.WriteLine("====================");
        foreach (Product product in _products)
        {
            string name = product.GetName();
            string id = product.GetId();
            Console.WriteLine($"{id} - {name}");
        }
        Console.WriteLine("");
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label");
        Console.WriteLine("====================");
        Console.WriteLine(_customer.GetAddressString());
        Console.WriteLine("");
    }
}
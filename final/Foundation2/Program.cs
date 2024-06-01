using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new();
        Order order;

        order = new("Jeff", "1475 N Main St,Logan,UT,USA");
        order.AddProduct("Pencil", "324A", .33, 3);
        order.AddProduct("Eraser", "G352", .50, 2);
        orders.Add(order);

        order = new("Jeremiah", "1300 N Main St,Logan,UT,USA");
        order.AddProduct("Pencil", "324A", .33, 2);
        order.AddProduct("Paper", "L33T", .10, 10);
        orders.Add(order);

        order = new("Bob", "85 Yangzhai Rd,Changning District,Shanghai,China");
        order.AddProduct("Chopsticks", "674A", .77, 4);
        order.AddProduct("Paper", "L33T", .10, 10);
        orders.Add(order);

        int orderCount = 1;
        foreach (Order o in orders)
        {
            double total = o.GetTotal();
            Console.WriteLine($"Order{orderCount} Total Cost: ${total}");
            o.DisplayPackagingLabel();
            o.DisplayShippingLabel();
            
            Console.WriteLine("");
            orderCount ++;
        }
    }
}
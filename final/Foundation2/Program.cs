class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Cityville", "Stateville", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("456 Oak Ave", "Townville", "Stateton", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product1 = new Product("Book", 1, 10.50m, 2);
        Product product2 = new Product("Chair", 2, 25.75m, 1);
        Product product3 = new Product("Table", 3, 50.00m, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1 Details:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.CalculateTotalCost():C}");

        Console.WriteLine("\nOrder 2 Details:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.CalculateTotalCost():C}");
    }
}
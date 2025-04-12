using System;

class Program
{
    static void Main(string[] args)
    {
        // First order - USA customer
        Address address1 = new Address("123 Maple Street", "Provo", "UT", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Book", "B001", 12.50, 2));
        order1.AddProduct(new Product("Pen", "P010", 1.20, 5));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        // Second order - international customer
        Address address2 = new Address("456 King Street", "London", "Greater London", "UK");
        Customer customer2 = new Customer("Alice Smith", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", "N007", 7.80, 3));
        order2.AddProduct(new Product("Marker", "M005", 3.00, 4));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}

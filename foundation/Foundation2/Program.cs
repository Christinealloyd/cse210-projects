using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Product product1 = new Product("Laptop", "P001", 1000.00, 2);
        Product product2 = new Product("Headphones", "P002", 150.00, 1);

        Address address1 = new Address("456 Oak Ave", "Los Angeles", "CA", "USA");

        Customer customer1 = new Customer("Cameron Carter", address1);

        List<Product> productList1 = new List<Product> { product1, product2 };
        Order order1 = new Order(productList1, customer1);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\n" + order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.GetTotalPrice()}");

        Product product3 = new Product("Smartphone", "P003", 500.00, 1);
        Product product4 = new Product("Keyboard", "P004", 100.00, 2);

        Address address2 = new Address("789 Pine Rd", "Houston", "TX", "USA");
        Customer customer2 = new Customer("Amanda Bird", address2);

        List<Product> productList2 = new List<Product> { product3, product4 };
        Order order2 = new Order(productList2, customer2);

        Console.WriteLine("\n" + order2.GetPackingLabel());
        Console.WriteLine("\n" + order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.GetTotalPrice()}");
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("123 mark St", "Maryland", "Abuja", "Nigeria");
        Customer customer1 = new Customer("Godfrey Hogan Eyo", address1);
        List<Product> productsList1 = new List<Product>();

        Product product101 = new Product("Smartphone", "IP213", 999.99, 1);
        Product product102 = new Product("coofee Maker", "CM22", 3.50, 1);
        Product product103 = new Product("External Hard Drive", "EH05", 1.99, 2);

        productsList1.Add(product101);
        productsList1.Add(product102);
        productsList1.Add(product103);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();

        // Order 2
        Address address2 = new Address("303 Birch Ave", "Surburbia", "OH", "USA");
        Customer customer2 = new Customer("Thomas Andrew", address2);
        List<Product> productsList2 = new List<Product>();

        Product product201 = new Product("Tooth Brush", "HLSET", 4.99, 10);
        Product product202 = new Product("gaming Console", "Gc100", 700.45, 2);
        Product product203 = new Product("Tablet", "TB1000", 599, 1);

        productsList2.Add(product201);
        productsList2.Add(product202);
        productsList2.Add(product203);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();

        // Order 3
        Address address3 = new Address("606 Spruce St", "Uptown", "MI", "USA");
        Customer customer3 = new Customer("Dario G. Mostacero", address3);
        List<Product> productsList3 = new List<Product>();

        Product product301 = new Product("Pencil ", "PC100", 10.76, 20);
        Product product302 = new Product("lighter Set", "HLSET", 4.99, 4);

        productsList3.Add(product301);
        productsList3.Add(product302);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order Number: 3");
        order3.DisplayResults();
        Console.WriteLine();
    }
}
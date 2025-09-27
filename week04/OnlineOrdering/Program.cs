using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        //ORDER 1
        Order order1 = new Order();

        // REGISTERING THE CUSTOMER + ADDRESS TO THE ORDER
        order1.AddCustomer("Carlos", "Santa Maria", "Boogtá", "Cundinamarca", "Colombia\n");

        // CREATING 3 PRODUCTS
        Product product1 = new Product("Computer", 23, 500.99, 1);
        Product product2 = new Product("Headphones", 87, 100, 2);
        Product product3 = new Product("Handbook", 67, 10.50, 10);

        // ADDING THE PRODUCTS
        order1.AddProducts(product1);
        order1.AddProducts(product2);
        order1.AddProducts(product3);

        // CALCULATING TOTAL
        double total = order1.GetTotalPrice(product1, product2, product3);
        Math.Round(total, 2);

        // DISPLAYING PACKING LABEL
        Console.WriteLine("Registering...");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("The total is: " + total);

        // ORDER 2
        Order order2 = new Order();

        // REGISTERING CUSTOMER + ADDRESS TO THE ORDER
        order2.AddCustomer("Sophia", "Silver path", "Los Angeles", "California", "USA");

        // CREATING 3 PRODUCTS
        product1 = new Product("Mouse", 55, 55, 1);
        product2 = new Product("Smart watch", 47, 100.99, 1);
        product3 = new Product("Pencilcase", 99, 5.20, 2);

        // ADDING THE PRODUCTS
        order2.AddProducts(product1);
        order2.AddProducts(product2);
        order2.AddProducts(product3);

        // CALCULATING TOTAL
        total = order2.GetTotalPrice(product1, product2, product3);
        total = Math.Round(total, 2);

        // DISPLAYING PACKING LABEL
        Console.WriteLine("\nRegistering...");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("The total is: " + total);


        // ORDER 3
        Order order3 = new Order();

        // REGISTERING CUSTOMER + ADDRESS TO THE ORDER
        order3.AddCustomer("Jean", "Cordoba", "Valdepeñas", "Ciudad Real", "Spain");

        // CREATING 3 PRODUCTS
        product1 = new Product("Blanket", 23, 15.90, 5);
        product2 = new Product("Scooter", 12, 700.30, 1);
        product3 = new Product("Iphone", 10, 1550.90, 1);

        // ADDING THE PRODUCTS
        order3.AddProducts(product1);
        order3.AddProducts(product2);
        order3.AddProducts(product3);

        // CALCULATING TOTAL
        total = order3.GetTotalPrice(product1, product2, product3);
        total = Math.Round(total, 2);

        // DISPLAYING PACKING LABEL
        Console.WriteLine("\nRegistering...");
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine("The total is: " + total);

    }
}
using System.Collections.Generic;
using System.Text;
public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();

        foreach (Product product in _products)
        {
            packingLabel.AppendLine(product.GetNameId());
        }
        return packingLabel.ToString();

    }

    public string GetShippingLabel()
    {
        return _customer.GetNameAddress();
    }


    public void AddProducts(Product product)
    {
        _products.Add(product);

    }

    public void AddCustomer(string name, string street, string city, string state, string country)
    {
        Address address = new Address(street, city, state, country);
        Customer customer = new Customer(name, address);
        _customer = customer;
    }

    public double GetTotalPrice(Product product1,  Product product2, Product product3)
    {
        double price1 = product1.GetTotal();
        double price2 = product2.GetTotal();
        double price3 = product3.GetTotal();

        double total = price1 + price2 + price3;
        
        int shippingCost = 0;
        if (_customer.IsFromUsa())
        {
            shippingCost = 5;
            total += shippingCost;
            return total;
        }
        else
        {
            shippingCost = 35;
            total += shippingCost;
            return total;
        }

    }
}
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public double GetTotalPrice()
    {
        double totalCost = 0;
        foreach (var product in this.products)
        {
            totalCost += product.GetTotalCost();
        }
        double shippingCost = this.customer.IsInUSA() ? 5 : 35;
        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in this.products)
        {
            label += $"{product.GetName()} - {product.GetProductId()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += $"{this.customer.GetName()}\n";
        label += this.customer.GetAddress().GetFullAddress();
        return label;
    }
}


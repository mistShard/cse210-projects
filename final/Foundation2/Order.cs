using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product) {
        _products.Add(product);
    }
    
    public void GetPackingLabel() {
        Console.WriteLine(@$"

---- {_customer.GetCustomerName()}'s Order ----");
        Console.WriteLine("Packing Labels:");
        foreach(Product product in _products) {
            Console.WriteLine($"    {product.GetProductName()} -- {product.GetProductID()}");
        }
    }

    public void GetShippingLabel() {
        Console.WriteLine(@"
Shipping Label:");
        Console.WriteLine($"    {_customer.GetCustomerName()} -- {_customer.GetCustomerAddress()}");
    }

    public void GetTotalPrice() {
        int shippingCost;
        double totalPrice = 0;
        if (_customer.LivesLocal() == true) {
           shippingCost = 5;
        } else {
           shippingCost = 35;
        }

        foreach(Product product in _products) {
            totalPrice += product.GetProductPrice();  
        }

        Console.WriteLine(@$"
Shipping: {shippingCost}
Total Price: ${totalPrice + shippingCost}");
    }
}
using System;

public class Product
{
    private string _productName;
    private string _productID;
    private int _quantity;
    private double _price;

    public Product(string productName, string productID, int quantity, double price) 
    {
        _productName = productName;
        _productID = productID;
        _quantity =quantity;
        _price = price;
    }
    public double GetProductPrice() {
        return _price * _quantity;
    } 

    public string GetProductName() {
        return _productName;
    }

    public string GetProductID() {
        return _productID;
    }
}
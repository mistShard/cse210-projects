using System;

class Program
{
    static void Main(string[] args)
    {
        Customer sindel = new Customer();
        Address sindelAddress = new Address("1-B Lemon Boulevard", "Logan City", "Utah", "USA");
        sindel.SetCustomerDetails("Sindel", sindelAddress); 

        Order sindelOrder = new Order(sindel);

        Product phone = new Product("Iphone 15", "IP15", 1, 1115);
        sindelOrder.AddProduct(phone);

        Product chocolate = new Product("Hersheys Dark Chocolate", "HDCH", 3, 10);
        sindelOrder.AddProduct(chocolate);

        Product handbag = new Product("Gucci Strapless", "GCSL", 2, 1000);
        sindelOrder.AddProduct(handbag);

        Customer akonuche = new Customer();
        Address akonucheAddress = new Address("15-A Njeribako Street", "Owerri Municipal", "Imo", "Nigeria");
        akonuche.SetCustomerDetails("Akonuche", akonucheAddress); 

        Order akonucheOrder = new Order(akonuche);

        Product tv = new Product("LG OLED 12", "LO12", 3, 5000);
        akonucheOrder.AddProduct(tv);

        Product meat = new Product("Tomahawk Steak", "THST", 6, 30);
        akonucheOrder.AddProduct(meat);

        sindelOrder.GetPackingLabel();
        sindelOrder.GetShippingLabel();
        sindelOrder.GetTotalPrice();

        akonucheOrder.GetPackingLabel();
        akonucheOrder.GetShippingLabel();
        akonucheOrder.GetTotalPrice();

        Console.WriteLine();
    }
}
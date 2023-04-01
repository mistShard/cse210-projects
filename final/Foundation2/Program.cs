using System;


// To exceed requirements I added code to allow the user to input information
// and view their Order
class Program
{
    static void Main(string[] args)
    {
        Customer sindel = new Customer();     
        string name = "Sindel";
        Address sindelAddress = new Address("1-B Lemon Boulevard", "Logan City", "Utah", "USA");
        sindel.SetCustomerDetails(name, sindelAddress); 

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

        Console.WriteLine("DEMO IS OVER - Wait for 05 seconds for the rest of the program to run");
        Console.WriteLine();
        Thread.Sleep(5000);
        Console.Clear();
        Console.WriteLine(@"WELCOME TO E-SHOPY!

We aim to give customers a platform to order. You can order or view packing and shipping information.");

        void Menu() {
            Console.Write(@"
    1. Place Order
    2. View Packing and Shipping Information, and Price
    3. Quit

Which would you like to do? ");
        }

        Menu();
        string menuResponse = Console.ReadLine();
        List<Order> orderList = new List<Order>();

        while (menuResponse != "3")
        {
            Order customerOrder = new Order();

            if (menuResponse == "1")
            {
                Console.WriteLine();
                Console.Write("Customer Name: "); string customerName = Console.ReadLine();
                Console.Write("Street: "); string street = Console.ReadLine();
                Console.Write("City: "); string city = Console.ReadLine();
                Console.Write("State: "); string state = Console.ReadLine();
                Console.Write("Country: "); string country = Console.ReadLine();

                Address customerAddress = new Address(street, city, state, country);
                Customer customer = new Customer(customerName, customerAddress);

                customerOrder.AddCustomer(customer);
                Console.WriteLine();
                Console.WriteLine("Tap 'Enter' to add a product and 'quit' to finish" ); string user = Console.ReadLine();

                while (user != "quit")
                {
                    Console.Write("Product Name: "); string productName = Console.ReadLine();
                    Console.Write("Product ID: "); string productID = Console.ReadLine();
                    Console.Write("Quantity: "); string quantity = Console.ReadLine();
                    Console.Write("Price: "); string price = Console.ReadLine();

                    Product product = new Product(productName, productID, int.Parse(quantity), double.Parse(price));
                    customerOrder.AddProduct(product);

                    Console.WriteLine();
                    Console.WriteLine("Tap 'Enter' to add a product and 'quit' to finish" ); user = Console.ReadLine();
                } 

                orderList.Add(customerOrder);
            }

            if (menuResponse == "2") {
                foreach(Order order in orderList) {
                    order.GetPackingLabel();
                    order.GetShippingLabel();
                    order.GetTotalPrice();
                    
                    Console.WriteLine();
                }    
            }

            Menu();
            menuResponse = Console.ReadLine();
            }
    }
}
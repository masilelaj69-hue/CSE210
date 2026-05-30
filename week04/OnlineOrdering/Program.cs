// First Order
Address address1 = new Address(
    "12 Main Street",
    "Johannesburg",
    "Gauteng",
    "South Africa"
);

Customer customer1 = new Customer("Julia Masilela", address1);

Order order1 = new Order(customer1);

order1.AddProduct(new Product("Laptop", "P100", 15000, 1));
order1.AddProduct(new Product("Mouse", "P101", 250, 2));

// Second Order
Address address2 = new Address(
    "45 Park Avenue",
    "New York",
    "NY",
    "USA"
);

Customer customer2 = new Customer("Ivan Versic", address2);

Order order2 = new Order(customer2);

order2.AddProduct(new Product("Keyboard", "P200", 1200, 1));
order2.AddProduct(new Product("Monitor", "P201", 3500, 1));

// Display Order 1
Console.WriteLine("ORDER 1");
Console.WriteLine("Packing Label:");
Console.WriteLine(order1.GetPackingLabel());

Console.WriteLine("\nShipping Label:");
Console.WriteLine(order1.GetShippingLabel());

Console.WriteLine($"\nTotal Cost: {order1.CalculateTotalCost()}");

// Display Order 2
Console.WriteLine("\nORDER 2");
Console.WriteLine("Packing Label:");
Console.WriteLine(order2.GetPackingLabel());

Console.WriteLine("\nShipping Label:");
Console.WriteLine(order2.GetShippingLabel());

Console.WriteLine($"\nTotal Cost: {order2.CalculateTotalCost()}");
Console.Write("Product name: ");
string? product = Console.ReadLine();

Console.Write("Price: ");
double price = Convert.ToDouble(Console.ReadLine());

Console.Write("Quantity: ");
int quantity = Convert.ToInt32(Console.ReadLine());

// Calculate the total cost
double total = price * quantity;

Console.WriteLine();
Console.WriteLine("===== Invoice =====");
Console.WriteLine($"Product : {product}");
Console.WriteLine($"Price   : ${price:F2}");
Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Total   : ${total:F2}");

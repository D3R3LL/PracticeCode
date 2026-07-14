Console.Write("Item 1 price: ");
double item1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Item 2 price: ");
double item2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Item 3 price: ");
double item3 = Convert.ToDouble(Console.ReadLine());

// Calculate subtotal
double subtotal = item1 + item2 + item3;

// Calculate tax (15%)
double tax = subtotal * 0.15;

// Calculate final amount
double total = subtotal + tax;

Console.WriteLine();
Console.WriteLine("===== Receipt =====");
Console.WriteLine($"Subtotal : ${subtotal:F2}");
Console.WriteLine($"Tax      : ${tax:F2}");
Console.WriteLine($"Total    : ${total:F2}");


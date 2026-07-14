Console.Write("Price per pizza: ");
double pizzaPrice = Convert.ToDouble(Console.ReadLine());

Console.Write("Number of pizzas: ");
int pizzas = Convert.ToInt32(Console.ReadLine());

Console.Write("Delivery fee: ");
double delivery = Convert.ToDouble(Console.ReadLine());

double total = (pizzaPrice * pizzas) + delivery;

Console.WriteLine();
Console.WriteLine("===== Order Summary =====");
Console.WriteLine($"Pizza Cost : ${(pizzaPrice * pizzas):F2}");
Console.WriteLine($"Delivery   : ${delivery:F2}");
Console.WriteLine($"Total Cost : ${total:F2}");
Console.WriteLine("=========================");
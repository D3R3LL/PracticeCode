Console.Write("Distance to travel (km): ");
double distance = Convert.ToDouble(Console.ReadLine());

Console.Write("Fuel efficiency (km/L): ");
double efficiency = Convert.ToDouble(Console.ReadLine());

Console.Write("Fuel price per litre: ");
double price = Convert.ToDouble(Console.ReadLine());

// Calculate litres needed
double litres = distance / efficiency;

// Calculate fuel cost
double cost = litres * price;

Console.WriteLine();
Console.WriteLine($"Fuel Needed : {litres:F2} L");
Console.WriteLine($"Fuel Cost   : ${cost:F2}");
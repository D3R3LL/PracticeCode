Console.Write("Appliance power (Watts): ");
double watts = Convert.ToDouble(Console.ReadLine());

Console.Write("Hours used per day: ");
double hours = Convert.ToDouble(Console.ReadLine());

Console.Write("Electricity price per kWh: ");
double price = Convert.ToDouble(Console.ReadLine());

double kilowatts = watts / 1000;
double dailyCost = kilowatts * hours * price;
double monthlyCost = dailyCost * 30;

Console.WriteLine();
Console.WriteLine($"Daily Cost: ${dailyCost:F2}");
Console.WriteLine($"Monthly Cost: ${monthlyCost:F2}");
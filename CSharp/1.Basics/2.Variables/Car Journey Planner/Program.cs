Console.Write("Distance (km): ");
double distance = Convert.ToDouble(Console.ReadLine());

Console.Write("Average speed (km/h): ");
double speed = Convert.ToDouble(Console.ReadLine());

Console.Write("Fuel efficiency (km/L): ");
double efficiency = Convert.ToDouble(Console.ReadLine());

double hours = distance / speed;
double litres = distance / efficiency;

Console.WriteLine();
Console.WriteLine($"Travel Time : {hours:F2} hours");
Console.WriteLine($"Fuel Needed : {litres:F2} litres");
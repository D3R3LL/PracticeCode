Console.Write("Destination: ");
string? destination = Console.ReadLine();

Console.Write("Distance (km): ");
double distance = Convert.ToDouble(Console.ReadLine());

Console.Write("Average speed (km/h): ");
double speed = Convert.ToDouble(Console.ReadLine());

// Calculate travel time
double time = distance / speed;

Console.WriteLine();
Console.WriteLine("===== Trip Summary =====");
Console.WriteLine($"Destination : {destination}");
Console.WriteLine($"Distance    : {distance} km");
Console.WriteLine($"Travel Time : {time:F2} hours");

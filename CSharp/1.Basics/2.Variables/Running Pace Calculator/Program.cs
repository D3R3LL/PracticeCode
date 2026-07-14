// Running Pace Calculator

Console.Write("Distance (km): ");
double distance = Convert.ToDouble(Console.ReadLine());

Console.Write("Time (minutes): ");
double time = Convert.ToDouble(Console.ReadLine());

double pace = time / distance;

Console.WriteLine();
Console.WriteLine($"Average pace: {pace:F2} minutes per kilometre");
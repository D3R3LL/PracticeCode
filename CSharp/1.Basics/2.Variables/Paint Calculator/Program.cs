Console.Write("Wall length (m): ");
double length = Convert.ToDouble(Console.ReadLine());

Console.Write("Wall height (m): ");
double height = Convert.ToDouble(Console.ReadLine());

Console.Write("Coverage per litre (m²): ");
double coverage = Convert.ToDouble(Console.ReadLine());

double area = length * height;
double litres = area / coverage;

Console.WriteLine();
Console.WriteLine($"Wall Area: {area:F2} m²");
Console.WriteLine($"Paint Needed: {litres:F2} litres");
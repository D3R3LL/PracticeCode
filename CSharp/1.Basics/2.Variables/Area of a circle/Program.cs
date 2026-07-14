Console.Write("Enter the radius: ");
double radius = Convert.ToDouble(Console.ReadLine());

//Area = π × r²

double area = Math.PI * radius * radius;

Console.WriteLine($"Area of a circle = {area:F2}");
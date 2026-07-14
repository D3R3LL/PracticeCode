Console.Write("Number 1: ");
double n1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Number 2: ");
double n2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Number 3: ");
double n3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Number 4: ");
double n4 = Convert.ToDouble(Console.ReadLine());

Console.Write("Number 5: ");
double n5 = Convert.ToDouble(Console.ReadLine());

double average = (n1 + n2 + n3 + n4 + n5) / 5;

Console.WriteLine($"\nAverage = {average:F2}");
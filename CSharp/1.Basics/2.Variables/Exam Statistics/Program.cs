Console.Write("Student name: ");
string? student = Console.ReadLine();

Console.Write("Math mark: ");
double math = Convert.ToDouble(Console.ReadLine());

Console.Write("Science mark: ");
double science = Convert.ToDouble(Console.ReadLine());

Console.Write("English mark: ");
double english = Convert.ToDouble(Console.ReadLine());

double total = math + science + english;
double average = total / 3;

Console.WriteLine();
Console.WriteLine("===== Results =====");
Console.WriteLine($"Student : {student}");
Console.WriteLine($"Total   : {total:F2}");
Console.WriteLine($"Average : {average:F2}");
// Classroom Statistics

Console.Write("Number of boys: ");
int boys = Convert.ToInt32(Console.ReadLine());

Console.Write("Number of girls: ");
int girls = Convert.ToInt32(Console.ReadLine());

int totalStudents = boys + girls;

double boyPercentage = (double)boys / totalStudents * 100;
double girlPercentage = (double)girls / totalStudents * 100;

Console.WriteLine();
Console.WriteLine($"Total Students : {totalStudents}");
Console.WriteLine($"Boys : {boyPercentage:F1}%");
Console.WriteLine($"Girls: {girlPercentage:F1}%");
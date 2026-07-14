Console.Write("Student name: ");
string? name = Console.ReadLine();

Console.Write("Course: ");
string? course = Console.ReadLine();

Console.Write("Student number: ");
string? studentNumber = Console.ReadLine();

Console.Write("Average mark: ");
double average = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n===== Student Report =====");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Course: {course}");
Console.WriteLine($"Student Number: {studentNumber}");
Console.WriteLine($"Average: {average:F2}");

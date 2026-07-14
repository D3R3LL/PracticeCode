// Exam Percentage Calculator

Console.Write("Marks obtained: ");
double marks = Convert.ToDouble(Console.ReadLine());

Console.Write("Total marks: ");
double totalMarks = Convert.ToDouble(Console.ReadLine());

// Calculate percentage
double percentage = (marks / totalMarks) * 100;

Console.WriteLine();
Console.WriteLine("===== Exam Result =====");
Console.WriteLine($"Marks      : {marks}");
Console.WriteLine($"Total Marks: {totalMarks}");
Console.WriteLine($"Percentage : {percentage:F2}%");
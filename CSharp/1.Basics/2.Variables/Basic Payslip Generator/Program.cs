Console.Write("Employee name: ");
string? employee = Console.ReadLine();

Console.Write("Basic salary: ");
double salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Bonus: ");
double bonus = Convert.ToDouble(Console.ReadLine());

Console.Write("Tax deduction: ");
double tax = Convert.ToDouble(Console.ReadLine());

double netSalary = salary + bonus - tax;

Console.WriteLine();
Console.WriteLine("===== PAYSLIP =====");
Console.WriteLine($"Employee : {employee}");
Console.WriteLine($"Salary   : ${salary:F2}");
Console.WriteLine($"Bonus    : ${bonus:F2}");
Console.WriteLine($"Tax      : ${tax:F2}");
Console.WriteLine($"Net Pay  : ${netSalary:F2}");
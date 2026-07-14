// Salary Calculator

Console.Write("Enter hourly wage: ");
double hourlyWage = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter hours worked: ");
double hoursWorked = Convert.ToDouble(Console.ReadLine());

// Calculate gross pay
double grossPay = hourlyWage * hoursWorked;

Console.WriteLine();
Console.WriteLine("===== Salary Report =====");
Console.WriteLine($"Hourly Wage : ${hourlyWage:F2}");
Console.WriteLine($"Hours Worked: {hoursWorked}");
Console.WriteLine($"Gross Pay   : ${grossPay:F2}");

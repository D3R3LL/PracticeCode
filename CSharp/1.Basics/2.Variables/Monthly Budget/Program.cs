Console.Write("Monthly salary: ");
double salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Rent: ");
double rent = Convert.ToDouble(Console.ReadLine());

Console.Write("Food: ");
double food = Convert.ToDouble(Console.ReadLine());

Console.Write("Transport: ");
double transport = Convert.ToDouble(Console.ReadLine());

double expenses = rent + food + transport;
double savings = salary - expenses;

Console.WriteLine();
Console.WriteLine("===== Budget Summary =====");
Console.WriteLine($"Income   : ${salary:F2}");
Console.WriteLine($"Expenses : ${expenses:F2}");
Console.WriteLine($"Savings  : ${savings:F2}");
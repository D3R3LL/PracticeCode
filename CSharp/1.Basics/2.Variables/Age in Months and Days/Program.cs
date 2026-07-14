Console.Write("Enter your age in years: ");
int age = Convert.ToInt32(Console.ReadLine());

int months = age * 12;
int days = age * 365;

Console.WriteLine($"Months: {months}");
Console.WriteLine($"Approximate days: {days}");
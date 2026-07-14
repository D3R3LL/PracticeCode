Console.Write("Daily data usage (GB): ");
double dailyUsage = Convert.ToDouble(Console.ReadLine());

double weekly = dailyUsage * 7;
double monthly = dailyUsage * 30;
double yearly = dailyUsage * 365;

Console.WriteLine();
Console.WriteLine($"Weekly Usage : {weekly:F2} GB");
Console.WriteLine($"Monthly Usage: {monthly:F2} GB");
Console.WriteLine($"Yearly Usage: {yearly:F2} GB");
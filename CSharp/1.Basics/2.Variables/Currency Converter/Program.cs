Console.Write("Amount in USD: ");
double usd = Convert.ToDouble(Console.ReadLine());

double exchangeRate = 27.50;

double zigEquivalent = usd * exchangeRate;

Console.WriteLine($"Converted amount = {zigEquivalent:F2}zig");
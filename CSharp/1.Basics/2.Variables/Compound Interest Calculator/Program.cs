// Compound Interest Calculator

Console.Write("Principal amount: ");
double principal = Convert.ToDouble(Console.ReadLine());

Console.Write("Annual interest rate (%): ");
double rate = Convert.ToDouble(Console.ReadLine());

Console.Write("Number of years: ");
double years = Convert.ToDouble(Console.ReadLine());

// Convert percentage to decimal
double decimalRate = rate / 100;

// Calculate the final amount
double amount = principal * Math.Pow(1 + decimalRate, years);

Console.WriteLine();
Console.WriteLine($"Final Amount: ${amount:F2}");
Console.WriteLine($"Interest Earned: ${(amount - principal):F2}");
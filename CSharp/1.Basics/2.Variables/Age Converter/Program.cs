// Age Converter

Console.Write("Enter your age in years: ");
int years = Convert.ToInt32(Console.ReadLine());

// Performs the conversions
int months = years * 12;
int weeks = years * 52;
int days = years * 365;
int hours = days * 24;
int minutes = hours * 60;
int seconds = minutes * 60;

// Displays the results
Console.WriteLine();
Console.WriteLine("===== Age Converter =====");
Console.WriteLine($"Years   : {years}");
Console.WriteLine($"Months  : {months}");
Console.WriteLine($"Weeks   : {weeks}");
Console.WriteLine($"Days    : {days}");
Console.WriteLine($"Hours   : {hours}");
Console.WriteLine($"Minutes : {minutes}");
Console.WriteLine($"Seconds : {seconds}");

// Restaurant Bill Splitter

Console.Write("Enter the meal cost: ");
double mealCost = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the tax percentage: ");
double taxPercentage = Convert.ToDouble(Console.ReadLine());

Console.Write("How many people are sharing the bill? ");
int people = Convert.ToInt32(Console.ReadLine());

// Calculate tax
double tax = mealCost * taxPercentage / 100;

// Calculate total bill
double total = mealCost + tax;

// Calculate each person's share
double eachPersonPays = total / people;

Console.WriteLine();
Console.WriteLine("===== Bill Summary =====");
Console.WriteLine($"Meal Cost      : ${mealCost:F2}");
Console.WriteLine($"Tax            : ${tax:F2}");
Console.WriteLine($"Total Bill     : ${total:F2}");
Console.WriteLine($"Each Person Pays: ${eachPersonPays:F2}");
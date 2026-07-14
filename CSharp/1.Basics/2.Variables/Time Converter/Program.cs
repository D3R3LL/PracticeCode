Console.Write("Enter minutes: ");
int minutes = Convert.ToInt32(Console.ReadLine());

int hours = minutes / 60;
int remainingMinutes = minutes % 60;

Console.WriteLine();
Console.WriteLine($"{minutes} minutes = :");
Console.WriteLine($"{hours} hour(s)");
Console.WriteLine($"{remainingMinutes} minute(s)");

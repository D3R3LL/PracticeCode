// Digital Clock Converter

Console.Write("Enter total seconds: ");
int totalSeconds = Convert.ToInt32(Console.ReadLine());

int hours = totalSeconds / 3600;
int minutes = (totalSeconds % 3600) / 60;
int seconds = totalSeconds % 60;

Console.WriteLine();
Console.WriteLine($"{hours:D2}:{minutes:D2}:{seconds:D2}");
Console.Write("Enter the number of seconds: ");
int totalSeconds = Convert.ToInt32(Console.ReadLine());

int hours = totalSeconds / 3600;
int minutes = (totalSeconds % 3600) / 60;
int seconds = totalSeconds % 60;

Console.WriteLine($"{hours} hour(s), {minutes} minute(s), {seconds} second(s)");

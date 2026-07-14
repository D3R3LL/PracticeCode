// Water Intake Tracker

Console.Write("Glasses of water per day: ");
int glasses = Convert.ToInt32(Console.ReadLine());

int weekly = glasses * 7;
int monthly = glasses * 30;
int yearly = glasses * 365;

Console.WriteLine();
Console.WriteLine("===== Water Intake =====");
Console.WriteLine($"Daily   : {glasses} glasses");
Console.WriteLine($"Weekly  : {weekly} glasses");
Console.WriteLine($"Monthly : {monthly} glasses");
Console.WriteLine($"Yearly  : {yearly} glasses");
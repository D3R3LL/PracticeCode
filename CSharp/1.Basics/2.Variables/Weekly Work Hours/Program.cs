// Weekly Work Hours

Console.Write("Hours worked Monday: ");
double monday = Convert.ToDouble(Console.ReadLine());

Console.Write("Hours worked Tuesday: ");
double tuesday = Convert.ToDouble(Console.ReadLine());

Console.Write("Hours worked Wednesday: ");
double wednesday = Convert.ToDouble(Console.ReadLine());

Console.Write("Hours worked Thursday: ");
double thursday = Convert.ToDouble(Console.ReadLine());

Console.Write("Hours worked Friday: ");
double friday = Convert.ToDouble(Console.ReadLine());

double totalHours = monday + tuesday + wednesday + thursday + friday;
double average = totalHours / 5;

Console.WriteLine();
Console.WriteLine($"Total Hours: {totalHours:F1}");
Console.WriteLine($"Average Per Day: {average:F1}");
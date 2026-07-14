// Computer Storage Calculator

Console.Write("Storage size (GB): ");
double gigabytes = Convert.ToDouble(Console.ReadLine());

double megabytes = gigabytes * 1024;
double kilobytes = megabytes * 1024;

Console.WriteLine();
Console.WriteLine($"Gigabytes : {gigabytes}");
Console.WriteLine($"Megabytes : {megabytes:F0}");
Console.WriteLine($"Kilobytes : {kilobytes:F0}");
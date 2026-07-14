// File Download Time Estimator

Console.Write("File size (MB): ");
double fileSize = Convert.ToDouble(Console.ReadLine());

Console.Write("Download speed (MB/s): ");
double speed = Convert.ToDouble(Console.ReadLine());

double seconds = fileSize / speed;

Console.WriteLine();
Console.WriteLine($"Estimated download time: {seconds:F2} seconds");
Console.Write("Principal: ");
double principal = Convert.ToDouble(Console.ReadLine());

Console.Write("Rate (%): ");
double rate = Convert.ToDouble(Console.ReadLine());

Console.Write("Time (years): ");
double time = Convert.ToDouble(Console.ReadLine());

//Interest = Principal × Rate × Time / 100

double interest = principal * rate * time / 100;

Console.WriteLine($"Simple Interest = ${interest:F2}");
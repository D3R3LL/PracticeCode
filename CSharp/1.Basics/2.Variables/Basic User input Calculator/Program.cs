Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Addition = num1 + num2;
int Subtraction = num1 - num2;
int Multiplication = num1 * num2;
int Division = num1 / num2;

Console.WriteLine();

Console.WriteLine($"Addition Answer: {Addition}");
Console.WriteLine($"Subtraction Answer: {Subtraction}");
Console.WriteLine($"Multiplication Answer: {Multiplication}");
Console.WriteLine($"Division Answer: {Division}");
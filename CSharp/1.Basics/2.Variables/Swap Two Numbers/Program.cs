Console.Write("First number: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Second number: ");
int second = Convert.ToInt32(Console.ReadLine());

// Temporary variable used during the swap
int temp = first;

first = second;
second = temp;

Console.WriteLine();

Console.WriteLine($"First = {first}");
Console.WriteLine($"Second = {second}");
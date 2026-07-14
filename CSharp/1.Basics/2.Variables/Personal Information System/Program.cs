Console.WriteLine("=== Personal Information System ===");

// Ask for the user's name
Console.Write("\nEnter your name: ");
string? name = Console.ReadLine();

// Ask for age and convert text into a number
Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

// Ask for height
Console.Write("Enter your height in meters: ");
double height = Convert.ToDouble(Console.ReadLine());

// Display information
Console.WriteLine("\n=== Your Profile ===");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {age} years old");
Console.WriteLine($"Height: {height} meters");


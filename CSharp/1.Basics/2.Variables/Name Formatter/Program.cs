Console.Write("First name: ");
string? firstName = Console.ReadLine();

Console.Write("Last name: ");
string? lastName = Console.ReadLine();

string fullName = $"{firstName} {lastName}";

Console.WriteLine($"\nFull name: {fullName}");
Console.WriteLine($"\nWelcome, {fullName}!");
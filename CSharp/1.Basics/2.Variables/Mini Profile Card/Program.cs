// Mini Profile Card

Console.Write("Full Name: ");
string? name = Console.ReadLine();

Console.Write("Occupation: ");
string? occupation = Console.ReadLine();

Console.Write("Country: ");
string? country = Console.ReadLine();

Console.Write("Favourite Programming Language: ");
string? language = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("=====Profile Card=============");
Console.WriteLine($"Name      : {name}");
Console.WriteLine($"Occupation: {occupation}");
Console.WriteLine($"Country   : {country}");
Console.WriteLine($"Language  : {language}");
Console.WriteLine("==============================");

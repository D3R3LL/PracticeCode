Console.Write("Temperature in Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());

// Convert temperatures
double fahrenheit = (celsius * 9 / 5) + 32;
double kelvin = celsius + 273.15;

Console.WriteLine();
Console.WriteLine($"Celsius    : {celsius:F2} °C");
Console.WriteLine($"Fahrenheit : {fahrenheit:F2} °F");
Console.WriteLine($"Kelvin     : {kelvin:F2} K");
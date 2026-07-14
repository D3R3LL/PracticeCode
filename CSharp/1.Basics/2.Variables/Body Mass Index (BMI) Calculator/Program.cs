Console.Write("Weight (kg): ");
double weight = Convert.ToDouble(Console.ReadLine());

Console.Write("Height (m): ");
double height = Convert.ToDouble(Console.ReadLine());

//BMI = Weight ÷ (Height × Height)

double bmi = weight / (height * height);

Console.WriteLine($"BMI = {bmi:F2}");
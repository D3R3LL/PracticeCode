// Ask the user for their age
Console.Write("Enter your age: ");

int age = Convert.ToInt32(Console.ReadLine());

// Only print this message if the condition is true
if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}

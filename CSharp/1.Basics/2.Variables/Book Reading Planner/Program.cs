// Book Reading Planner

Console.Write("Number of pages: ");
int pages = Convert.ToInt32(Console.ReadLine());

Console.Write("Pages read each day: ");
int pagesPerDay = Convert.ToInt32(Console.ReadLine());

double days = (double)pages / pagesPerDay;

Console.WriteLine();
Console.WriteLine($"It will take approximately {days:F1} days to finish the book.");
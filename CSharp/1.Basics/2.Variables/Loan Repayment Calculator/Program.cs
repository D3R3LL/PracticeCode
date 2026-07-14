// Loan Repayment Calculator

Console.Write("Enter loan amount: ");
double loanAmount = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter repayment period (months): ");
int months = Convert.ToInt32(Console.ReadLine());

// Calculate monthly payment
double monthlyPayment = loanAmount / months;

Console.WriteLine();
Console.WriteLine("===== Loan Summary =====");
Console.WriteLine($"Loan Amount     : ${loanAmount:F2}");
Console.WriteLine($"Repayment Months: {months}");
Console.WriteLine($"Monthly Payment : ${monthlyPayment:F2}");

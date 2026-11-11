Console.Write("Enter the first number: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Enter the second number: ");
int num2 = int.Parse(Console.ReadLine() ?? "0");

if (num2 != 0)
{
    int quotient = num1 / num2;
    int remainder = num1 % num2;

    Console.WriteLine("Quotient: " + quotient);
    Console.WriteLine("Remainder: " + remainder);
}
else
{
    Console.WriteLine("Cannot divide by zero.");
}
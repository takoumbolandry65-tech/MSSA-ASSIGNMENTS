Console.Write("Enter the first number: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Enter the second number: ");
int num2 = int.Parse(Console.ReadLine() ?? "0");

int sum = num1 + num2;

Console.WriteLine("The sum is: " + sum);
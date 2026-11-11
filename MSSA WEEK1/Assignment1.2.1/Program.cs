Console.Write("Input 1st number: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Input 2nd number: ");
int num2 = int.Parse(Console.ReadLine() ?? "0");

if (num1 == num2)
{
    Console.WriteLine($"{num1} and {num2} are equal");
}
else
{
    Console.WriteLine($"{num1} and {num2} are not equal");
}
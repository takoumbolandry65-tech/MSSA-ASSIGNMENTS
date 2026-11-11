int sum = 0;
int i = 1;

Console.WriteLine("The first 10 natural numbers are:");

while (i <= 10)
{
    Console.Write(i + " ");
    sum += i;
    i++;
}

Console.WriteLine("\nThe Sum is: " + sum);
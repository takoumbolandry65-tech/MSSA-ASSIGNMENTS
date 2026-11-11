int choice = 0;

while (choice != 5)
{
  
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Exit");

    Console.Write("Enter your choice: ");
    choice = int.Parse(Console.ReadLine() ?? "0");

    if (choice == 5)
    {
        Console.WriteLine("Exiting calculator...");
        break;
    }

    if (choice < 1 || choice > 4)
    {
        Console.WriteLine("Invalid choice.");
        continue;
    }

    Console.Write("Enter first number: ");
    double num1 = double.Parse(Console.ReadLine() ?? "0");

    Console.Write("Enter second number: ");
    double num2 = double.Parse(Console.ReadLine() ?? "0");

    switch (choice)
    {
        case 1:
            Console.WriteLine("Result: " + (num1 + num2));
            break;

        case 2:
            Console.WriteLine("Result: " + (num1 - num2));
            break;

        case 3:
            Console.WriteLine("Result: " + (num1 * num2));
            break;

        case 4:
            if (num2 != 0)
                Console.WriteLine("Result: " + (num1 / num2));
            else
                Console.WriteLine("Cannot divide by zero.");
            break;
    }
}
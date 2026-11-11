Console.WriteLine("1. Triangle");
Console.WriteLine("2. Square");
Console.WriteLine("3. Rectangle");

Console.Write("Enter your choice: ");
int choice = int.Parse(Console.ReadLine() ?? "0");

switch (choice)
{
    case 1:
        TriangleArea();
        break;

    case 2:
        SquareArea();
        break;

    case 3:
        RectangleArea();
        break;

    default:
        Console.WriteLine("Invalid choice");
        break;
}

// Function to calculate triangle area
static void TriangleArea()
{
    Console.Write("Enter base: ");
    double baseValue = double.Parse(Console.ReadLine() ?? "0");

    Console.Write("Enter height: ");
    double height = double.Parse(Console.ReadLine() ?? "0");

    double area = (baseValue * height) / 2;
    Console.WriteLine("Area of Triangle: " + area);
}

// Function to calculate square area
static void SquareArea()
{
    Console.Write("Enter side: ");
    double side = double.Parse(Console.ReadLine() ?? "0");

    double area = side * side;
    Console.WriteLine("Area of Square: " + area);
}

// Function to calculate rectangle area
static void RectangleArea()
{
    Console.Write("Enter length: ");
    double length = double.Parse(Console.ReadLine() ?? "0");

    Console.Write("Enter width: ");
    double width = double.Parse(Console.ReadLine() ?? "0");

    double area = length * width;
    Console.WriteLine("Area of Rectangle: " + area);
}

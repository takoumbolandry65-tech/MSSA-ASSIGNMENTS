Console.Write("Enter your name: ");
string name = Console.ReadLine() ?? "";

Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Enter your address: ");
string address = Console.ReadLine() ?? "";


Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Address: " + address);
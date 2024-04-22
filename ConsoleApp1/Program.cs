// See https://aka.ms/new-console-template for more information
Console.Write("Hello, World!\nEnter name:\t");
string name = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Red;
Console.Clear();
Console.WriteLine(  $"\t\t\t\tName is {name}");
Console.ReadLine();
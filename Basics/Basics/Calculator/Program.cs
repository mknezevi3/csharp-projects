using Microsoft.VisualBasic;

Console.WriteLine("Hello!");

Console.WriteLine("Input the first number:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do? \r\n [A]dd numbers\r\n[S]ubtract numbers\r\n[M]ultiply numbers");
string op = Console.ReadLine();

int result = 0;

switch (op.ToUpper()) 
{
    case "A":
        result = a + b;
        break;
    case "S":
        result = a - b;
        break;
    case "M":
        result = a * b;
        break;
    default:
        Console.WriteLine("Nepoznata operacija");
        return;
}


Console.WriteLine($"Rezultat: {result}");


Console.ReadKey();




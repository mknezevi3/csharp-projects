
bool IsLong(string input)
{
    return input.Length > 10;
}

var userChoice = Console.ReadLine();
bool isLong = IsLong(userChoice);

Console.WriteLine(isLong);







Console.ReadKey();
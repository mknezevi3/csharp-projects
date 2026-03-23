using GameParser.Models;
using GameParser.Services;
using System.IO.Pipelines;

string userInput;

do
{
    Console.WriteLine("Enter the name of the file you want to read:");
    userInput = Console.ReadLine();
} while (!InputValidator.ValidateFileName(userInput));

string content = null;

try
{
    content = FileReader.Read(userInput);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message); 
}


try
{
    List<Game> games = JsonParser.Parse(content);

    foreach (Game game in games)
    {
        Console.WriteLine(game.Title);
        Console.WriteLine(game.ReleaseYear);
        Console.WriteLine(game.Rating);
    }

}
catch (Exception ex)
{
    Console.WriteLine($"JSON in the {userInput} was not in a valid format. JSON body:");
    Console.WriteLine(content);
    Console.WriteLine("Sorry! The application has experienced an unexpected error and will have to be closed.");
    Logger.Log(ex);
}


Console.ReadKey();




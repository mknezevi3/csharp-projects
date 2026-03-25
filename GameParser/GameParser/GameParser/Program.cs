using GameParser.Models;
using GameParser.Services;

string userInput;

var fileReader = new FileReader();
var jsonParser = new JsonParser();
var logger = new Logger();

do
{
    Console.WriteLine("Enter the name of the file you want to read:");
    userInput = Console.ReadLine();
} while (!InputValidator.ValidateFileName(userInput));

try
{
    string content = fileReader.Read(userInput);

    List<Game> games = jsonParser.Parse(content);

    foreach (Game game in games)
    {
        Console.WriteLine(game.Title);
        Console.WriteLine(game.ReleaseYear);
        Console.WriteLine(game.Rating);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error processing file: {userInput}");
    logger.Log(ex);
}

Console.ReadKey();




using System.Text.Json;

var knjiga = new Book ( "Clean Code", "Robert Martin", 464 );

var json = JsonSerializer.Serialize ( knjiga );

Console.WriteLine(json);

var notjson = JsonSerializer.Deserialize<Book> (json);

Console.WriteLine (notjson.Title + notjson.Author + notjson.Pages);












Console.ReadKey();

class Book
{
    public string Title { get; set; }

    public string Author { get; set; }

    public int Pages { get; set; }

    public Book(string title,string author,int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
namespace GameParser.Services;
using GameParser.Models;



public class JsonParser
{
    public List<Game> Parse(string content)
    {
        try
        {
            return JsonSerializer.Deserialize<List<Game>>(content);
        }
        catch (JsonException ex)
        {
            throw new Exception(ex.Message, ex);
        }
    }
}

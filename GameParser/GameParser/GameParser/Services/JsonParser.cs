using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using GameParser.Models;
using GameParser.Interfaces;




namespace GameParser.Services;




public class JsonParser : IJsonParser
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

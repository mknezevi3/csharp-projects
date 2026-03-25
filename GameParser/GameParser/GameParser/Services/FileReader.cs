using System;
using System.Collections.Generic;
using System.Text;
using GameParser.Interfaces;

namespace GameParser.Services;

public class FileReader : IFileReader
{
    public string Read(string fileName)
    {
        try
        {
            return File.ReadAllText(fileName);
        }
        catch (UnauthorizedAccessException ex)
        {
            throw new Exception($"Access denied: {ex.Message}", ex);
        }
        catch (IOException ex)
        {
            throw new Exception($"Error reading file: {ex.Message}", ex);
        }
    }
}

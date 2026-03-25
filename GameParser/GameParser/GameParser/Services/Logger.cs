using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using GameParser.Interfaces;

namespace GameParser.Services;

public class Logger : ILogger
{
    public void Log(Exception ex)
    {
        File.AppendAllText("log.txt", $"{DateTime.Now}\n{ex.Message}\n{ex.StackTrace}\n\n");
    }
}


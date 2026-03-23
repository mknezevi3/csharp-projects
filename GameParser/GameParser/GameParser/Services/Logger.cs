using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace GameParser.Services;

public class Logger
{
    public static void Log(Exception ex)
    {
        File.AppendAllText("log.txt", $"{DateTime.Now}\n{ex.Message}\n{ex.StackTrace}\n\n");
    }
}


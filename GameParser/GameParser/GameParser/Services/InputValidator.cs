using System;
using System.Collections.Generic;
using System.Text;

namespace GameParser.Services;

public class InputValidator
{
    public static bool ValidateFileName(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return false;
        if (!input.Contains('.')) return false;
        if (!input.EndsWith(".json")) return false;
        if (input.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0) return false;
        if (!File.Exists(input)) return false;

        return true;
    }
}


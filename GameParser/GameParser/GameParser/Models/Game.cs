using System;
using System.Collections.Generic;
using System.Text;

namespace GameParser.Models;

public class Game
{
    public string Title { get; init; }
    public int ReleaseYear { get; init; }

    public double Rating { get; init; }
}

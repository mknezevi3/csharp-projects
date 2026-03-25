using System;
using System.Collections.Generic;
using System.Text;
using GameParser.Models;

namespace GameParser.Interfaces;

    public interface IJsonParser
    {
        List<Game> Parse(string content);
    }

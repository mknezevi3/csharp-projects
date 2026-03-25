using System;
using System.Collections.Generic;
using System.Text;

namespace GameParser.Interfaces;

public interface IFileReader
{
    string Read(string path);
}

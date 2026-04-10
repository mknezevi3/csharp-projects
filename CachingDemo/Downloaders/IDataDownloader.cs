using System;
using System.Collections.Generic;
using System.Text;

namespace CachingDemo.Downloaders;

public interface IDataDownloader
{
    string DownloadData(string resourceId);
}


using System;
using System.Collections.Generic;
using System.Text;

namespace CachingDemo.Downloaders;

using System.Threading;

public class SlowDataDownloader : IDataDownloader
{
    public string DownloadData(string resourceId)
    {
        Thread.Sleep(2000);
        return $"Some data for {resourceId}";
    }
}


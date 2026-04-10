using CachingDemo.Caching;
using CachingDemo.Downloaders;


var dataDownloader = new SlowDataDownloader();
var cache = new Cache<string, string>();

Console.WriteLine(cache.Get("id1", dataDownloader.DownloadData));
Console.WriteLine(cache.Get("id2", dataDownloader.DownloadData));
Console.WriteLine(cache.Get("id1", dataDownloader.DownloadData));
Console.WriteLine(cache.Get("id3", dataDownloader.DownloadData));
Console.WriteLine(cache.Get("id2", dataDownloader.DownloadData));
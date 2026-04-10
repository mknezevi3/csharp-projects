using System;
using System.Collections.Generic;
using System.Text;

namespace CachingDemo.Caching;

public class Cache<TKey, TValue>
{
    private Dictionary<TKey, TValue> _cache = new();

    public TValue Get(TKey key, Func<TKey, TValue> getData)
    {
        if (_cache.TryGetValue(key, out var value))
        {
            return value;
        }

        var data = getData(key);

        _cache[key] = data;

        return data;
    }
}


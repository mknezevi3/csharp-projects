# C# Generic Caching Demo

Simple console project demonstrating a basic caching mechanism in C#.

## Concepts Used

- Generics
- Dictionary
- Interface
- Delegates (Func)
- Separation of concerns

## Project Structure

CachingDemo
│
├─ Program.cs
│
├─ Caching
│   └─ Cache.cs
│
├─ Downloaders
│   ├─ IDataDownloader.cs
│   └─ SlowDataDownloader.cs

## How It Works

The Cache<TKey, TValue> class stores data inside a Dictionary.

If the key exists, the cached value is returned.

If the key does not exist, the download function is called and the result is stored in the cache.

## Purpose

Practice project for understanding caching and abstraction in C#.
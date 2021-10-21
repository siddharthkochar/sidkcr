using System;

namespace OneLevelIndentationPerMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var cache = new Cache();
            cache.BuildCache();
            var count = cache.CachedObjects.Count;
        }
    }
}

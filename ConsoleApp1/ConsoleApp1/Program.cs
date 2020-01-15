using StackExchange.Redis;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cm = ConnectionMultiplexer.Connect("st-shared-we-redis.redis.cache.windows.net:6380,ssl=true,password=BbXozL6PdVTvYXGgj0R+xAsYvWR8CwvMtedXroaPMXU=");
            var db = cm.GetDatabase();

            db.StringSet("key", "value");
            var key = db.StringGet("key");

            Console.WriteLine("Hello World!");
        }
    }
}

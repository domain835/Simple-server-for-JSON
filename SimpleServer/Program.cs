using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SimpleServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = JsonConvert.DeserializeObject<Log>(File.ReadAllText(@"C:\Users\D835\Desktop\Temp\data.json"));

            Console.ReadKey();
        }

    }
}

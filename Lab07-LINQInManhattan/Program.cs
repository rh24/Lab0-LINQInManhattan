using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Lab08_LINQInManhattan.Classes;
using Newtonsoft.Json;

namespace Lab08_LINQInManhattan
{
    class Program
    {
        static void Main(string[] args)
        {
            DeserializeManhattanJSON();
        }

        static void DeserializeManhattanJSON()
        {
            string dataPath = "../../../data.json";
            string jsonData = "";

            using (StreamReader sr = File.OpenText(dataPath))
            {
                jsonData = sr.ReadToEnd();
            }

            // This is where the deserialization happens.
            IEnumerable<RootObject> myQuotes = JsonConvert.DeserializeObject<List<RootObject>>(jsonData);

            // LINQ method
            var features = myQuotes.Select(x => x);

            Console.WriteLine(features.GetType());
        }
    }
}

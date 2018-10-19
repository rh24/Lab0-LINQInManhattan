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
        /*
        IEnumerable<Feature>
        */
        static void DeserializeManhattanJSON()
        {
            string dataPath = "../../../data.json";
            string jsonData = "";

            // using streamreader to access the file. 
            using (StreamReader sr = File.OpenText(dataPath))
            {
                // get all the text
                jsonData = sr.ReadToEnd();
            }

            // deserialize the JSON to convert to the Quotes object. 
            List<Feature> myQuotes = JsonConvert.DeserializeObject<List<Feature>>(jsonData);


            // Lambda expression to get all the quotes from 
            // Dr. Seuss.
            var features = myQuotes.Select(x => x);

            Console.WriteLine(features.GetType());
        }
    }
}

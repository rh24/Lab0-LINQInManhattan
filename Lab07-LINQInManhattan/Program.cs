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
            var rootObjects = JsonConvert.DeserializeObject<RootObject>(jsonData);

            /* I want to figure out why this won't work.

                IEnumerable<RootObject> explicitCastRootObjects = (IEnumerable<RootObject>)Convert.ChangeType(JsonConvert.DeserializeObject<RootObject>(jsonData), typeof(IEnumerable<RootObject>));
                var features = explicitCastRootObjects.Select(x => x.Features);

            */

            // LINQ method syntax to filter out neighborhoods that don't have names
            var filterOutEmptyNames = rootObjects.Features.Where(x => x.Properties.Neighborhood != "");

            // Select the actual neighborhood property, which is a string
            var selectNeighborhoodProperty = filterOutEmptyNames.Select(x => x.Properties.Neighborhood);

            // Grab unique neighborhoods, no duplicates
            var uniqueNeighborhoods = selectNeighborhoodProperty.Distinct();

            // Consolidated LINQ method syntax on the List<Feature> property "Features" of RootObject
            var singleQueryLambda = rootObjects.Features
                                .Where(x => x.Properties.Neighborhood != "")
                                .Select(x => x.Properties.Neighborhood)
                                .Distinct();

            foreach (var n in uniqueNeighborhoods)
            {
                Console.WriteLine(n.ToString());
            }

        }
    }
}

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

            // Print ALL neighborhoods in RootObject.Features
            var allNeighborhoods = rootObjects.Features.Select(x => x.Properties.Neighborhood);

            Console.WriteLine("------------------------ Print all the neighborhoods: --------------------------" + Environment.NewLine);
            foreach (var n in allNeighborhoods)
            {
                Console.WriteLine(n.ToString());
            }

            // LINQ method syntax to filter out neighborhoods that don't have names
            var filterOutEmptyNames = rootObjects.Features.Where(x => x.Properties.Neighborhood != "");

            // Select the actual neighborhood property, which is a string
            var selectNeighborhoodProperty = filterOutEmptyNames.Select(x => x.Properties.Neighborhood);

            Console.WriteLine("------------------------ Filter out the empty names: ----------------------------" + Environment.NewLine);
            foreach (var n in selectNeighborhoodProperty)
            {
                Console.WriteLine(n.ToString());
            }

            // Grab unique neighborhoods, no duplicates
            var uniqueNeighborhoods = selectNeighborhoodProperty.Distinct();

            Console.WriteLine("------------------- Print out the distinct neighborhoods: -----------------------" + Environment.NewLine);
            foreach (var n in uniqueNeighborhoods)
            {
                Console.WriteLine(n.ToString());
            }

            // Consolidated LINQ method syntax on the List<Feature> property "Features" of RootObject
            var singleQueryLambda = rootObjects.Features
                                .Where(x => x.Properties.Neighborhood != "")
                                .Select(x => x.Properties.Neighborhood)
                                .Distinct();

            Console.WriteLine("-------- Select unique neighborhoods with consolidated method syntax: -----------" + Environment.NewLine);
            // Print out distinct neighborhoods using singleQueryLambda
            foreach (var n in uniqueNeighborhoods)
            {
                Console.WriteLine(n.ToString());
            }

            // Rewrite the consolidated lambda into query syntax. Unable to select distinct with this syntax.
            var querySyntaxNonEmptyNeighborhoods = from feature in rootObjects.Features
                                                   where feature.Properties.Neighborhood != ""
                                                   select feature.Properties.Neighborhood;

            var distinctQueriedNeighborhoods = querySyntaxNonEmptyNeighborhoods.Distinct();

            Console.WriteLine("------------------- Here is the ouput with query syntax: -----------------------" + Environment.NewLine);
            foreach (var n in distinctQueriedNeighborhoods)
            {
                Console.WriteLine(n.ToString());
            }
        }
    }
}

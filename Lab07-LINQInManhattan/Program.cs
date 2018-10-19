using System;

namespace Lab07_LINQInManhattan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        /* SAMPLE JSON DATA:
        IEnumerable<Feature>

        {
            type: "FeatureCollection",
            features: [
                {
                    type: "Feature",
                    geometry: {
                        type: "Point",
                        coordinates: [
                            -73.997177,
                            40.750633
                        ]
                    },
                    properties: {
                        zip: "10001",
                        city: "New York",
                        state: "NY",
                        address: "",
                        borough: "Manhattan",
                        neighborhood: "Chelsea",
                        county: "New York County"
                   }
                },
            ]
        */
        static void DeserializeManhattanJSON()
        {

        }
    }
}

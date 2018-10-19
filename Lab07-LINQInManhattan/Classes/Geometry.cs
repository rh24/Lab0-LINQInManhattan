using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Lab08_LINQInManhattan.Classes
{
    public class Geometry
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Coordinates")]
        public List<double> Coordinates { get; set; }
    }

}

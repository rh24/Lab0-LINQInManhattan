using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Lab08_LINQInManhattan.Classes
{
    public class Feature
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Geometry")]
        public Geometry Geometry { get; set; }

        [JsonProperty("Properties")]
        public Properties Properties { get; set; }
    }
}

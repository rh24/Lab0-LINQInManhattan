using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Lab08_LINQInManhattan.Classes;

namespace Lab08_LINQInManhattan.Classes
{
    public class RootObject
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Features")]
        public List<Feature> Features { get; set; }
    }
}

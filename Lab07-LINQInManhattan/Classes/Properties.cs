using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Lab08_LINQInManhattan.Classes
{
    public class Properties
    {
        [JsonProperty("Zip")]
        public string Zip { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("Address")]
        public string Address { get; set; }

        [JsonProperty("Borough")]
        public string Borough { get; set; }

        [JsonProperty("Neighborhood")]
        public string Neighborhood { get; set; }

        [JsonProperty("County")]
        public string County { get; set; }
    }
}

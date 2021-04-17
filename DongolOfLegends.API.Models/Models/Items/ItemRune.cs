using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DongolOfLegends.API.Models.Models.Items
{
    public class ItemRune
    {
        [JsonProperty("isrune")]
        public bool Isrune { get; set; }

        [JsonProperty("tier")]
        public int Tier { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

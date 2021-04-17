using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DongolOfLegends.API.Models.Models.Items
{
    public class ItemGroup
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("MaxGroupOwnable")]
        public string MaxGroupOwnable { get; set; }
    }
}

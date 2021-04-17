using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DongolOfLegends.API.Models.Models.Items
{
    public class ItemTree
    {
        [JsonProperty("header")]
        public string Header { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
    }
}

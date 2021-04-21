using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DongolOfLegends.API.Models.Models.Items
{
    public class Items
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [Key]
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("basic")]
        public BasicItemInfo Basic { get; set; }

        [JsonProperty("data")]
        [JsonIgnore]
        public List<ItemData> Data { get; set; }

        [JsonProperty("groups")]
        public List<ItemGroup> Groups { get; set; }

        [JsonProperty("tree")]
        public List<ItemTree> Tree { get; set; }
    }
}

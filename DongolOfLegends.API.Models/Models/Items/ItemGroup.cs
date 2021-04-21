using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DongolOfLegends.API.Models.Models.Items
{
    public class ItemGroup
    {
        [Key]
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("MaxGroupOwnable")]
        public string MaxGroupOwnable { get; set; }
    }
}

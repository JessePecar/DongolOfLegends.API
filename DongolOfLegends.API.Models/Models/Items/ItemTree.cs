using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DongolOfLegends.API.Models.Models.Items
{
    public class ItemTree
    {
        [Key]
        public long Id { get; set; }
        [JsonProperty("header")]
        public string Header { get; set; }

        [JsonProperty("tags")]
        public List<ItemTags> Tags { get; set; }
    }
}

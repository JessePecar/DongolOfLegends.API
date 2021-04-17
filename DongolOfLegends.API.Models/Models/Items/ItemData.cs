using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DongolOfLegends.API.Models.Models.Items
{
    public class ItemData
    {
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("colloq")]
        public string Colloq { get; set; }

        [JsonProperty("plaintext")]
        public string Plaintext { get; set; }

        [JsonProperty("into")]
        public List<string> Into { get; set; }

        [JsonProperty("image")]
        public ItemImage Image { get; set; }

        [JsonProperty("gold")]
        public ItemGold Gold { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("maps")]
        public Maps Maps { get; set; }

        [JsonProperty("stats")]
        public ItemStats Stats { get; set; }
    }
}

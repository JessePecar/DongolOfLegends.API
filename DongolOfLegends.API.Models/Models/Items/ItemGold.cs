using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DongolOfLegends.API.Models.Models.Items
{
    public class ItemGold
    {
        [JsonProperty("base")]
        public int Base { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("sell")]
        public int Sell { get; set; }

        [JsonProperty("purchasable")]
        public bool Purchasable { get; set; }
    }
}

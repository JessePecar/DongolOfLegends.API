using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DongolOfLegends.API.Models.Models.Items
{
    public class ItemsEnabledMaps
    {
        [Key]
        public long Id { get; set; }
        [JsonProperty("1")]
        public bool _1 { get; set; }

        [JsonProperty("8")]
        public bool _8 { get; set; }

        [JsonProperty("10")]
        public bool _10 { get; set; }

        [JsonProperty("12")]
        public bool _12 { get; set; }
    }
}

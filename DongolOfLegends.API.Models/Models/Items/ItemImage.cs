using DongolOfLegends.API.Models.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DongolOfLegends.API.Models.Models.Items
{
    public class ItemImage
    {
        [Key]
        public long Id { get; set; }
        [JsonProperty("full")]
        public string Full { get; set; }

        [JsonProperty("squareImage")]
        public string SquareImage { get => DataDragonValues.ItemArt.Replace("{itemId}.png", Full); }

        [JsonProperty("sprite")]
        public string Sprite { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }

        [JsonProperty("w")]
        public int W { get; set; }

        [JsonProperty("h")]
        public int H { get; set; }
    }
}


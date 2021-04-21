using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DongolOfLegends.API.Models.Models.Items
{
    public class BasicItemInfo
    {
        [Key]
        public string Code { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rune")]
        public ItemRune Rune { get; set; }

        [JsonProperty("gold")]
        public ItemGold Gold { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("colloq")]
        public string Colloq { get; set; }

        [JsonProperty("plaintext")]
        public string Plaintext { get; set; }

        [JsonProperty("consumed")]
        public bool Consumed { get; set; }

        [JsonProperty("stacks")]
        public int Stacks { get; set; }

        [JsonProperty("depth")]
        public int Depth { get; set; }

        [JsonProperty("consumeOnFull")]
        public bool ConsumeOnFull { get; set; }

        //[JsonProperty("from")]
        //public List<object> From { get; set; }

        //[JsonProperty("into")]
        //public List<object> Into { get; set; }

        [JsonProperty("specialRecipe")]
        public int SpecialRecipe { get; set; }

        [JsonProperty("inStore")]
        public bool InStore { get; set; }

        [JsonProperty("hideFromAll")]
        public bool HideFromAll { get; set; }

        [JsonProperty("requiredChampion")]
        public string RequiredChampion { get; set; }

        [JsonProperty("requiredAlly")]
        public string RequiredAlly { get; set; }

        [JsonProperty("stats")]
        public ItemStats Stats { get; set; }

        //[JsonProperty("tags")]
        //public List<object> Tags { get; set; }

        [JsonProperty("maps")]
        public ItemsEnabledMaps Maps { get; set; }
    }
}

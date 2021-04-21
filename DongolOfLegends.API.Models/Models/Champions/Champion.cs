﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DongolOfLegends.API.Models.Models.Champions
{
    public class Champion
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [Key]
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("key")]
        public long Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("blurb")]
        public string Blurb { get; set; }

        [JsonProperty("info")]
        public ChampionInfo Info { get; set; }

        [JsonProperty("image")]
        public ChampionImage Image { get; set; }

        [NotMapped]
        [JsonProperty("tags")]
        public List<string> tags { get; set; }

        [JsonProperty("partype")]
        public string Partype { get; set; }

        [JsonProperty("stats")]
        public ChampionStats Stats { get; set; }
    }
}

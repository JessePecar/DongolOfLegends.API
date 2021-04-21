using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DongolOfLegends.API.Models.Models.Champions
{
    public class ChampionStats
    {
        [Key]
        public long Id { get; set; }
        [JsonProperty("hp")]
        public double Hp { get; set; }

        [JsonProperty("hpperlevel")]
        public double Hpperlevel { get; set; }

        [JsonProperty("mp")]
        public double Mp { get; set; }

        [JsonProperty("mpperlevel")]
        public double Mpperlevel { get; set; }

        [JsonProperty("movespeed")]
        public double Movespeed { get; set; }

        [JsonProperty("armor")]
        public double Armor { get; set; }

        [JsonProperty("armorperlevel")]
        public double Armorperlevel { get; set; }

        [JsonProperty("spellblock")]
        public double Spellblock { get; set; }

        [JsonProperty("spellblockperlevel")]
        public double Spellblockperlevel { get; set; }

        [JsonProperty("attackrange")]
        public double Attackrange { get; set; }

        [JsonProperty("hpregen")]
        public double Hpregen { get; set; }

        [JsonProperty("hpregenperlevel")]
        public double Hpregenperlevel { get; set; }

        [JsonProperty("mpregen")]
        public double Mpregen { get; set; }

        [JsonProperty("mpregenperlevel")]
        public double Mpregenperlevel { get; set; }

        [JsonProperty("crit")]
        public double Crit { get; set; }

        [JsonProperty("critperlevel")]
        public double Critperlevel { get; set; }

        [JsonProperty("attackdamage")]
        public double Attackdamage { get; set; }

        [JsonProperty("attackdamageperlevel")]
        public double Attackdamageperlevel { get; set; }

        [JsonProperty("attackspeedperlevel")]
        public double Attackspeedperlevel { get; set; }

        [JsonProperty("attackspeed")]
        public double Attackspeed { get; set; }
    }
}

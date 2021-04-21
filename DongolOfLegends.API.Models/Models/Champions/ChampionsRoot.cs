using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DongolOfLegends.API.Models.Models.Champions
{
    public class ChampionsRoot
    {
        [Key]
        public long Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [NotMapped]
        [JsonProperty("data")]
        public ChampionData Data { get; set; }
    }



}

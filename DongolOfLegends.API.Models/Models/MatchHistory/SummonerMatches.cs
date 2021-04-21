using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DongolOfLegends.API.Models.Models.MatchHistory
{
    public class SummonerMatches
    {
        [Key]
        public long Id { get; set; }
        [JsonProperty("matches")]
        public List<MatchHistory> Matches { get; set; }
    }

    
}

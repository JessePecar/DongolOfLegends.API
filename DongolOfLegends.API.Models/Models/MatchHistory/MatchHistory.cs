using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DongolOfLegends.API.Models.Models.MatchHistory
{
    public class MatchHistory
    {
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }

        [JsonProperty("gameId")]
        public long GameId { get; set; }

        [JsonProperty("champion")]
        public int Champion { get; set; }

        [JsonProperty("queue")]
        public int Queue { get; set; }

        [JsonProperty("season")]
        public int Season { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        public DateTime TimeOfGame { get => new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(Timestamp).ToLocalTime(); }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("lane")]
        public string Lane { get; set; }
    }

    public class SummonerMatches
    {
        [JsonProperty("matches")]
        public List<MatchHistory> Matches { get; set; }
    }
}

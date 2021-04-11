using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DongolOfLegends.API.Models.Models.MatchHistory
{
    public class GameModel
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

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("lane")]
        public string Lane { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class MatchHistory
    {
        public long GameId { get; set; }
        public string PlatformId { get; set; }
        public int Champion { get; set; }
        public int Queue { get; set; }
        public int Season { get; set; }
        public long Timestamp { get; set; }
        public string Role { get; set; }
        public string Lane { get; set; }
        public long? SummonerMatchesId { get; set; }

        public virtual SummonerMatch SummonerMatches { get; set; }
    }
}

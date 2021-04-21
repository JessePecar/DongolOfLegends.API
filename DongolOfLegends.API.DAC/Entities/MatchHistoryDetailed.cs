using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class MatchHistoryDetailed
    {
        public long Id { get; set; }
        public string PlatformId { get; set; }
        public long? GameId { get; set; }
        public string ChampionId { get; set; }
        public string AccountId { get; set; }
        public int Queue { get; set; }
        public int Season { get; set; }
        public long Timestamp { get; set; }
        public string Role { get; set; }
        public string Lane { get; set; }
        public long? SummonerMatchesDetailedId { get; set; }

        public virtual MatchDetail Game { get; set; }
        public virtual SummonerMatchesDetailed SummonerMatchesDetailed { get; set; }
    }
}

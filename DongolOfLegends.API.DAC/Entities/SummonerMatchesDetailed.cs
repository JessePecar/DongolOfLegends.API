using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class SummonerMatchesDetailed
    {
        public SummonerMatchesDetailed()
        {
            MatchHistoryDetaileds = new HashSet<MatchHistoryDetailed>();
        }

        public long Id { get; set; }
        public string PlayerName { get; set; }

        public virtual ICollection<MatchHistoryDetailed> MatchHistoryDetaileds { get; set; }
    }
}

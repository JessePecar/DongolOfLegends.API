using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class SummonerMatch
    {
        public SummonerMatch()
        {
            MatchHistories = new HashSet<MatchHistory>();
        }

        public long Id { get; set; }

        public virtual ICollection<MatchHistory> MatchHistories { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class MatchPlayer
    {
        public MatchPlayer()
        {
            MatchParticipentIdentities = new HashSet<MatchParticipentIdentity>();
        }

        public long Id { get; set; }
        public string PlatformId { get; set; }
        public string AccountId { get; set; }
        public string SummonerName { get; set; }
        public string SummonerId { get; set; }
        public string CurrentPlatformId { get; set; }
        public string CurrentAccountId { get; set; }
        public string MatchHistoryUri { get; set; }
        public int ProfileIcon { get; set; }

        public virtual ICollection<MatchParticipentIdentity> MatchParticipentIdentities { get; set; }
    }
}

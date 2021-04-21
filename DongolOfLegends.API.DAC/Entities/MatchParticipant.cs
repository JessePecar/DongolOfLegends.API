using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class MatchParticipant
    {
        public long Id { get; set; }
        public int ParticipantId { get; set; }
        public int TeamId { get; set; }
        public int ChampionId { get; set; }
        public string ChampionId1 { get; set; }
        public int Spell1Id { get; set; }
        public int Spell2Id { get; set; }
        public long? StatsId { get; set; }
        public long? TimelineId { get; set; }
        public long? MatchDetailsGameId { get; set; }

        public virtual MatchDetail MatchDetailsGame { get; set; }
        public virtual MatchStat Stats { get; set; }
        public virtual Timeline Timeline { get; set; }
    }
}

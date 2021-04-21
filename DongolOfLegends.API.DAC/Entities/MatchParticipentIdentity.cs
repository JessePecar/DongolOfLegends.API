using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class MatchParticipentIdentity
    {
        public long Id { get; set; }
        public int ParticipantId { get; set; }
        public long? PlayerId { get; set; }
        public long? MatchDetailsGameId { get; set; }

        public virtual MatchDetail MatchDetailsGame { get; set; }
        public virtual MatchPlayer Player { get; set; }
    }
}

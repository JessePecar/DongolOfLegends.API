using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class Timeline
    {
        public Timeline()
        {
            MatchParticipants = new HashSet<MatchParticipant>();
        }

        public long Id { get; set; }
        public int ParticipantId { get; set; }
        public long? CreepsPerMinDeltasId { get; set; }
        public long? XpPerMinDeltasId { get; set; }
        public long? GoldPerMinDeltasId { get; set; }
        public long? DamageTakenPerMinDeltasId { get; set; }
        public string Role { get; set; }
        public string Lane { get; set; }

        public virtual CreepDelta CreepsPerMinDeltas { get; set; }
        public virtual DamageTakenDelta DamageTakenDelta { get; set; }
        public virtual ExpDelta ExpDelta { get; set; }
        public virtual GoldPerMinuteDelta GoldPerMinuteDelta { get; set; }
        public virtual ICollection<MatchParticipant> MatchParticipants { get; set; }
    }
}

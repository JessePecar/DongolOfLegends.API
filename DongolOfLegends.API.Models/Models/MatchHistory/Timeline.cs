using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DongolOfLegends.API.Models.Models.MatchHistory
{
    public class Timeline
    {
        [Key]
        public long Id { get; set; }
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        [JsonProperty("creepsPerMinDeltas")]
        public CreepDeltas CreepsPerMinDeltas { get; set; }

        [JsonProperty("xpPerMinDeltas")]
        public ExpDeltas XpPerMinDeltas { get; set; }

        [JsonProperty("goldPerMinDeltas")]
        public GoldPerMinuteDeltas GoldPerMinDeltas { get; set; }

        [JsonProperty("damageTakenPerMinDeltas")]
        public DamageTakenDeltas DamageTakenPerMinDeltas { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("lane")]
        public string Lane { get; set; }
    }
}

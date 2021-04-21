using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DongolOfLegends.API.Models.Models.MatchHistory
{
    public class MatchParticipantIdentity
    {
        [Key]
        public long Id { get; set; }
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        [JsonProperty("player")]
        public MatchPlayer Player { get; set; }
    }
}

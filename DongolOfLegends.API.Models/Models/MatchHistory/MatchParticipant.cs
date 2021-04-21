using DongolOfLegends.API.Models.Models.Champions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DongolOfLegends.API.Models.Models.MatchHistory
{
    public class MatchParticipant
    {
        [Key]
        public long Id { get; set; }

        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        public Champion Champion { get; set; }

        [JsonProperty("spell1Id")]
        public int Spell1Id { get; set; }

        [JsonProperty("spell2Id")]
        public int Spell2Id { get; set; }

        [JsonProperty("stats")]
        public MatchStats Stats { get; set; }

        [JsonProperty("timeline")]
        public Timeline Timeline { get; set; }
    }
}

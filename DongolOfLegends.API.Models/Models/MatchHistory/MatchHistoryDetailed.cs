using DongolOfLegends.API.Models.Models.Champions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DongolOfLegends.API.Models.Models.MatchHistory
{
    public class MatchHistoryDetailed
    {
        public string PlatformId { get; set; }

        public MatchDetails Game { get; set; }

        public Champion Champion { get; set; }

        public MatchParticipant SearchedParticipant => Game.Participants.FirstOrDefault(p => p.ParticipantId == Game.ParticipantIdentities.FirstOrDefault(pi => pi.Player.AccountId == AccountId)?.ParticipantId);
        
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        public int Queue { get; set; }

        public int Season { get; set; }

        public long Timestamp { get; set; }

        public DateTime TimeOfGame { get => new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(Timestamp).ToLocalTime(); }

        public string Role { get; set; }

        public string Lane { get; set; }
    }
    public class SummonerMatchesDetailed
    {
        public List<MatchHistoryDetailed> DetailedMatches { get; set; }
        public string PlayerName { get; set; }
    }
}

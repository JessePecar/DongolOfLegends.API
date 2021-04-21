using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class MatchDetail
    {
        public MatchDetail()
        {
            MatchHistoryDetaileds = new HashSet<MatchHistoryDetailed>();
            MatchParticipants = new HashSet<MatchParticipant>();
            MatchParticipentIdentities = new HashSet<MatchParticipentIdentity>();
            Teams = new HashSet<Team>();
        }

        public long GameId { get; set; }
        public string PlatformId { get; set; }
        public long GameCreation { get; set; }
        public int GameDuration { get; set; }
        public int QueueId { get; set; }
        public int MapId { get; set; }
        public int SeasonId { get; set; }
        public string GameVersion { get; set; }
        public string GameMode { get; set; }
        public string GameType { get; set; }

        public virtual ICollection<MatchHistoryDetailed> MatchHistoryDetaileds { get; set; }
        public virtual ICollection<MatchParticipant> MatchParticipants { get; set; }
        public virtual ICollection<MatchParticipentIdentity> MatchParticipentIdentities { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}

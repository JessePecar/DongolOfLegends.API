using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class Team
    {
        public Team()
        {
            TeamBans = new HashSet<TeamBan>();
        }

        public long Id { get; set; }
        public int TeamId { get; set; }
        public string Win { get; set; }
        public bool FirstBlood { get; set; }
        public bool FirstTower { get; set; }
        public bool FirstInhibitor { get; set; }
        public bool FirstBaron { get; set; }
        public bool FirstDragon { get; set; }
        public bool FirstRiftHerald { get; set; }
        public int TowerKills { get; set; }
        public int InhibitorKills { get; set; }
        public int BaronKills { get; set; }
        public int DragonKills { get; set; }
        public int VilemawKills { get; set; }
        public int RiftHeraldKills { get; set; }
        public int DominionVictoryScore { get; set; }
        public long? MatchDetailsGameId { get; set; }

        public virtual MatchDetail MatchDetailsGame { get; set; }
        public virtual ICollection<TeamBan> TeamBans { get; set; }
    }
}

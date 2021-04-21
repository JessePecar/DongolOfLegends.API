using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class TeamBan
    {
        public long BanId { get; set; }
        public int ChampionId { get; set; }
        public int TeamId { get; set; }
        public int GameId { get; set; }
        public string ChampionName { get; set; }
        public long? TeamId1 { get; set; }

        public virtual Team TeamId1Navigation { get; set; }
    }
}

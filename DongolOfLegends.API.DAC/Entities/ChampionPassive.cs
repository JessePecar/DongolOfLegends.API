using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ChampionPassive
    {
        public long ChampionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long ImageId { get; set; }
        public string Version { get; set; }

        public virtual Champion Champion { get; set; }
        public virtual ChampionImage Image { get; set; }
    }
}

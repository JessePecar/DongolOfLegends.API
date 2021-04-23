using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ChampionTip
    {
        public long ChampionId { get; set; }
        public string TipType { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }

        public virtual Champion Champion { get; set; }
        public virtual TipType TipTypeNavigation { get; set; }
    }
}

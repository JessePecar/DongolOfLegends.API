using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ChampionTag
    {
        public long Id { get; set; }
        public string Tag { get; set; }
        public string ChampionId { get; set; }

        public virtual Champion Champion { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ChampionTagsLink
    {
        public string ChampionVersion { get; set; }
        public long ChampionId { get; set; }
        public string TagCode { get; set; }

        public virtual Champion Champion { get; set; }
        public virtual ChampionTag TagCodeNavigation { get; set; }
    }
}

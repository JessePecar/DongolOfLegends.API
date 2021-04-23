using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ChampionTag
    {
        public ChampionTag()
        {
            ChampionTagsLinks = new HashSet<ChampionTagsLink>();
        }

        public string Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ChampionTagsLink> ChampionTagsLinks { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class Champion
    {
        public Champion()
        {
            ChampionTags = new HashSet<ChampionTag>();
        }

        public string Id { get; set; }
        public string Version { get; set; }
        public long Key { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Blurb { get; set; }
        public long? InfoId { get; set; }
        public long? ImageId { get; set; }
        public string Partype { get; set; }
        public long? StatsId { get; set; }

        public virtual ChampionImage Image { get; set; }
        public virtual ChampionInfo Info { get; set; }
        public virtual ChampionsStat Stats { get; set; }
        public virtual ICollection<ChampionTag> ChampionTags { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class Champion
    {
        public Champion()
        {
            ChampionSkins = new HashSet<ChampionSkin>();
            ChampionSpells = new HashSet<ChampionSpell>();
            ChampionTagsLinks = new HashSet<ChampionTagsLink>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string RiotId { get; set; }
        public string Title { get; set; }
        public string Blurb { get; set; }
        public string Partype { get; set; }
        public long InfoId { get; set; }
        public long ImageId { get; set; }
        public long StatsId { get; set; }
        public string Lore { get; set; }

        public virtual ChampionImage Image { get; set; }
        public virtual ChampionInfo Info { get; set; }
        public virtual ChampionStat Stats { get; set; }
        public virtual ChampionPassive ChampionPassive { get; set; }
        public virtual ICollection<ChampionSkin> ChampionSkins { get; set; }
        public virtual ICollection<ChampionSpell> ChampionSpells { get; set; }
        public virtual ICollection<ChampionTagsLink> ChampionTagsLinks { get; set; }
    }
}

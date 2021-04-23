using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ChampionImage
    {
        public ChampionImage()
        {
            ChampionPassives = new HashSet<ChampionPassive>();
            ChampionSpells = new HashSet<ChampionSpell>();
            Champions = new HashSet<Champion>();
        }

        public long Id { get; set; }
        public string FullImageName { get; set; }
        public string Sprite { get; set; }
        public string Group { get; set; }
        public int XValue { get; set; }
        public int YValue { get; set; }
        public int WValue { get; set; }
        public int HValue { get; set; }
        public string ImageHref { get; set; }

        public virtual ICollection<ChampionPassive> ChampionPassives { get; set; }
        public virtual ICollection<ChampionSpell> ChampionSpells { get; set; }
        public virtual ICollection<Champion> Champions { get; set; }
    }
}

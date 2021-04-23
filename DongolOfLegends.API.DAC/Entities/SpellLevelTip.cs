using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class SpellLevelTip
    {
        public SpellLevelTip()
        {
            ChampionSpells = new HashSet<ChampionSpell>();
        }

        public string Code { get; set; }
        public string Effect { get; set; }

        public virtual ICollection<ChampionSpell> ChampionSpells { get; set; }
    }
}

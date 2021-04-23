using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class SpellRangeLink
    {
        public long SpellId { get; set; }
        public long SpellLevel { get; set; }
        public int Range { get; set; }

        public virtual ChampionSpell Spell { get; set; }
        public virtual SpellLevel SpellLevelNavigation { get; set; }
    }
}

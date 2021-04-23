using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class SpellCostLink
    {
        public long SpellId { get; set; }
        public long SpellLevel { get; set; }
        public int Cost { get; set; }

        public virtual ChampionSpell Spell { get; set; }
        public virtual SpellLevel SpellLevelNavigation { get; set; }
    }
}

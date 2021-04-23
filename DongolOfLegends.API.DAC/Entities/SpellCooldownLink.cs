using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class SpellCooldownLink
    {
        public long SpellId { get; set; }
        public long SpellLevel { get; set; }
        public decimal Cooldown { get; set; }

        public virtual ChampionSpell Spell { get; set; }
        public virtual SpellLevel SpellLevelNavigation { get; set; }
    }
}

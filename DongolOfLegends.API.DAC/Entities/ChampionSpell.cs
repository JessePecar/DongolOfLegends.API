using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ChampionSpell
    {
        public ChampionSpell()
        {
            SpellCooldownLinks = new HashSet<SpellCooldownLink>();
            SpellCostLinks = new HashSet<SpellCostLink>();
            SpellEffectBurnLinks = new HashSet<SpellEffectBurnLink>();
            SpellEffectLinks = new HashSet<SpellEffectLink>();
            SpellRangeLinks = new HashSet<SpellRangeLink>();
        }

        public long Id { get; set; }
        public string Version { get; set; }
        public long ChampionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tooltip { get; set; }
        public int MaxRank { get; set; }
        public string CooldownBurn { get; set; }
        public string CostBurn { get; set; }
        public string CostType { get; set; }
        public int MaxAmmo { get; set; }
        public string RangeBurn { get; set; }
        public string Resource { get; set; }
        public long ImageId { get; set; }
        public string LevelTipCode { get; set; }

        public virtual Champion Champion { get; set; }
        public virtual ChampionImage Image { get; set; }
        public virtual SpellLevelTip LevelTipCodeNavigation { get; set; }
        public virtual ICollection<SpellCooldownLink> SpellCooldownLinks { get; set; }
        public virtual ICollection<SpellCostLink> SpellCostLinks { get; set; }
        public virtual ICollection<SpellEffectBurnLink> SpellEffectBurnLinks { get; set; }
        public virtual ICollection<SpellEffectLink> SpellEffectLinks { get; set; }
        public virtual ICollection<SpellRangeLink> SpellRangeLinks { get; set; }
    }
}

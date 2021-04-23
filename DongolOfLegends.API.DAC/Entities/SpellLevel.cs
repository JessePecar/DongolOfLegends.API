using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class SpellLevel
    {
        public SpellLevel()
        {
            SpellCooldownLinks = new HashSet<SpellCooldownLink>();
            SpellCostLinks = new HashSet<SpellCostLink>();
            SpellEffectBurnLinks = new HashSet<SpellEffectBurnLink>();
            SpellEffectLinks = new HashSet<SpellEffectLink>();
            SpellRangeLinks = new HashSet<SpellRangeLink>();
        }

        public long Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SpellCooldownLink> SpellCooldownLinks { get; set; }
        public virtual ICollection<SpellCostLink> SpellCostLinks { get; set; }
        public virtual ICollection<SpellEffectBurnLink> SpellEffectBurnLinks { get; set; }
        public virtual ICollection<SpellEffectLink> SpellEffectLinks { get; set; }
        public virtual ICollection<SpellRangeLink> SpellRangeLinks { get; set; }
    }
}

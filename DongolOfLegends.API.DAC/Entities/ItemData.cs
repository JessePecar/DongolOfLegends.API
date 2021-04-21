using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ItemData
    {
        public ItemData()
        {
            ItemIntos = new HashSet<ItemInto>();
            ItemTags = new HashSet<ItemTag>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Colloq { get; set; }
        public string Plaintext { get; set; }
        public long? ImageId { get; set; }
        public long? GoldId { get; set; }
        public string MapsGameMode { get; set; }
        public long? StatsId { get; set; }
        public string ItemsVersion { get; set; }
        public long? MatchStatsId { get; set; }

        public virtual ItemGold Gold { get; set; }
        public virtual ItemImage Image { get; set; }
        public virtual Item ItemsVersionNavigation { get; set; }
        public virtual Map MapsGameModeNavigation { get; set; }
        public virtual MatchStat MatchStats { get; set; }
        public virtual ItemStat Stats { get; set; }
        public virtual ItemRune ItemRune { get; set; }
        public virtual ItemsEnabledMap ItemsEnabledMap { get; set; }
        public virtual ICollection<ItemInto> ItemIntos { get; set; }
        public virtual ICollection<ItemTag> ItemTags { get; set; }
    }
}

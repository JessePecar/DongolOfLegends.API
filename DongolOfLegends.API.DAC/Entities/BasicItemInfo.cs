using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class BasicItemInfo
    {
        public BasicItemInfo()
        {
            Items = new HashSet<Item>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public long? RuneId { get; set; }
        public long? GoldId { get; set; }
        public string Group { get; set; }
        public string Description { get; set; }
        public string Colloq { get; set; }
        public string Plaintext { get; set; }
        public bool Consumed { get; set; }
        public int Stacks { get; set; }
        public int Depth { get; set; }
        public bool ConsumeOnFull { get; set; }
        public int SpecialRecipe { get; set; }
        public bool InStore { get; set; }
        public bool HideFromAll { get; set; }
        public string RequiredChampion { get; set; }
        public string RequiredAlly { get; set; }
        public long? StatsId { get; set; }
        public long? MapsId { get; set; }

        public virtual ItemGold Gold { get; set; }
        public virtual ItemsEnabledMap Maps { get; set; }
        public virtual ItemRune Rune { get; set; }
        public virtual ItemStat Stats { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}

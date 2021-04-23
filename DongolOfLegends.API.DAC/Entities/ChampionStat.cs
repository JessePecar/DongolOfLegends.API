using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ChampionStat
    {
        public ChampionStat()
        {
            Champions = new HashSet<Champion>();
        }

        public long Id { get; set; }
        public decimal Hp { get; set; }
        public decimal HpPerLevel { get; set; }
        public decimal Mana { get; set; }
        public decimal ManaPerLevel { get; set; }
        public decimal MovementSpeed { get; set; }
        public decimal Armor { get; set; }
        public decimal ArmorPerLevel { get; set; }
        public decimal MagicResist { get; set; }
        public decimal MagicResistPerLevel { get; set; }
        public decimal AttackRange { get; set; }
        public decimal HpRegen { get; set; }
        public decimal HpRegenPerLevel { get; set; }
        public decimal ManaRegen { get; set; }
        public decimal ManaRegenPerLevel { get; set; }
        public decimal CriticalStrike { get; set; }
        public decimal CriticalStrikePerLevel { get; set; }
        public decimal AttackDamage { get; set; }
        public decimal AttackDamagePerLevel { get; set; }
        public decimal AttackSpeed { get; set; }
        public decimal AttackSpeedPerLevel { get; set; }

        public virtual ICollection<Champion> Champions { get; set; }
    }
}

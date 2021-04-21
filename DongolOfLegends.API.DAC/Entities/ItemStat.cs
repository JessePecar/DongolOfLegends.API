using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ItemStat
    {
        public ItemStat()
        {
            BasicItemInfos = new HashSet<BasicItemInfo>();
            ItemData = new HashSet<ItemData>();
        }

        public long Id { get; set; }
        public int FlatHppoolMod { get; set; }
        public int RflatHpmodPerLevel { get; set; }
        public int FlatMppoolMod { get; set; }
        public int RflatMpmodPerLevel { get; set; }
        public int PercentHppoolMod { get; set; }
        public int PercentMppoolMod { get; set; }
        public int FlatHpregenMod { get; set; }
        public int RflatHpregenModPerLevel { get; set; }
        public int PercentHpregenMod { get; set; }
        public int FlatMpregenMod { get; set; }
        public int RflatMpregenModPerLevel { get; set; }
        public int PercentMpregenMod { get; set; }
        public int FlatArmorMod { get; set; }
        public int RflatArmorModPerLevel { get; set; }
        public int PercentArmorMod { get; set; }
        public int RflatArmorPenetrationMod { get; set; }
        public int RflatArmorPenetrationModPerLevel { get; set; }
        public int RpercentArmorPenetrationMod { get; set; }
        public int RpercentArmorPenetrationModPerLevel { get; set; }
        public int FlatPhysicalDamageMod { get; set; }
        public int RflatPhysicalDamageModPerLevel { get; set; }
        public int PercentPhysicalDamageMod { get; set; }
        public int FlatMagicDamageMod { get; set; }
        public int RflatMagicDamageModPerLevel { get; set; }
        public int PercentMagicDamageMod { get; set; }
        public int FlatMovementSpeedMod { get; set; }
        public int RflatMovementSpeedModPerLevel { get; set; }
        public int PercentMovementSpeedMod { get; set; }
        public int RpercentMovementSpeedModPerLevel { get; set; }
        public int FlatAttackSpeedMod { get; set; }
        public int PercentAttackSpeedMod { get; set; }
        public int RpercentAttackSpeedModPerLevel { get; set; }
        public int RflatDodgeMod { get; set; }
        public int RflatDodgeModPerLevel { get; set; }
        public int PercentDodgeMod { get; set; }
        public int FlatCritChanceMod { get; set; }
        public int RflatCritChanceModPerLevel { get; set; }
        public int PercentCritChanceMod { get; set; }
        public int FlatCritDamageMod { get; set; }
        public int RflatCritDamageModPerLevel { get; set; }
        public int PercentCritDamageMod { get; set; }
        public int FlatBlockMod { get; set; }
        public int PercentBlockMod { get; set; }
        public int FlatSpellBlockMod { get; set; }
        public int RflatSpellBlockModPerLevel { get; set; }
        public int PercentSpellBlockMod { get; set; }
        public int FlatExpbonus { get; set; }
        public int PercentExpbonus { get; set; }
        public int RpercentCooldownMod { get; set; }
        public int RpercentCooldownModPerLevel { get; set; }
        public int RflatTimeDeadMod { get; set; }
        public int RflatTimeDeadModPerLevel { get; set; }
        public int RpercentTimeDeadMod { get; set; }
        public int RpercentTimeDeadModPerLevel { get; set; }
        public int RflatGoldPer10Mod { get; set; }
        public int RflatMagicPenetrationMod { get; set; }
        public int RflatMagicPenetrationModPerLevel { get; set; }
        public int RpercentMagicPenetrationMod { get; set; }
        public int RpercentMagicPenetrationModPerLevel { get; set; }
        public int FlatEnergyRegenMod { get; set; }
        public int RflatEnergyRegenModPerLevel { get; set; }
        public int FlatEnergyPoolMod { get; set; }
        public int RflatEnergyModPerLevel { get; set; }
        public int PercentLifeStealMod { get; set; }
        public int PercentSpellVampMod { get; set; }

        public virtual ICollection<BasicItemInfo> BasicItemInfos { get; set; }
        public virtual ICollection<ItemData> ItemData { get; set; }
    }
}

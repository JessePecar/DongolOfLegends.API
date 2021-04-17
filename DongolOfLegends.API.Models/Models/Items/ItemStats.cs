using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DongolOfLegends.API.Models.Models.Items
{
    public class ItemStats
    {
        [JsonProperty("FlatHPPoolMod")]
        public int FlatHPPoolMod { get; set; }

        [JsonProperty("rFlatHPModPerLevel")]
        public int RFlatHPModPerLevel { get; set; }

        [JsonProperty("FlatMPPoolMod")]
        public int FlatMPPoolMod { get; set; }

        [JsonProperty("rFlatMPModPerLevel")]
        public int RFlatMPModPerLevel { get; set; }

        [JsonProperty("PercentHPPoolMod")]
        public int PercentHPPoolMod { get; set; }

        [JsonProperty("PercentMPPoolMod")]
        public int PercentMPPoolMod { get; set; }

        [JsonProperty("FlatHPRegenMod")]
        public int FlatHPRegenMod { get; set; }

        [JsonProperty("rFlatHPRegenModPerLevel")]
        public int RFlatHPRegenModPerLevel { get; set; }

        [JsonProperty("PercentHPRegenMod")]
        public int PercentHPRegenMod { get; set; }

        [JsonProperty("FlatMPRegenMod")]
        public int FlatMPRegenMod { get; set; }

        [JsonProperty("rFlatMPRegenModPerLevel")]
        public int RFlatMPRegenModPerLevel { get; set; }

        [JsonProperty("PercentMPRegenMod")]
        public int PercentMPRegenMod { get; set; }

        [JsonProperty("FlatArmorMod")]
        public int FlatArmorMod { get; set; }

        [JsonProperty("rFlatArmorModPerLevel")]
        public int RFlatArmorModPerLevel { get; set; }

        [JsonProperty("PercentArmorMod")]
        public int PercentArmorMod { get; set; }

        [JsonProperty("rFlatArmorPenetrationMod")]
        public int RFlatArmorPenetrationMod { get; set; }

        [JsonProperty("rFlatArmorPenetrationModPerLevel")]
        public int RFlatArmorPenetrationModPerLevel { get; set; }

        [JsonProperty("rPercentArmorPenetrationMod")]
        public int RPercentArmorPenetrationMod { get; set; }

        [JsonProperty("rPercentArmorPenetrationModPerLevel")]
        public int RPercentArmorPenetrationModPerLevel { get; set; }

        [JsonProperty("FlatPhysicalDamageMod")]
        public int FlatPhysicalDamageMod { get; set; }

        [JsonProperty("rFlatPhysicalDamageModPerLevel")]
        public int RFlatPhysicalDamageModPerLevel { get; set; }

        [JsonProperty("PercentPhysicalDamageMod")]
        public int PercentPhysicalDamageMod { get; set; }

        [JsonProperty("FlatMagicDamageMod")]
        public int FlatMagicDamageMod { get; set; }

        [JsonProperty("rFlatMagicDamageModPerLevel")]
        public int RFlatMagicDamageModPerLevel { get; set; }

        [JsonProperty("PercentMagicDamageMod")]
        public int PercentMagicDamageMod { get; set; }

        [JsonProperty("FlatMovementSpeedMod")]
        public int FlatMovementSpeedMod { get; set; }

        [JsonProperty("rFlatMovementSpeedModPerLevel")]
        public int RFlatMovementSpeedModPerLevel { get; set; }

        [JsonProperty("PercentMovementSpeedMod")]
        public int PercentMovementSpeedMod { get; set; }

        [JsonProperty("rPercentMovementSpeedModPerLevel")]
        public int RPercentMovementSpeedModPerLevel { get; set; }

        [JsonProperty("FlatAttackSpeedMod")]
        public int FlatAttackSpeedMod { get; set; }

        [JsonProperty("PercentAttackSpeedMod")]
        public int PercentAttackSpeedMod { get; set; }

        [JsonProperty("rPercentAttackSpeedModPerLevel")]
        public int RPercentAttackSpeedModPerLevel { get; set; }

        [JsonProperty("rFlatDodgeMod")]
        public int RFlatDodgeMod { get; set; }

        [JsonProperty("rFlatDodgeModPerLevel")]
        public int RFlatDodgeModPerLevel { get; set; }

        [JsonProperty("PercentDodgeMod")]
        public int PercentDodgeMod { get; set; }

        [JsonProperty("FlatCritChanceMod")]
        public int FlatCritChanceMod { get; set; }

        [JsonProperty("rFlatCritChanceModPerLevel")]
        public int RFlatCritChanceModPerLevel { get; set; }

        [JsonProperty("PercentCritChanceMod")]
        public int PercentCritChanceMod { get; set; }

        [JsonProperty("FlatCritDamageMod")]
        public int FlatCritDamageMod { get; set; }

        [JsonProperty("rFlatCritDamageModPerLevel")]
        public int RFlatCritDamageModPerLevel { get; set; }

        [JsonProperty("PercentCritDamageMod")]
        public int PercentCritDamageMod { get; set; }

        [JsonProperty("FlatBlockMod")]
        public int FlatBlockMod { get; set; }

        [JsonProperty("PercentBlockMod")]
        public int PercentBlockMod { get; set; }

        [JsonProperty("FlatSpellBlockMod")]
        public int FlatSpellBlockMod { get; set; }

        [JsonProperty("rFlatSpellBlockModPerLevel")]
        public int RFlatSpellBlockModPerLevel { get; set; }

        [JsonProperty("PercentSpellBlockMod")]
        public int PercentSpellBlockMod { get; set; }

        [JsonProperty("FlatEXPBonus")]
        public int FlatEXPBonus { get; set; }

        [JsonProperty("PercentEXPBonus")]
        public int PercentEXPBonus { get; set; }

        [JsonProperty("rPercentCooldownMod")]
        public int RPercentCooldownMod { get; set; }

        [JsonProperty("rPercentCooldownModPerLevel")]
        public int RPercentCooldownModPerLevel { get; set; }

        [JsonProperty("rFlatTimeDeadMod")]
        public int RFlatTimeDeadMod { get; set; }

        [JsonProperty("rFlatTimeDeadModPerLevel")]
        public int RFlatTimeDeadModPerLevel { get; set; }

        [JsonProperty("rPercentTimeDeadMod")]
        public int RPercentTimeDeadMod { get; set; }

        [JsonProperty("rPercentTimeDeadModPerLevel")]
        public int RPercentTimeDeadModPerLevel { get; set; }

        [JsonProperty("rFlatGoldPer10Mod")]
        public int RFlatGoldPer10Mod { get; set; }

        [JsonProperty("rFlatMagicPenetrationMod")]
        public int RFlatMagicPenetrationMod { get; set; }

        [JsonProperty("rFlatMagicPenetrationModPerLevel")]
        public int RFlatMagicPenetrationModPerLevel { get; set; }

        [JsonProperty("rPercentMagicPenetrationMod")]
        public int RPercentMagicPenetrationMod { get; set; }

        [JsonProperty("rPercentMagicPenetrationModPerLevel")]
        public int RPercentMagicPenetrationModPerLevel { get; set; }

        [JsonProperty("FlatEnergyRegenMod")]
        public int FlatEnergyRegenMod { get; set; }

        [JsonProperty("rFlatEnergyRegenModPerLevel")]
        public int RFlatEnergyRegenModPerLevel { get; set; }

        [JsonProperty("FlatEnergyPoolMod")]
        public int FlatEnergyPoolMod { get; set; }

        [JsonProperty("rFlatEnergyModPerLevel")]
        public int RFlatEnergyModPerLevel { get; set; }

        [JsonProperty("PercentLifeStealMod")]
        public int PercentLifeStealMod { get; set; }

        [JsonProperty("PercentSpellVampMod")]
        public int PercentSpellVampMod { get; set; }
    }
}

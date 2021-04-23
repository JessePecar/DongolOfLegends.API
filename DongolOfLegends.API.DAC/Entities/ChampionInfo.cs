using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ChampionInfo
    {
        public ChampionInfo()
        {
            Champions = new HashSet<Champion>();
        }

        public long Id { get; set; }
        public decimal AttackLevel { get; set; }
        public decimal DefenseLevel { get; set; }
        public decimal MagicLevel { get; set; }
        public decimal Difficulty { get; set; }

        public virtual ICollection<Champion> Champions { get; set; }
    }
}

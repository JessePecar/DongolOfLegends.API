﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class ChampionsStat
    {
        public ChampionsStat()
        {
            Champions = new HashSet<Champion>();
        }

        public long Id { get; set; }
        public double Hp { get; set; }
        public double Hpperlevel { get; set; }
        public double Mp { get; set; }
        public double Mpperlevel { get; set; }
        public double Movespeed { get; set; }
        public double Armor { get; set; }
        public double Armorperlevel { get; set; }
        public double Spellblock { get; set; }
        public double Spellblockperlevel { get; set; }
        public double Attackrange { get; set; }
        public double Hpregen { get; set; }
        public double Hpregenperlevel { get; set; }
        public double Mpregen { get; set; }
        public double Mpregenperlevel { get; set; }
        public double Crit { get; set; }
        public double Critperlevel { get; set; }
        public double Attackdamage { get; set; }
        public double Attackdamageperlevel { get; set; }
        public double Attackspeedperlevel { get; set; }
        public double Attackspeed { get; set; }

        public virtual ICollection<Champion> Champions { get; set; }
    }
}
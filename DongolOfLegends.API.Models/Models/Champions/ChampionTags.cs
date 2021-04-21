using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DongolOfLegends.API.Models.Models.Champions
{
    public class ChampionTags
    {
        [Key]
        public long Id { get; set; }
        public string Tag { get; set; }
    }
}

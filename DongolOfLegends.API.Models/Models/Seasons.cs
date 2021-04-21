using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DongolOfLegends.API.Models.Models
{
    public class Seasons
    {
        [Key]
        public int Id { get; set; }
        public string Season { get; set; }
    }
}

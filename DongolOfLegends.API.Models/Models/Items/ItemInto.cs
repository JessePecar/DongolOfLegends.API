using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DongolOfLegends.API.Models.Models.Items
{
    public class ItemInto
    {
        [Key]
        public long Id { get; set; }
        public string Into { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DongolOfLegends.API.Models.Models
{
    public class Queues
    {
        [Key]
        public int QueueId { get; set; }
        public string Map { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
    }
}

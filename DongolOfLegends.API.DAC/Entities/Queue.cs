using System;
using System.Collections.Generic;

#nullable disable

namespace DongolOfLegends.API.DAC.Entities
{
    public partial class Queue
    {
        public int QueueId { get; set; }
        public string Map { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
    }
}

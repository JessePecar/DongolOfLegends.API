﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DongolOfLegends.API.Models.Models
{
    public class Maps
    {
        [Key]
        public string GameMode { get; set; }
        public string Description { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.Models
{
    public class Work : BaseEntity
    {
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Image { get; set; }
    }
}

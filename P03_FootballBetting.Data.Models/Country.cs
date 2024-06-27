﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_FootballBetting.Data.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<Town> Towns { get; set; } = new HashSet<Town>();
    }
}

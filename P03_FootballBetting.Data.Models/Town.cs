using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_FootballBetting.Data.Models
{
    public class Town
    {
        public int TownId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CountryId { get; set; }
        public virtual Country Country { get; set; } = new Country();
        public virtual ICollection<Team> Teams { get; set; } = new HashSet<Team>();
    }
}

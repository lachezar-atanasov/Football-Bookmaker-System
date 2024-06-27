using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_FootballBetting.Data.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int SquadNumber { get; set; }

        public int TeamId { get; set; }
        public virtual Team Team { get; set; } = new Team();

        public int PositionId { get; set; }

        public virtual Position Position { get; set; } = new Position();

        public bool IsInjured { get; set; }

    }
}

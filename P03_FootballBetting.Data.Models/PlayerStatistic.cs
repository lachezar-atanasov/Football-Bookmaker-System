using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_FootballBetting.Data.Models
{
    public class PlayerStatistic
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public virtual Game Game { get; set; } = new Game(); 
        public int PlayerId { get; set; }
        public Player Player { get; set; } = new Player();
        public int ScoredGoals { get; set; }
        public int Assists { get; set; }
        public int MinutesPlayed { get; set; }

    }
}

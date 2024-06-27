using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace P03_FootballBetting.Data.Models
{
    public class Game
    {
        public int GameId { get; set; }

        public int HomeTeamId { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)] public Team HomeTeam { get; set; } = new Team();

        public int AwayTeamId { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)] public Team AwayTeam { get; set; } = new Team();

        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }
        public DateTime DateTime { get; set; }
        public double HomeTeamBetRate { get; set; }
        public double AwayTeamBetRate { get; set; }
        public double DrawBetRate { get; set; }
        public string Result { get; set; } = string.Empty;

        public virtual ICollection<PlayerStatistic> PlayerStatistics { get; set; } = new HashSet<PlayerStatistic>();
        public virtual ICollection<Bet> Bets { get; set; } = new HashSet<Bet>();
    }
}

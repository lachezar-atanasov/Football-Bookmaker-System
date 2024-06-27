using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P03_FootballBetting.Data.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LogoUrl { get; set; } = string.Empty;
        [MaxLength(10)]
        public string Initials { get; set; } = string.Empty;
        public decimal Budget { get; set; }
        public int PrimaryKitColorId { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)] public virtual Color PrimaryKitColor { get; set; } = new Color();
        
        public int SecondaryKitColorId { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)] public virtual Color SecondaryKitColor { get; set; } = new Color();
        public int TownId { get; set; }
        public virtual Town Town { get; set; } = new Town();
        [InverseProperty(nameof(Game.HomeTeam))]
        public virtual ICollection<Game> HomeGames { get; set; } = new HashSet<Game>();
        [InverseProperty(nameof(Game.AwayTeam))]
        public virtual ICollection<Game> AwayGames { get; set; } = new HashSet<Game>();
    }
}

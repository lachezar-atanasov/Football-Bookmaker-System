using P03_FootballBetting.Data;
using P03_FootballBetting.Data.Models;

namespace P03_FootballBetting
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var context = new FootballBettingContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var redColor = new Color()
            {
                Name = "Red"
            };

            context.Bets.Add(
                new Bet()
                {
                    Amount = 100.0d,
                    DateTime = DateTime.Now,
                    Game = new Game()
                    {
                        AwayTeam = new Team()
                        {
                            Budget = 10000m,
                            Initials = "JUV",
                            LogoUrl = "http://google.com/",
                            PrimaryKitColor = redColor,
                            SecondaryKitColor = new Color()
                            {
                                Name = "Blue"
                            },
                            Name = "Juventus",
                            Town = new Town()
                            {
                                Country = new Country()
                                {
                                    Name = "Spain"
                                }
                            }
                        },
                        HomeTeam = new Team()
                        {
                            Budget = 20000m,
                            Initials = "LIV",
                            LogoUrl = "http://google.com/",
                            PrimaryKitColor = redColor,
                            SecondaryKitColor = new Color()
                            {
                                Name = "Yellow"
                            },
                            Name = "Liverpool",
                            Town = new Town()
                            {
                                Country = new Country()
                                {
                                    Name = "Bulgaria"
                                }
                            }
                        },
                        AwayTeamBetRate = 1.45,
                        DrawBetRate = 4.5,
                        HomeTeamBetRate = 3.45,
                        AwayTeamGoals = 3,
                        HomeTeamGoals = 6,
                        DateTime = DateTime.Now,
                        Result = "1/1"
                    },
                    User = new User()
                    {
                        Balance = 100.0m,
                        Email = "luchi507@abv.bg",
                        Name = "Lachezar",
                        Password = "NoPassword",
                        Username = "Bolonkata13"
                    },
                    Prediction = 1
                });
            context.SaveChanges();
        }
    }
}

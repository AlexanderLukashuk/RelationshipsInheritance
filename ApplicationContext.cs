using Microsoft.EntityFrameworkCore;

namespace FootballManager
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<NationalTeam> NationalTeams { get; set; }

        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost; Database = soccer; User ID = postgres; Password = postgres;");
        }
    }
}
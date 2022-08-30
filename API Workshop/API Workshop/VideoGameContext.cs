using Microsoft.EntityFrameworkCore;

namespace API_Workshop
{
    public class VideoGameContext : DbContext
    {
        public DbSet<VideoGame> VideoGames { get; set; }
        public DbSet<Studio> Studios { get; set; }
        public DbSet<MainCharacter> MainCharacters { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<GameTag> GameTags { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=VGDB_example;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // insert seed data here

            base.OnModelCreating(modelBuilder);
        }
    }
}

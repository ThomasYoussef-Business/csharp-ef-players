namespace CS_Entity_Framework_Players {
    public class PlayersDbContext : DbContext {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=localhost;" +
                "Initial Catalog=EFPlayers;" +
                "Integrated Security=True;" +
                "TrustServerCertificate=True");
        }
    }
}
public class PlayersDbContext : DbContext {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlServer("Data Source=localhost;" +
            "Initial Catalog=EFPlayers;" +
            "Integrated Security=True");
    }
}
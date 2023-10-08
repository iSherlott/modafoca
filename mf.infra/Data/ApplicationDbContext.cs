using mf.domain.Entities;
using mf.infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace mf.infra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Minecraft> Minecraft { get; set; }
        public DbSet<Discord> Discord { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("public");

            modelBuilder.ApplyConfiguration(new MinecraftMapping());
            modelBuilder.ApplyConfiguration(new DiscordMapping());

        }
    }
}

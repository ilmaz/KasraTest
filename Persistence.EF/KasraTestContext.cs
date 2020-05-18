using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence.EF
{
    public class KasraTestContext : DbContext
    {
        public DbSet<StdScore> StdScores { get; set; }
        public KasraTestContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Mappings.StdScoreMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}

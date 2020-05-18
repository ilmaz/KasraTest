using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EF.Mappings
{
    public class StdScoreMapping : IEntityTypeConfiguration<StdScore>
    {
        public void Configure(EntityTypeBuilder<StdScore> builder)
        {
            builder.ToTable("std_Score").HasKey(a => a.StudentId);
            builder.Property(a => a.StudentId).HasColumnName("Student_ID");
            builder.Property(a => a.Score).HasColumnType("decimal(4, 2)");
        }
    }
}

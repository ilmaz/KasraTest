using Microsoft.EntityFrameworkCore;

namespace Persistence.EF
{
    public static class DbContextOptionsConfigurator
    {
        public static void ConfigForKasraTest(this DbContextOptionsBuilder builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}

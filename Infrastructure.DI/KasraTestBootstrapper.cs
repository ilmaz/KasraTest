using Application.StdScore;
using Domain.Models;
using Microsoft.Extensions.DependencyInjection;
using Persistence.EF;
using Persistence.EF.Repositories;

namespace Infrastructure.DI
{
    public static class KasraTestBootstrapper
    {
        public static void Init(this IServiceCollection services, KasraTestOptions options)
        {
            services.AddScoped<IStdScoreRepository, StdScoreRepository>();
            services.AddScoped<IStdScoreService, StdScoreService>();
            services.AddDbContext<KasraTestContext>(a => a.ConfigForKasraTest(options.ConnectionString));
        }
    }
}

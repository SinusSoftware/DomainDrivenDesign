using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;


namespace DomainDrivenDesign.Persistence
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSQLServerRepositories(this IServiceCollection services, string connectionString, int poolSize, bool debug = false)
        {
            services.AddDbContextPool<Context>(options =>
            {
                options.UseSqlServer(connectionString, options =>
                {
                    options.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
                });

                options.LogTo(m => Debug.WriteLine(m));

                if (debug)
                {
                    options.EnableDetailedErrors();
                    options.EnableSensitiveDataLogging();
                }
            }, poolSize);

            return services.AddRepositories();
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            // SqlServerRepositories have to be declared with a transient or scoped
            // lifetime because the underlying DbContext would be shared in multiple
            // request cycles. Take care to manage repositories in Singletons.
            return services;
        }

    }

  
}

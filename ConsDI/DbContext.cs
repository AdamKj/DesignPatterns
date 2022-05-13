using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ConsDI;
public class MssqlDbContext
{
    private DbContextOptions _options;

    public MssqlDbContext(IOptions<DbContextOptions> options, ILogger<MssqlDbContext> logger)
    {
        _options = options.Value;
    }

    //public MssqlDbContext(string connString, ScopedService scopedService)
    //{
    //}
}

public class DbContextOptions
{
    public string ConnectionString { get; set; }
}

public static class ServicesExtensions
{
    public static void AddDbContext(this IServiceCollection services, Action<DbContextOptions> configureDbContextOptions)
    {
        services.Configure(configureDbContextOptions);
        services.AddScoped<MssqlDbContext>();

        //var dbContext = new MssqlDbContext("connection string", sp.GetRequiredService<ScopedService>());
        //services.AddSingleton<MssqlDbContext>(dbContext);
        //services.AddScoped<MssqlDbContext>(sp => new MssqlDbContext("connection string", sp.GetRequiredService<ScopedService>()));
    }
}

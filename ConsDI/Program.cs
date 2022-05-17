using ConsDI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using var serviceProvider = ConfigureServices().BuildServiceProvider();
//serviceProvider.GetRequiredService<GetServiceProviderExample>().Run();
serviceProvider.GetRequiredService<SingletonService>().Run();

//using var scope = serviceProvider.CreateScope();
//scope.ServiceProvider.GetRequiredService<GetServiceProviderExample>().Run();

IServiceCollection ConfigureServices()
{
    var config = ConfigureBuild();
    var services = new ServiceCollection();
    services.AddLogging(opt =>
    {
        opt.AddConsole();
    });

    services.AddDbContext(opt => opt.ConnectionString =  "hello"/*config.GetConnectionString("DefaultConnection")*/);

    services.AddTransient<GetServiceProviderExample>();
    services.AddScoped<ScopedService>();
    services.AddSingleton<SingletonService>();

    ////services.Configure<TokenOptions>(config.GetSection(TokenOptions.SectionName));
    //var apiSection = config.GetSection(ApiUrls.SectionName);

    //var tokenSection = config.GetSection(TokenOptions.SectionName);
    //var tokenOptions = tokenSection.Get<TokenOptions>();
    //services.Configure<TokenOptions>(tokenSection);
    //var apiUrls = apiSection.Get<ApiUrls>();
    //Console.WriteLine(apiUrls.FrolundaApi);

    //services.AddScoped(sp => new HttpClient() { BaseAddress = new Uri(apiUrls.FrolundaApi) });
    //services.AddScoped(sp => new HttpClient() { BaseAddress = new Uri(apiUrls.FrolundaApiV2) });
    return services;
}

IConfigurationRoot ConfigureBuild() =>
  new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

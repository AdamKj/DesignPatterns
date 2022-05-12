using ConsDI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

var serviceProvider = ConfigureServices().BuildServiceProvider();
serviceProvider.GetRequiredService<GetServiceProviderExample>().Run();

using var scope = serviceProvider.CreateScope();
scope.ServiceProvider.GetRequiredService<GetServiceProviderExample>().Run();

IServiceCollection ConfigureServices()
{
    var services = new ServiceCollection();
    services.AddLogging(opt => opt.AddConsole());
    services.AddTransient<GetServiceProviderExample>();

    var config = ConfigureBuild();

    return services;
}

IConfigurationRoot ConfigureBuild() =>
  new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

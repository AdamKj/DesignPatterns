using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

var serviceProvider = ConfigureServices().BuildServiceProvider();

IServiceCollection ConfigureServices()
{
    var services = new ServiceCollection();
    services.AddLogging(opt => opt.AddConsole());

    var config = ConfigureBuild();

    return services;
}

IConfigurationRoot ConfigureBuild() =>
  new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

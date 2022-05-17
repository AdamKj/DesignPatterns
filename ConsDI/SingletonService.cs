using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace ConsDI;

public class SingletonService
{
    private IServiceScopeFactory _serviceProvider;

    public SingletonService(IServiceScopeFactory serviceProvider, IOptions<TokenOptions> options)
    {
        Console.WriteLine(options.Value.SecretKey);
        _serviceProvider = serviceProvider;
    }

    public void Run()
    {
        // create a scope and get scoped service
        using var scope = _serviceProvider.CreateScope();
        var scopedService = scope.ServiceProvider.GetRequiredService<ScopedService>();
        Console.WriteLine("Hello");
    }
}
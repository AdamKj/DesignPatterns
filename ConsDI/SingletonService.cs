using Microsoft.Extensions.DependencyInjection;

namespace ConsDI
{
    public class SingletonService
    {
        private IServiceScopeFactory _serviceProvider;

        public SingletonService(IServiceScopeFactory serviceProvider)
        {
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
}

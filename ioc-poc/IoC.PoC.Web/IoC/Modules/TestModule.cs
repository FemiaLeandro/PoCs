using IoC.PoC.Web.IoC.Abstractions;
using IoC.PoC.Web.Services;

namespace IoC.PoC.Web.IoC.Modules
{
    public class TestModule : IDependencyModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ITestService, TestService>();
        }
    }
}

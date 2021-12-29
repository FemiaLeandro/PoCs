using IoC.PoC.Web.IoC;
using System.Reflection;

namespace IoC.PoC.Web.Configuration
{
    public static class ConfigurationExtensions
    {
        public static void ConfigureIoC(this IServiceCollection serviceCollection)
        {
            serviceCollection.LoadDependencies(Assembly.GetCallingAssembly());
        }
    }
}

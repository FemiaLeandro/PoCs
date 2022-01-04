using IoC.PoC.Web.IoC.Abstractions;
using System.Reflection;

namespace IoC.PoC.Web.IoC
{
    public static class Loader
    {
        private const string MethodName = "Load";

        public static void LoadDependencies(this IServiceCollection services, Assembly assembly)
        {
            var types = assembly
                .GetTypes()
                .Where(x => x.GetInterfaces().Contains(typeof(IDependencyModule)));

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);

                var method = Array.Find(
                    type.GetMethods(),
                    m => m.Name == MethodName);

                method!.Invoke(instance, new object[] { services });
            }
        }
    }
}

namespace IoC.PoC.Web.IoC.Abstractions
{
    public interface IDependencyModule
    {
        void Load(IServiceCollection serviceCollection);
    }
}

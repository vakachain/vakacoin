using Autofac;

namespace Vakacoin.Core.Modules
{
    public interface IAutofacModule
    {
        void Init(ContainerBuilder builder);
        void Run(ILifetimeScope scope);
    }
}
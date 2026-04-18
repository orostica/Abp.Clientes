using Volo.Abp.Modularity;

namespace Abp.Clientes;

/* Inherit from this class for your domain layer tests. */
public abstract class ClientesDomainTestBase<TStartupModule> : ClientesTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

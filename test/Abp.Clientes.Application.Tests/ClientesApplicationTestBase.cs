using Volo.Abp.Modularity;

namespace Abp.Clientes;

public abstract class ClientesApplicationTestBase<TStartupModule> : ClientesTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

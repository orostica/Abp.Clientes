using Volo.Abp.Modularity;

namespace Abp.Clientes;

[DependsOn(
    typeof(ClientesDomainModule),
    typeof(ClientesTestBaseModule)
)]
public class ClientesDomainTestModule : AbpModule
{

}

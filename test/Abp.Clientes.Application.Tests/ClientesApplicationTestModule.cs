using Volo.Abp.Modularity;

namespace Abp.Clientes;

[DependsOn(
    typeof(ClientesApplicationModule),
    typeof(ClientesDomainTestModule)
)]
public class ClientesApplicationTestModule : AbpModule
{

}

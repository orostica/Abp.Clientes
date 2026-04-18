using Abp.Clientes.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Abp.Clientes.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ClientesEntityFrameworkCoreModule),
    typeof(ClientesApplicationContractsModule)
)]
public class ClientesDbMigratorModule : AbpModule
{
}

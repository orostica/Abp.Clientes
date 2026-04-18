using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Abp.Clientes.Data;

/* This is used if database provider does't define
 * IClientesDbSchemaMigrator implementation.
 */
public class NullClientesDbSchemaMigrator : IClientesDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

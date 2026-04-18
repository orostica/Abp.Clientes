using System.Threading.Tasks;

namespace Abp.Clientes.Data;

public interface IClientesDbSchemaMigrator
{
    Task MigrateAsync();
}

using Xunit;
using Abp.Clientes.Clientes;

namespace Abp.Clientes.EntityFrameworkCore.Applications.Clientes;

[Collection(ClientesTestConsts.CollectionDefinitionName)]
public class EfCoreClienteAppService_Tests : ClienteAppService_Tests<ClientesEntityFrameworkCoreTestModule>
{

}

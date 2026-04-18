using Xunit;

namespace Abp.Clientes.EntityFrameworkCore;

[CollectionDefinition(ClientesTestConsts.CollectionDefinitionName)]
public class ClientesEntityFrameworkCoreCollection : ICollectionFixture<ClientesEntityFrameworkCoreFixture>
{

}

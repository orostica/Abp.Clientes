using Abp.Clientes.Samples;
using Xunit;

namespace Abp.Clientes.EntityFrameworkCore.Domains;

[Collection(ClientesTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ClientesEntityFrameworkCoreTestModule>
{

}

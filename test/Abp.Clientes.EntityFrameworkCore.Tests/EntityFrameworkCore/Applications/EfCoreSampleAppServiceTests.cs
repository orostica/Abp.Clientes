using Abp.Clientes.Samples;
using Xunit;

namespace Abp.Clientes.EntityFrameworkCore.Applications;

[Collection(ClientesTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ClientesEntityFrameworkCoreTestModule>
{

}

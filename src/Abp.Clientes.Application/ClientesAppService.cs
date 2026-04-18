using Abp.Clientes.Localization;
using Volo.Abp.Application.Services;

namespace Abp.Clientes;

/* Inherit your application services from this class.
 */
public abstract class ClientesAppService : ApplicationService
{
    protected ClientesAppService()
    {
        LocalizationResource = typeof(ClientesResource);
    }
}

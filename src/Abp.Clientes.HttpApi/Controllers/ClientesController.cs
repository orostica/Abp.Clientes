using Abp.Clientes.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Clientes.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ClientesController : AbpControllerBase
{
    protected ClientesController()
    {
        LocalizationResource = typeof(ClientesResource);
    }
}

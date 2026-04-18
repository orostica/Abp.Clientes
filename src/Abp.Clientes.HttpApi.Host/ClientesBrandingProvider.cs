using Microsoft.Extensions.Localization;
using Abp.Clientes.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Abp.Clientes;

[Dependency(ReplaceServices = true)]
public class ClientesBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<ClientesResource> _localizer;

    public ClientesBrandingProvider(IStringLocalizer<ClientesResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}

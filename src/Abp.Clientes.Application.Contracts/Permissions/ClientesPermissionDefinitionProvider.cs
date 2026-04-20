using Abp.Clientes.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Abp.Clientes.Permissions;

public class ClientesPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var clientesGroup = context.AddGroup(ClientesPermissions.GroupName, L("Permission:ClientesCRUD"));

        //Dashboard permissions
        //clientesGroup.AddPermission(ClientesPermissions.Dashboard.Host, L("Permission:Dashboard"), MultiTenancySides.Host);
        //clientesGroup.AddPermission(ClientesPermissions.Dashboard.Tenant, L("Permission:Dashboard"), MultiTenancySides.Tenant);

        //Books permissions
        var booksPermission = clientesGroup.AddPermission(ClientesPermissions.Clientes.Default, L("Permission:Clientes"));
        booksPermission.AddChild(ClientesPermissions.Clientes.Create, L("Permission:Clientes.Create"));
        booksPermission.AddChild(ClientesPermissions.Clientes.Edit, L("Permission:Clientes.Edit"));
        booksPermission.AddChild(ClientesPermissions.Clientes.Delete, L("Permission:Clientes.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ClientesPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ClientesResource>(name);
    }
}

using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace JD.Invoicing.Authorization
{
    public class InvoicingAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Goods, L("Goods"));
            context.CreatePermission(PermissionNames.Pages_Customer, L("Customer"));
            context.CreatePermission(PermissionNames.Pages_Warehouse, L("Warehouse"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, InvoicingConsts.LocalizationSourceName);
        }
    }
}

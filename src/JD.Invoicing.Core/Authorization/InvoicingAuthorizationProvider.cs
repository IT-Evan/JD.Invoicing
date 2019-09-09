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
            context.CreatePermission(PermissionNames.Pages_PurchaseOrder, L("PurchaseOrder"));
            context.CreatePermission(PermissionNames.Pages_PurchaseWarehousing, L("PurchaseWarehousing"));
            context.CreatePermission(PermissionNames.Pages_PurchaseReturn, L("PurchaseReturn"));
            context.CreatePermission(PermissionNames.Pages_SalesOrder, L("SalesOrder"));
            context.CreatePermission(PermissionNames.Pages_SalesReturn, L("SalesReturn"));
            context.CreatePermission(PermissionNames.Pages_Loss, L("Loss"));
            context.CreatePermission(PermissionNames.Pages_Profit, L("Profit"));
            context.CreatePermission(PermissionNames.Pages_InventoryInfo, L("InventoryInfo"));
            context.CreatePermission(PermissionNames.Pages_InventoryCheck, L("InventoryCheck"));
            context.CreatePermission(PermissionNames.Pages_InventoryTransfer, L("InventoryTransfer"));
            context.CreatePermission(PermissionNames.Pages_ProfitLossReport, L("ProfitLossReport"));
            context.CreatePermission(PermissionNames.Pages_ProcurementStatisticsReport, L("ProcurementStatisticsReport"));
            context.CreatePermission(PermissionNames.Pages_ProcurementAnalysisReport, L("ProcurementAnalysisReport"));
            context.CreatePermission(PermissionNames.Pages_ProcurementDetailReport, L("ProcurementDetailReport"));
            context.CreatePermission(PermissionNames.Pages_SalesStatisticsReport, L("SalesStatisticsReport"));
            context.CreatePermission(PermissionNames.Pages_SalesAnalysisReport, L("SalesAnalysisReport"));
            context.CreatePermission(PermissionNames.Pages_SalesDetailReport, L("SalesDetailReport"));
            context.CreatePermission(PermissionNames.Pages_GrossStatisticsReport, L("GrossStatisticsReport"));
            context.CreatePermission(PermissionNames.Pages_GrossAnalysisReport, L("GrossAnalysisReport"));
            context.CreatePermission(PermissionNames.Pages_GrossDetailReport, L("GrossDetailReport"));
    }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, InvoicingConsts.LocalizationSourceName);
        }
    }
}

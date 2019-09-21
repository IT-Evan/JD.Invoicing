using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace JD.Invoicing.Authorization
{
    public class InvoicingAuthorizationProvider : AuthorizationProvider
    {
        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, InvoicingConsts.LocalizationSourceName);
        }
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //Level 1
            context.CreatePermission(PermissionNames.Pages_Home, L("HomePage"));
            context.CreatePermission(PermissionNames.Pages_Data, L("Data"));
            context.CreatePermission(PermissionNames.Pages_Operation, L("Operation"));
            context.CreatePermission(PermissionNames.Pages_Report, L("Report"));
            context.CreatePermission(PermissionNames.Pages_Setting, L("Setting"));
            context.CreatePermission(PermissionNames.Pages_About, L("About"));
            //Level 2
            context.GetPermissionOrNull(PermissionNames.Pages_Data).CreateChildPermission(PermissionNames.Pages_Goods, L("Goods"));
            context.GetPermissionOrNull(PermissionNames.Pages_Data).CreateChildPermission(PermissionNames.Pages_Customer, L("Customer"));
            context.GetPermissionOrNull(PermissionNames.Pages_Data).CreateChildPermission(PermissionNames.Pages_Warehouse, L("Warehouse"));

            context.GetPermissionOrNull(PermissionNames.Pages_Operation).CreateChildPermission(PermissionNames.Pages_Purchase, L("Purchase"));
            context.GetPermissionOrNull(PermissionNames.Pages_Operation).CreateChildPermission(PermissionNames.Pages_Sales, L("Sales"));
            context.GetPermissionOrNull(PermissionNames.Pages_Operation).CreateChildPermission(PermissionNames.Pages_Inventory, L("Inventory"));

            context.GetPermissionOrNull(PermissionNames.Pages_Report).CreateChildPermission(PermissionNames.Pages_ProcurementStatisticsReport, L("ProcurementStatisticsReport"));
            context.GetPermissionOrNull(PermissionNames.Pages_Report).CreateChildPermission(PermissionNames.Pages_ProcurementAnalysisReport, L("ProcurementAnalysisReport"));
            context.GetPermissionOrNull(PermissionNames.Pages_Report).CreateChildPermission(PermissionNames.Pages_ProcurementDetailReport, L("ProcurementDetailReport"));
            context.GetPermissionOrNull(PermissionNames.Pages_Report).CreateChildPermission(PermissionNames.Pages_SalesStatisticsReport, L("SalesStatisticsReport"));
            context.GetPermissionOrNull(PermissionNames.Pages_Report).CreateChildPermission(PermissionNames.Pages_SalesAnalysisReport, L("SalesAnalysisReport"));
            context.GetPermissionOrNull(PermissionNames.Pages_Report).CreateChildPermission(PermissionNames.Pages_SalesDetailReport, L("SalesDetailReport"));
            context.GetPermissionOrNull(PermissionNames.Pages_Report).CreateChildPermission(PermissionNames.Pages_GrossStatisticsReport, L("GrossStatisticsReport"));
            context.GetPermissionOrNull(PermissionNames.Pages_Report).CreateChildPermission(PermissionNames.Pages_GrossAnalysisReport, L("GrossAnalysisReport"));
            context.GetPermissionOrNull(PermissionNames.Pages_Report).CreateChildPermission(PermissionNames.Pages_GrossDetailReport, L("GrossDetailReport"));

            context.GetPermissionOrNull(PermissionNames.Pages_Setting).CreateChildPermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            context.GetPermissionOrNull(PermissionNames.Pages_Setting).CreateChildPermission(PermissionNames.Pages_Users, L("Users"));
            context.GetPermissionOrNull(PermissionNames.Pages_Setting).CreateChildPermission(PermissionNames.Pages_Roles, L("Roles"));
            //Level 3
            context.GetPermissionOrNull(PermissionNames.Pages_Operation).Children[0].CreateChildPermission(PermissionNames.Pages_PO, L("PO"));
            context.GetPermissionOrNull(PermissionNames.Pages_Operation).Children[0].CreateChildPermission(PermissionNames.Pages_InStore, L("InStore"));
            context.GetPermissionOrNull(PermissionNames.Pages_Operation).Children[0].CreateChildPermission(PermissionNames.Pages_OutStore, L("OutStore"));

            context.GetPermissionOrNull(PermissionNames.Pages_Operation).Children[1].CreateChildPermission(PermissionNames.Pages_SalesOrder, L("SalesOrder"));
            context.GetPermissionOrNull(PermissionNames.Pages_Operation).Children[1].CreateChildPermission(PermissionNames.Pages_SalesReturn, L("SalesReturn"));

            context.GetPermissionOrNull(PermissionNames.Pages_Operation).Children[2].CreateChildPermission(PermissionNames.Pages_Loss, L("Loss"));
            context.GetPermissionOrNull(PermissionNames.Pages_Operation).Children[2].CreateChildPermission(PermissionNames.Pages_Profit, L("Profit"));
            context.GetPermissionOrNull(PermissionNames.Pages_Operation).Children[2].CreateChildPermission(PermissionNames.Pages_InventoryInfo, L("InventoryInfo"));
            context.GetPermissionOrNull(PermissionNames.Pages_Operation).Children[2].CreateChildPermission(PermissionNames.Pages_InventoryCheck, L("InventoryCheck"));
            context.GetPermissionOrNull(PermissionNames.Pages_Operation).Children[2].CreateChildPermission(PermissionNames.Pages_InventoryTransfer, L("InventoryTransfer"));
            context.GetPermissionOrNull(PermissionNames.Pages_Operation).Children[2].CreateChildPermission(PermissionNames.Pages_ProfitLossReport, L("ProfitLossReport"));
        }
    }
}

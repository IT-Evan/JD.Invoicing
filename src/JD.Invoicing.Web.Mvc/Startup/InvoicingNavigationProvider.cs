using Abp.Application.Navigation;
using Abp.Localization;
using JD.Invoicing.Authorization;

namespace JD.Invoicing.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class InvoicingNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: "home",
                        requiresAuthentication: true
                    )
                )
                .AddItem( // Menu items below is just for demonstration!
                    new MenuItemDefinition(
                        "Data",
                        L("Data"),
                        icon: "storage"
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.Goods,
                            L("Goods"),
                            url: "Goods",
                            requiredPermissionName: PermissionNames.Pages_Goods
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.Customer,
                            L("Customer"),
                            url: "Customer",
                            requiredPermissionName: PermissionNames.Pages_Customer
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.Warehouse,
                            L("Warehouse"),
                            url: "Warehouse",
                            requiredPermissionName: PermissionNames.Pages_Warehouse
                        )
                    )
                )
                .AddItem( // Menu items below is just for demonstration!
                    new MenuItemDefinition(
                        "Operation",
                        L("Operation"),
                        icon: "business"
                    ).AddItem(
                        new MenuItemDefinition(
                            "Purchase",
                            L("Purchase"),
                            url: "Purchase"
                        ).AddItem(
                        new MenuItemDefinition(
                            PageNames.PO,
                            L("PO"),
                            url: "PO",
                            requiredPermissionName: PermissionNames.Pages_PO
                        )).AddItem(
                        new MenuItemDefinition(
                            PageNames.InStore,
                            L("InStore"),
                            url: "InStore",
                            requiredPermissionName: PermissionNames.Pages_InStore
                        )).AddItem(
                        new MenuItemDefinition(
                            PageNames.OutStore,
                            L("OutStore"),
                            url: "OutStore",
                            requiredPermissionName: PermissionNames.Pages_OutStore
                        ))
                    ).AddItem(
                        new MenuItemDefinition(
                            "Sales",
                            L("Sales"),
                            url: "Sales"
                        ).AddItem(
                            new MenuItemDefinition(
                                PageNames.SalesOrder,
                                L("SalesOrder"),
                                url: "SalesOrder",
                            requiredPermissionName: PermissionNames.Pages_SalesOrder
                            )).AddItem(
                            new MenuItemDefinition(
                                PageNames.SalesReturn,
                                L("SalesReturn"),
                                url: "SalesReturn",
                            requiredPermissionName: PermissionNames.Pages_SalesReturn
                            ))
                    ).AddItem(
                        new MenuItemDefinition(
                            "Inventory",
                            L("Inventory"),
                            url: "Inventory"
                        ).AddItem(
                        new MenuItemDefinition(
                            PageNames.Loss,
                            L("Loss"),
                            url: "Loss",
                            requiredPermissionName: PermissionNames.Pages_Loss
                        )).AddItem(
                        new MenuItemDefinition(
                            PageNames.Profit,
                            L("Profit"),
                            url: "Profit",
                            requiredPermissionName: PermissionNames.Pages_Profit
                        )).AddItem(
                        new MenuItemDefinition(
                            PageNames.InventoryInfo,
                            L("InventoryInfo"),
                            url: "InventoryInfo",
                            requiredPermissionName: PermissionNames.Pages_InventoryInfo
                        )).AddItem(
                        new MenuItemDefinition(
                            PageNames.InventoryCheck,
                            L("InventoryCheck"),
                            url: "InventoryCheck",
                            requiredPermissionName: PermissionNames.Pages_InventoryCheck
                        )).AddItem(
                        new MenuItemDefinition(
                            PageNames.InventoryTransfer,
                            L("InventoryTransfer"),
                            url: "InventoryTransfer",
                            requiredPermissionName: PermissionNames.Pages_InventoryTransfer
                        )).AddItem(
                        new MenuItemDefinition(
                            PageNames.ProfitLossReport,
                            L("ProfitLossReport"),
                            url: "ProfitLossReport",
                            requiredPermissionName: PermissionNames.Pages_ProfitLossReport
                        ))
                ))
                .AddItem( // Menu items below is just for demonstration!
                    new MenuItemDefinition(
                        "Report",
                        L("Report"),
                        icon: "poll"
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.ProcurementStatisticsReport,
                            L("ProcurementStatisticsReport"),
                            url: "ProcurementStatisticsReport",
                            requiredPermissionName: PermissionNames.Pages_ProcurementStatisticsReport
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.ProcurementAnalysisReport,
                            L("ProcurementAnalysisReport"),
                            url: "ProcurementAnalysisReport",
                            requiredPermissionName: PermissionNames.Pages_ProcurementAnalysisReport
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.ProcurementDetailReport,
                            L("ProcurementDetailReport"),
                            url: "ProcurementDetailReport",
                            requiredPermissionName: PermissionNames.Pages_ProcurementDetailReport
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.SalesStatisticsReport,
                            L("SalesStatisticsReport"),
                            url: "SalesStatisticsReport",
                            requiredPermissionName: PermissionNames.Pages_SalesStatisticsReport
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.SalesAnalysisReport,
                            L("SalesAnalysisReport"),
                            url: "SalesAnalysisReport",
                            requiredPermissionName: PermissionNames.Pages_SalesAnalysisReport
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.SalesDetailReport,
                            L("SalesDetailReport"),
                            url: "SalesDetailReport",
                            requiredPermissionName: PermissionNames.Pages_SalesDetailReport
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.GrossStatisticsReport,
                            L("GrossStatisticsReport"),
                            url: "GrossStatisticsReport",
                            requiredPermissionName: PermissionNames.Pages_GrossStatisticsReport
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.GrossAnalysisReport,
                            L("GrossAnalysisReport"),
                            url: "GrossAnalysisReport",
                            requiredPermissionName: PermissionNames.Pages_GrossAnalysisReport
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.GrossDetailReport,
                            L("GrossDetailReport"),
                            url: "GrossDetailReport",
                            requiredPermissionName: PermissionNames.Pages_GrossDetailReport
                        )
                    )
                )
                .AddItem( // Menu items below is just for demonstration!
                    new MenuItemDefinition(
                        "Setting",
                        L("Setting"),
                        icon: "settings"
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.Tenants,
                            L("Tenants"),
                            url: "Tenants",
                            requiredPermissionName: PermissionNames.Pages_Tenants
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.Users,
                            L("Users"),
                            url: "Users",
                            requiredPermissionName: PermissionNames.Pages_Users
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.Roles,
                            L("Roles"),
                            url: "Roles",
                            requiredPermissionName: PermissionNames.Pages_Roles
                        )
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("About"),
                        url: "About",
                        icon: "info",
                        requiresAuthentication: true
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, InvoicingConsts.LocalizationSourceName);
        }
    }
}

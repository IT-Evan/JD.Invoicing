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
                            url: "Goods"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.Customer,
                            L("Customer"),
                            url: "Customer"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.Warehouse,
                            L("Warehouse"),
                            url: "Warehouse"
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
                            PageNames.PurchaseOrder,
                            L("PurchaseOrder"),
                            url: "PurchaseOrder"
                        )).AddItem(
                        new MenuItemDefinition(
                            PageNames.PurchaseWarehousing,
                            L("PurchaseWarehousing"),
                            url: "PurchaseWarehousing"
                        )).AddItem(
                        new MenuItemDefinition(
                            PageNames.PurchaseReturn,
                            L("PurchaseReturn"),
                            url: "PurchaseReturn"
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
                                url: "SalesOrder"
                            )).AddItem(
                            new MenuItemDefinition(
                                PageNames.SalesReturn,
                                L("SalesReturn"),
                                url: "SalesReturn"
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
                            url: "Loss"
                        )).AddItem(
                        new MenuItemDefinition(
                            PageNames.Profit,
                            L("Profit"),
                            url: "Profit"
                        )).AddItem(
                        new MenuItemDefinition(
                            PageNames.InventoryInfo,
                            L("InventoryInfo"),
                            url: "InventoryInfo"
                        )).AddItem(
                        new MenuItemDefinition(
                            PageNames.InventoryCheck,
                            L("InventoryCheck"),
                            url: "InventoryCheck"
                        )).AddItem(
                        new MenuItemDefinition(
                            PageNames.InventoryTransfer,
                            L("InventoryTransfer"),
                            url: "InventoryTransfer"
                        )).AddItem(
                        new MenuItemDefinition(
                            PageNames.ProfitLossReport,
                            L("ProfitLossReport"),
                            url: "ProfitLossReport"
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
                            url: "ProcurementStatisticsReport"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.ProcurementAnalysisReport,
                            L("ProcurementAnalysisReport"),
                            url: "ProcurementAnalysisReport"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.ProcurementDetailReport,
                            L("ProcurementDetailReport"),
                            url: "ProcurementDetailReport"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.SalesStatisticsReport,
                            L("SalesStatisticsReport"),
                            url: "SalesStatisticsReport"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.SalesAnalysisReport,
                            L("SalesAnalysisReport"),
                            url: "SalesAnalysisReport"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.SalesDetailReport,
                            L("SalesDetailReport"),
                            url: "SalesDetailReport"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.GrossStatisticsReport,
                            L("GrossStatisticsReport"),
                            url: "GrossStatisticsReport"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.GrossAnalysisReport,
                            L("GrossAnalysisReport"),
                            url: "GrossAnalysisReport"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.GrossDetailReport,
                            L("GrossDetailReport"),
                            url: "GrossDetailReport"
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
                            //icon: "business",
                            requiredPermissionName: PermissionNames.Pages_Tenants
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.Users,
                            L("Users"),
                            url: "Users",
                            //icon: "people",
                            requiredPermissionName: PermissionNames.Pages_Users
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.Roles,
                            L("Roles"),
                            url: "Roles",
                            //icon: "local_offer",
                            requiredPermissionName: PermissionNames.Pages_Roles
                        )
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("About"),
                        url: "About",
                        icon: "info"
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, InvoicingConsts.LocalizationSourceName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpressWalkthrough.Common.DataModel;
using DevExpressWalkthrough.Common.ViewModel;
using DevExpressWalkthrough.NorthwindEntitiesDataModel;
using DevExpressWalkthrough;

namespace DevExpressWalkthrough.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the NorthwindEntities data model.
    /// </summary>
    public partial class NorthwindEntitiesViewModel : DocumentsViewModel<NorthwindEntitiesModuleDescription, INorthwindEntitiesUnitOfWork> {

        const string TablesGroup = "Tables";

        const string ViewsGroup = "Views";

        /// <summary>
        /// Creates a new instance of NorthwindEntitiesViewModel as a POCO view model.
        /// </summary>
        public static NorthwindEntitiesViewModel Create() {
            return ViewModelSource.Create(() => new NorthwindEntitiesViewModel());
        }

        /// <summary>
        /// Initializes a new instance of the NorthwindEntitiesViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the NorthwindEntitiesViewModel type without the POCO proxy factory.
        /// </summary>
        protected NorthwindEntitiesViewModel()
            : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override NorthwindEntitiesModuleDescription[] CreateModules() {
            return new NorthwindEntitiesModuleDescription[] {
                new NorthwindEntitiesModuleDescription("Categories", "CategoryCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Categories)),
                new NorthwindEntitiesModuleDescription("Customer Demographics", "CustomerDemographicCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.CustomerDemographics)),
                new NorthwindEntitiesModuleDescription("Customers", "CustomerCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Customers)),
                new NorthwindEntitiesModuleDescription("Employees", "EmployeeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Employees)),
                new NorthwindEntitiesModuleDescription("Order Details", "Order_DetailCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Order_Details)),
                new NorthwindEntitiesModuleDescription("Orders", "OrderCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Orders)),
                new NorthwindEntitiesModuleDescription("Products", "ProductCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Products)),
                new NorthwindEntitiesModuleDescription("Regions", "RegionCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Regions)),
                new NorthwindEntitiesModuleDescription("Shippers", "ShipperCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Shippers)),
                new NorthwindEntitiesModuleDescription("Suppliers", "SupplierCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Suppliers)),
                new NorthwindEntitiesModuleDescription("Territories", "TerritoryCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Territories)),
                new NorthwindEntitiesModuleDescription("Alphabetical list of products", "Alphabetical_list_of_productCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription("Category Sales for 1997", "Category_Sales_for_1997CollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription("Current Product Lists", "Current_Product_ListCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription("Customer and Suppliers by Cities", "Customer_and_Suppliers_by_CityCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription("Invoices", "InvoiceCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription("Order Details Extendeds", "Order_Details_ExtendedCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription("Order Subtotals", "Order_SubtotalCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription("Orders Qries", "Orders_QryCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription("Product Sales for 1997", "Product_Sales_for_1997CollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription("Products Above Average Prices", "Products_Above_Average_PriceCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription("Products by Categories", "Products_by_CategoryCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription("Sales by Categories", "Sales_by_CategoryCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription("Sales Totals by Amounts", "Sales_Totals_by_AmountCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription("Summary of Sales by Quarters", "Summary_of_Sales_by_QuarterCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription("Summary of Sales by Years", "Summary_of_Sales_by_YearCollectionView", ViewsGroup),
            };
        }



    }

    public partial class NorthwindEntitiesModuleDescription : ModuleDescription<NorthwindEntitiesModuleDescription> {
        public NorthwindEntitiesModuleDescription(string title, string documentType, string group, Func<NorthwindEntitiesModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}
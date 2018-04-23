using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using Scaffolding.DatabaseFirst.Localization;
using Scaffolding.DatabaseFirst.NorthwindEntitiesDataModel;

namespace Scaffolding.DatabaseFirst.ViewModels {
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

        static NorthwindEntitiesViewModel() {
            MetadataLocator.Default = MetadataLocator.Create().AddMetadata<NorthwindEntitiesMetadataProvider>();
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
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.CategoryPlural, "CategoryCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Categories)),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.CustomerDemographicPlural, "CustomerDemographicCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.CustomerDemographics)),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.CustomerPlural, "CustomerCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Customers)),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.EmployeePlural, "EmployeeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Employees)),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Order_DetailPlural, "Order_DetailCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Order_Details)),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.OrderPlural, "OrderCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Orders)),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.ProductPlural, "ProductCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Products)),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.RegionPlural, "RegionCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Regions)),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.ShipperPlural, "ShipperCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Shippers)),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.SupplierPlural, "SupplierCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Suppliers)),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.TerritoryPlural, "TerritoryCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Territories)),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Alphabetical_list_of_productPlural, "Alphabetical_list_of_productCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Category_Sales_for_1997Plural, "Category_Sales_for_1997CollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Current_Product_ListPlural, "Current_Product_ListCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Customer_and_Suppliers_by_CityPlural, "Customer_and_Suppliers_by_CityCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.InvoicePlural, "InvoiceCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Order_Details_ExtendedPlural, "Order_Details_ExtendedCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Order_SubtotalPlural, "Order_SubtotalCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Orders_QryPlural, "Orders_QryCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Product_Sales_for_1997Plural, "Product_Sales_for_1997CollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Products_Above_Average_PricePlural, "Products_Above_Average_PriceCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Products_by_CategoryPlural, "Products_by_CategoryCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Sales_by_CategoryPlural, "Sales_by_CategoryCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Sales_Totals_by_AmountPlural, "Sales_Totals_by_AmountCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Summary_of_Sales_by_QuarterPlural, "Summary_of_Sales_by_QuarterCollectionView", ViewsGroup),
                new NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Summary_of_Sales_by_YearPlural, "Summary_of_Sales_by_YearCollectionView", ViewsGroup),
            };
        }
    }

    public partial class NorthwindEntitiesModuleDescription : ModuleDescription<NorthwindEntitiesModuleDescription> {
        public NorthwindEntitiesModuleDescription(string title, string documentType, string group, Func<NorthwindEntitiesModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}
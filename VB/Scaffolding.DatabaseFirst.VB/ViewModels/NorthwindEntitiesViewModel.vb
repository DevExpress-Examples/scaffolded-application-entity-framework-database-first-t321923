Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.ComponentModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.ViewModel
Imports Scaffolding.DatabaseFirst.VB.Localization
Imports Scaffolding.DatabaseFirst.VB.NorthwindEntitiesDataModel
Namespace Global.Scaffolding.DatabaseFirst.VB.ViewModels
    ''' <summary>
    ''' Represents the root POCO view model for the NorthwindEntities data model.
    ''' </summary>
    Public Partial Class NorthwindEntitiesViewModel
        Inherits DocumentsViewModel(Of NorthwindEntitiesModuleDescription, INorthwindEntitiesUnitOfWork)
        Private Const _TablesGroup As String = "Tables"
        Private Const _ViewsGroup As String = "Views"
        ''' <summary>
        ''' Creates a new instance of NorthwindEntitiesViewModel as a POCO view model.
        ''' </summary>
        Public Shared Function Create() As NorthwindEntitiesViewModel
            Return ViewModelSource.Create(Function() New NorthwindEntitiesViewModel())
        End Function
        Shared Sub New()
            MetadataLocator.[Default] = MetadataLocator.Create().AddMetadata(Of NorthwindEntitiesMetadataProvider)()
        End Sub
        ''' <summary>
        ''' Initializes a new instance of the NorthwindEntitiesViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the NorthwindEntitiesViewModel type without the POCO proxy factory.
        ''' </summary>
        Protected Sub New()
            MyBase.New(UnitOfWorkSource.GetUnitOfWorkFactory())
        End Sub
        Protected Overrides Function CreateModules() As NorthwindEntitiesModuleDescription()
            Return New NorthwindEntitiesModuleDescription() {New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.CategoryPlural, "CategoryCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.Categories)), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.CustomerDemographicPlural, "CustomerDemographicCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.CustomerDemographics)), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.CustomerPlural, "CustomerCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.Customers)), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.EmployeePlural, "EmployeeCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.Employees)), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Order_DetailPlural, "Order_DetailCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.Order_Details)), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.OrderPlural, "OrderCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.Orders)), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.ProductPlural, "ProductCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.Products)), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.RegionPlural, "RegionCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.Regions)), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.ShipperPlural, "ShipperCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.Shippers)), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.SupplierPlural, "SupplierCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.Suppliers)), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.TerritoryPlural, "TerritoryCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.Territories)), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Alphabetical_list_of_productPlural, "Alphabetical_list_of_productCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Category_Sales_for_1997Plural, "Category_Sales_for_1997CollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Current_Product_ListPlural, "Current_Product_ListCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Customer_and_Suppliers_by_CityPlural, "Customer_and_Suppliers_by_CityCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.InvoicePlural, "InvoiceCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Order_Details_ExtendedPlural, "Order_Details_ExtendedCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Order_SubtotalPlural, "Order_SubtotalCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Orders_QryPlural, "Orders_QryCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Product_Sales_for_1997Plural, "Product_Sales_for_1997CollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Products_Above_Average_PricePlural, "Products_Above_Average_PriceCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Products_by_CategoryPlural, "Products_by_CategoryCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Sales_by_CategoryPlural, "Sales_by_CategoryCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Sales_Totals_by_AmountPlural, "Sales_Totals_by_AmountCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Summary_of_Sales_by_QuarterPlural, "Summary_of_Sales_by_QuarterCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription(NorthwindEntitiesResources.Summary_of_Sales_by_YearPlural, "Summary_of_Sales_by_YearCollectionView", _ViewsGroup)}
        End Function
    End Class
    Public Partial Class NorthwindEntitiesModuleDescription
        Inherits ModuleDescription(Of NorthwindEntitiesModuleDescription)
        Public Sub New(ByVal title As String, ByVal documentType As String, ByVal group As String, Optional ByVal peekCollectionViewModelFactory As Func(Of NorthwindEntitiesModuleDescription, Object) = Nothing)
            MyBase.New(title, documentType, group, peekCollectionViewModelFactory)
        End Sub
    End Class
End Namespace

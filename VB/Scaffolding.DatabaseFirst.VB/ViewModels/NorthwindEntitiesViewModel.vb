Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.ComponentModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.ViewModel
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
        ''' <summary>
        ''' Initializes a new instance of the NorthwindEntitiesViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the NorthwindEntitiesViewModel type without the POCO proxy factory.
        ''' </summary>
        Protected Sub New()
            MyBase.New(UnitOfWorkSource.GetUnitOfWorkFactory())
        End Sub
        Protected Overrides Function CreateModules() As NorthwindEntitiesModuleDescription()
            Return New NorthwindEntitiesModuleDescription() {New NorthwindEntitiesModuleDescription("Categories", "CategoryCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.Categories)), New NorthwindEntitiesModuleDescription("Customer Demographics", "CustomerDemographicCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.CustomerDemographics)), New NorthwindEntitiesModuleDescription("Customers", "CustomerCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.Customers)), New NorthwindEntitiesModuleDescription("Employees", "EmployeeCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.Employees)), New NorthwindEntitiesModuleDescription("Order Details", "Order_DetailCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.Order_Details)), New NorthwindEntitiesModuleDescription("Orders", "OrderCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.Orders)), New NorthwindEntitiesModuleDescription("Products", "ProductCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.Products)), New NorthwindEntitiesModuleDescription("Regions", "RegionCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.Regions)), New NorthwindEntitiesModuleDescription("Shippers", "ShipperCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.Shippers)), New NorthwindEntitiesModuleDescription("Suppliers", "SupplierCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.Suppliers)), New NorthwindEntitiesModuleDescription("Territories", "TerritoryCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.Territories)), New NorthwindEntitiesModuleDescription("Alphabetical list of products", "Alphabetical_list_of_productCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription("Category Sales for 1997", "Category_Sales_for_1997CollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription("Current Product Lists", "Current_Product_ListCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription("Customer and Suppliers by Cities", "Customer_and_Suppliers_by_CityCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription("Invoices", "InvoiceCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription("Order Details Extendeds", "Order_Details_ExtendedCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription("Order Subtotals", "Order_SubtotalCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription("Orders Qries", "Orders_QryCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription("Product Sales for 1997", "Product_Sales_for_1997CollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription("Products Above Average Prices", "Products_Above_Average_PriceCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription("Products by Categories", "Products_by_CategoryCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription("Sales by Categories", "Sales_by_CategoryCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription("Sales Totals by Amounts", "Sales_Totals_by_AmountCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription("Summary of Sales by Quarters", "Summary_of_Sales_by_QuarterCollectionView", _ViewsGroup), New NorthwindEntitiesModuleDescription("Summary of Sales by Years", "Summary_of_Sales_by_YearCollectionView", _ViewsGroup)}
        End Function
    End Class
    Public Partial Class NorthwindEntitiesModuleDescription
        Inherits ModuleDescription(Of NorthwindEntitiesModuleDescription)
        Public Sub New(ByVal title As String, ByVal documentType As String, ByVal group As String, Optional ByVal peekCollectionViewModelFactory As Func(Of NorthwindEntitiesModuleDescription, Object) = Nothing)
            MyBase.New(title, documentType, group, peekCollectionViewModelFactory)
        End Sub
    End Class
End Namespace

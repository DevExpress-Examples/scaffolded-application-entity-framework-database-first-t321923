Imports System
Imports System.Linq
Imports System.Data
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports DevExpressWalkthrough.VB.Common.Utils
Imports DevExpressWalkthrough.VB.Common.DataModel
Imports DevExpressWalkthrough.VB.Common.DataModel.DesignTime
Imports DevExpressWalkthrough.VB.Common.DataModel.EntityFramework
Imports DevExpressWalkthrough.VB
Namespace Global.DevExpressWalkthrough.VB.NorthwindEntitiesDataModel
    ''' <summary>
    ''' A NorthwindEntitiesDesignTimeUnitOfWork instance that represents the design-time implementation of the INorthwindEntitiesUnitOfWork interface.
    ''' </summary>
    Public Class NorthwindEntitiesDesignTimeUnitOfWork
        Inherits DesignTimeUnitOfWork
        Implements INorthwindEntitiesUnitOfWork
        ''' <summary>
        ''' Initializes a new instance of the NorthwindEntitiesDesignTimeUnitOfWork class.
        ''' </summary>
        Public Sub New()
        End Sub
        Private ReadOnly Property Alphabetical_list_of_products As IReadOnlyRepository(Of Alphabetical_list_of_product) Implements INorthwindEntitiesUnitOfWork.Alphabetical_list_of_products
            Get
                Return GetReadOnlyRepository(Of Alphabetical_list_of_product)()
            End Get
        End Property
        Private ReadOnly Property Categories As IRepository(Of Category, Integer) Implements INorthwindEntitiesUnitOfWork.Categories
            Get
                Return GetRepository(Function(ByVal x As Category) x.CategoryID)
            End Get
        End Property
        Private ReadOnly Property Category_Sales_for_1997 As IReadOnlyRepository(Of Category_Sales_for_1997) Implements INorthwindEntitiesUnitOfWork.Category_Sales_for_1997
            Get
                Return GetReadOnlyRepository(Of Category_Sales_for_1997)()
            End Get
        End Property
        Private ReadOnly Property Current_Product_Lists As IReadOnlyRepository(Of Current_Product_List) Implements INorthwindEntitiesUnitOfWork.Current_Product_Lists
            Get
                Return GetReadOnlyRepository(Of Current_Product_List)()
            End Get
        End Property
        Private ReadOnly Property Customer_and_Suppliers_by_Cities As IReadOnlyRepository(Of Customer_and_Suppliers_by_City) Implements INorthwindEntitiesUnitOfWork.Customer_and_Suppliers_by_Cities
            Get
                Return GetReadOnlyRepository(Of Customer_and_Suppliers_by_City)()
            End Get
        End Property
        Private ReadOnly Property CustomerDemographics As IRepository(Of CustomerDemographic, String) Implements INorthwindEntitiesUnitOfWork.CustomerDemographics
            Get
                Return GetRepository(Function(ByVal x As CustomerDemographic) x.CustomerTypeID)
            End Get
        End Property
        Private ReadOnly Property Customers As IRepository(Of Customer, String) Implements INorthwindEntitiesUnitOfWork.Customers
            Get
                Return GetRepository(Function(ByVal x As Customer) x.CustomerID)
            End Get
        End Property
        Private ReadOnly Property Employees As IRepository(Of Employee, Integer) Implements INorthwindEntitiesUnitOfWork.Employees
            Get
                Return GetRepository(Function(ByVal x As Employee) x.EmployeeID)
            End Get
        End Property
        Private ReadOnly Property Invoices As IReadOnlyRepository(Of Invoice) Implements INorthwindEntitiesUnitOfWork.Invoices
            Get
                Return GetReadOnlyRepository(Of Invoice)()
            End Get
        End Property
        Private ReadOnly Property Order_Details As IRepository(Of Order_Detail, Tuple(Of Integer, Integer)) Implements INorthwindEntitiesUnitOfWork.Order_Details
            Get
                Return GetRepository(Function(ByVal x As Order_Detail) Tuple.Create(x.OrderID, x.ProductID))
            End Get
        End Property
        Private ReadOnly Property Order_Details_Extendeds As IReadOnlyRepository(Of Order_Details_Extended) Implements INorthwindEntitiesUnitOfWork.Order_Details_Extendeds
            Get
                Return GetReadOnlyRepository(Of Order_Details_Extended)()
            End Get
        End Property
        Private ReadOnly Property Order_Subtotals As IReadOnlyRepository(Of Order_Subtotal) Implements INorthwindEntitiesUnitOfWork.Order_Subtotals
            Get
                Return GetReadOnlyRepository(Of Order_Subtotal)()
            End Get
        End Property
        Private ReadOnly Property Orders As IRepository(Of Order, Integer) Implements INorthwindEntitiesUnitOfWork.Orders
            Get
                Return GetRepository(Function(ByVal x As Order) x.OrderID)
            End Get
        End Property
        Private ReadOnly Property Orders_Qries As IReadOnlyRepository(Of Orders_Qry) Implements INorthwindEntitiesUnitOfWork.Orders_Qries
            Get
                Return GetReadOnlyRepository(Of Orders_Qry)()
            End Get
        End Property
        Private ReadOnly Property Product_Sales_for_1997 As IReadOnlyRepository(Of Product_Sales_for_1997) Implements INorthwindEntitiesUnitOfWork.Product_Sales_for_1997
            Get
                Return GetReadOnlyRepository(Of Product_Sales_for_1997)()
            End Get
        End Property
        Private ReadOnly Property Products As IRepository(Of Product, Integer) Implements INorthwindEntitiesUnitOfWork.Products
            Get
                Return GetRepository(Function(ByVal x As Product) x.ProductID)
            End Get
        End Property
        Private ReadOnly Property Products_Above_Average_Prices As IReadOnlyRepository(Of Products_Above_Average_Price) Implements INorthwindEntitiesUnitOfWork.Products_Above_Average_Prices
            Get
                Return GetReadOnlyRepository(Of Products_Above_Average_Price)()
            End Get
        End Property
        Private ReadOnly Property Products_by_Categories As IReadOnlyRepository(Of Products_by_Category) Implements INorthwindEntitiesUnitOfWork.Products_by_Categories
            Get
                Return GetReadOnlyRepository(Of Products_by_Category)()
            End Get
        End Property
        Private ReadOnly Property Regions As IRepository(Of Region, Integer) Implements INorthwindEntitiesUnitOfWork.Regions
            Get
                Return GetRepository(Function(ByVal x As Region) x.RegionID)
            End Get
        End Property
        Private ReadOnly Property Sales_by_Categories As IReadOnlyRepository(Of Sales_by_Category) Implements INorthwindEntitiesUnitOfWork.Sales_by_Categories
            Get
                Return GetReadOnlyRepository(Of Sales_by_Category)()
            End Get
        End Property
        Private ReadOnly Property Sales_Totals_by_Amounts As IReadOnlyRepository(Of Sales_Totals_by_Amount) Implements INorthwindEntitiesUnitOfWork.Sales_Totals_by_Amounts
            Get
                Return GetReadOnlyRepository(Of Sales_Totals_by_Amount)()
            End Get
        End Property
        Private ReadOnly Property Shippers As IRepository(Of Shipper, Integer) Implements INorthwindEntitiesUnitOfWork.Shippers
            Get
                Return GetRepository(Function(ByVal x As Shipper) x.ShipperID)
            End Get
        End Property
        Private ReadOnly Property Summary_of_Sales_by_Quarters As IReadOnlyRepository(Of Summary_of_Sales_by_Quarter) Implements INorthwindEntitiesUnitOfWork.Summary_of_Sales_by_Quarters
            Get
                Return GetReadOnlyRepository(Of Summary_of_Sales_by_Quarter)()
            End Get
        End Property
        Private ReadOnly Property Summary_of_Sales_by_Years As IReadOnlyRepository(Of Summary_of_Sales_by_Year) Implements INorthwindEntitiesUnitOfWork.Summary_of_Sales_by_Years
            Get
                Return GetReadOnlyRepository(Of Summary_of_Sales_by_Year)()
            End Get
        End Property
        Private ReadOnly Property Suppliers As IRepository(Of Supplier, Integer) Implements INorthwindEntitiesUnitOfWork.Suppliers
            Get
                Return GetRepository(Function(ByVal x As Supplier) x.SupplierID)
            End Get
        End Property
        Private ReadOnly Property Territories As IRepository(Of Territory, String) Implements INorthwindEntitiesUnitOfWork.Territories
            Get
                Return GetRepository(Function(ByVal x As Territory) x.TerritoryID)
            End Get
        End Property
    End Class
End Namespace

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
    ''' INorthwindEntitiesUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    ''' </summary>
    Public Interface INorthwindEntitiesUnitOfWork
        Inherits IUnitOfWork
        ''' <summary>
        ''' The Alphabetical_list_of_product entities repository.
        ''' </summary>
        ReadOnly Property Alphabetical_list_of_products As IReadOnlyRepository(Of Alphabetical_list_of_product)
        ''' <summary>
        ''' The Category entities repository.
        ''' </summary>
        ReadOnly Property Categories As IRepository(Of Category, Integer)
        ''' <summary>
        ''' The Category_Sales_for_1997 entities repository.
        ''' </summary>
        ReadOnly Property Category_Sales_for_1997 As IReadOnlyRepository(Of Category_Sales_for_1997)
        ''' <summary>
        ''' The Current_Product_List entities repository.
        ''' </summary>
        ReadOnly Property Current_Product_Lists As IReadOnlyRepository(Of Current_Product_List)
        ''' <summary>
        ''' The Customer_and_Suppliers_by_City entities repository.
        ''' </summary>
        ReadOnly Property Customer_and_Suppliers_by_Cities As IReadOnlyRepository(Of Customer_and_Suppliers_by_City)
        ''' <summary>
        ''' The CustomerDemographic entities repository.
        ''' </summary>
        ReadOnly Property CustomerDemographics As IRepository(Of CustomerDemographic, String)
        ''' <summary>
        ''' The Customer entities repository.
        ''' </summary>
        ReadOnly Property Customers As IRepository(Of Customer, String)
        ''' <summary>
        ''' The Employee entities repository.
        ''' </summary>
        ReadOnly Property Employees As IRepository(Of Employee, Integer)
        ''' <summary>
        ''' The Invoice entities repository.
        ''' </summary>
        ReadOnly Property Invoices As IReadOnlyRepository(Of Invoice)
        ''' <summary>
        ''' The Order_Detail entities repository.
        ''' </summary>
        ReadOnly Property Order_Details As IRepository(Of Order_Detail, Tuple(Of Integer, Integer))
        ''' <summary>
        ''' The Order_Details_Extended entities repository.
        ''' </summary>
        ReadOnly Property Order_Details_Extendeds As IReadOnlyRepository(Of Order_Details_Extended)
        ''' <summary>
        ''' The Order_Subtotal entities repository.
        ''' </summary>
        ReadOnly Property Order_Subtotals As IReadOnlyRepository(Of Order_Subtotal)
        ''' <summary>
        ''' The Order entities repository.
        ''' </summary>
        ReadOnly Property Orders As IRepository(Of Order, Integer)
        ''' <summary>
        ''' The Orders_Qry entities repository.
        ''' </summary>
        ReadOnly Property Orders_Qries As IReadOnlyRepository(Of Orders_Qry)
        ''' <summary>
        ''' The Product_Sales_for_1997 entities repository.
        ''' </summary>
        ReadOnly Property Product_Sales_for_1997 As IReadOnlyRepository(Of Product_Sales_for_1997)
        ''' <summary>
        ''' The Product entities repository.
        ''' </summary>
        ReadOnly Property Products As IRepository(Of Product, Integer)
        ''' <summary>
        ''' The Products_Above_Average_Price entities repository.
        ''' </summary>
        ReadOnly Property Products_Above_Average_Prices As IReadOnlyRepository(Of Products_Above_Average_Price)
        ''' <summary>
        ''' The Products_by_Category entities repository.
        ''' </summary>
        ReadOnly Property Products_by_Categories As IReadOnlyRepository(Of Products_by_Category)
        ''' <summary>
        ''' The Region entities repository.
        ''' </summary>
        ReadOnly Property Regions As IRepository(Of Region, Integer)
        ''' <summary>
        ''' The Sales_by_Category entities repository.
        ''' </summary>
        ReadOnly Property Sales_by_Categories As IReadOnlyRepository(Of Sales_by_Category)
        ''' <summary>
        ''' The Sales_Totals_by_Amount entities repository.
        ''' </summary>
        ReadOnly Property Sales_Totals_by_Amounts As IReadOnlyRepository(Of Sales_Totals_by_Amount)
        ''' <summary>
        ''' The Shipper entities repository.
        ''' </summary>
        ReadOnly Property Shippers As IRepository(Of Shipper, Integer)
        ''' <summary>
        ''' The Summary_of_Sales_by_Quarter entities repository.
        ''' </summary>
        ReadOnly Property Summary_of_Sales_by_Quarters As IReadOnlyRepository(Of Summary_of_Sales_by_Quarter)
        ''' <summary>
        ''' The Summary_of_Sales_by_Year entities repository.
        ''' </summary>
        ReadOnly Property Summary_of_Sales_by_Years As IReadOnlyRepository(Of Summary_of_Sales_by_Year)
        ''' <summary>
        ''' The Supplier entities repository.
        ''' </summary>
        ReadOnly Property Suppliers As IRepository(Of Supplier, Integer)
        ''' <summary>
        ''' The Territory entities repository.
        ''' </summary>
        ReadOnly Property Territories As IRepository(Of Territory, String)
    End Interface
End Namespace

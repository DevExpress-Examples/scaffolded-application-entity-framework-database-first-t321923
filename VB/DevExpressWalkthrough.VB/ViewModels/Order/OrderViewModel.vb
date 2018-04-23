Imports System
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DevExpressWalkthrough.VB.Common.Utils
Imports DevExpressWalkthrough.VB.NorthwindEntitiesDataModel
Imports DevExpressWalkthrough.VB.Common.DataModel
Imports DevExpressWalkthrough.VB
Imports DevExpressWalkthrough.VB.Common.ViewModel
Namespace Global.DevExpressWalkthrough.VB.ViewModels
    ''' <summary>
    ''' Represents the single Order object view model.
    ''' </summary>
    Public Partial Class OrderViewModel
        Inherits SingleObjectViewModel(Of Order, Integer, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of OrderViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As OrderViewModel
            Return ViewModelSource.Create(Function() New OrderViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the OrderViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the OrderViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Orders, Function(ByVal x) x.ShipName)
        End Sub
        ''' <summary>
        ''' The view model that contains a look-up collection of Customers for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpCustomers As IEntitiesViewModel(Of Customer)
            Get
                Return GetLookUpEntitiesViewModel(Function(ByVal x As OrderViewModel) x.LookUpCustomers, Function(ByVal x) x.Customers)
            End Get
        End Property
        ''' <summary>
        ''' The view model that contains a look-up collection of Employees for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpEmployees As IEntitiesViewModel(Of Employee)
            Get
                Return GetLookUpEntitiesViewModel(Function(ByVal x As OrderViewModel) x.LookUpEmployees, Function(ByVal x) x.Employees)
            End Get
        End Property
        ''' <summary>
        ''' The view model that contains a look-up collection of Shippers for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpShippers As IEntitiesViewModel(Of Shipper)
            Get
                Return GetLookUpEntitiesViewModel(Function(ByVal x As OrderViewModel) x.LookUpShippers, Function(ByVal x) x.Shippers)
            End Get
        End Property
        ''' <summary>
        ''' The view model for the OrderOrder_Details detail collection.
        ''' </summary>
        Public ReadOnly Property OrderOrder_DetailsDetails As CollectionViewModel(Of Order_Detail, Tuple(Of Integer, Integer), INorthwindEntitiesUnitOfWork)
            Get
                Return GetDetailsCollectionViewModel(Function(ByVal x As OrderViewModel) x.OrderOrder_DetailsDetails, Function(ByVal x) x.Order_Details, Function(ByVal x) x.OrderID, Sub(ByVal x, ByVal key) x.OrderID = key)
            End Get
        End Property
    End Class
End Namespace

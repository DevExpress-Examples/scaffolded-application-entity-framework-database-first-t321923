Imports System
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.Mvvm.ViewModel
Imports Scaffolding.DatabaseFirst.VB.NorthwindEntitiesDataModel
Imports Scaffolding.DatabaseFirst.VB.Common
Imports Scaffolding.DatabaseFirst
Namespace Global.Scaffolding.DatabaseFirst.VB.ViewModels
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
        ''' The view model that contains a look-up collection of Order_Details for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpOrder_Details As IEntitiesViewModel(Of Order_Detail)
            Get
                Return GetLookUpEntitiesViewModel(propertyExpression:=Function(ByVal x As OrderViewModel) x.LookUpOrder_Details, getRepositoryFunc:=Function(ByVal x) x.Order_Details)
            End Get
        End Property
        ''' <summary>
        ''' The view model that contains a look-up collection of Customers for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpCustomers As IEntitiesViewModel(Of Customer)
            Get
                Return GetLookUpEntitiesViewModel(propertyExpression:=Function(ByVal x As OrderViewModel) x.LookUpCustomers, getRepositoryFunc:=Function(ByVal x) x.Customers)
            End Get
        End Property
        ''' <summary>
        ''' The view model that contains a look-up collection of Employees for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpEmployees As IEntitiesViewModel(Of Employee)
            Get
                Return GetLookUpEntitiesViewModel(propertyExpression:=Function(ByVal x As OrderViewModel) x.LookUpEmployees, getRepositoryFunc:=Function(ByVal x) x.Employees)
            End Get
        End Property
        ''' <summary>
        ''' The view model that contains a look-up collection of Shippers for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpShippers As IEntitiesViewModel(Of Shipper)
            Get
                Return GetLookUpEntitiesViewModel(propertyExpression:=Function(ByVal x As OrderViewModel) x.LookUpShippers, getRepositoryFunc:=Function(ByVal x) x.Shippers)
            End Get
        End Property
        ''' <summary>
        ''' The view model for the OrderOrder_Details detail collection.
        ''' </summary>
        Public ReadOnly Property OrderOrder_DetailsDetails As CollectionViewModelBase(Of Order_Detail, Order_Detail, Tuple(Of Integer, Integer), INorthwindEntitiesUnitOfWork)
            Get
                Return GetDetailsCollectionViewModel(propertyExpression:=Function(ByVal x As OrderViewModel) x.OrderOrder_DetailsDetails, getRepositoryFunc:=Function(ByVal x) x.Order_Details, foreignKeyExpression:=Function(ByVal x) x.OrderID, navigationExpression:=Function(ByVal x) x.Order)
            End Get
        End Property
    End Class
End Namespace

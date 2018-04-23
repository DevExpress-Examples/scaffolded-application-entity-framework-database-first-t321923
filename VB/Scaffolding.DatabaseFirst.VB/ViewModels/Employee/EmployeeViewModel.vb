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
    ''' Represents the single Employee object view model.
    ''' </summary>
    Public Partial Class EmployeeViewModel
        Inherits SingleObjectViewModel(Of Employee, Integer, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of EmployeeViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As EmployeeViewModel
            Return ViewModelSource.Create(Function() New EmployeeViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the EmployeeViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the EmployeeViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Employees, Function(ByVal x) x.LastName)
        End Sub
        Protected Overrides Sub RefreshLookUpCollections(ByVal raisePropertyChanged As Boolean)
            MyBase.RefreshLookUpCollections(raisePropertyChanged)
            TerritoriesDetailEntities = CreateAddRemoveDetailEntitiesViewModel(Function(ByVal x) x.Territories, Function(ByVal x) x.Territories)
        End Sub
        ''' <summary>
        ''' The view model that contains a look-up collection of Employees for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpEmployees As IEntitiesViewModel(Of Employee)
            Get
                Return GetLookUpEntitiesViewModel(propertyExpression:=Function(ByVal x As EmployeeViewModel) x.LookUpEmployees, getRepositoryFunc:=Function(ByVal x) x.Employees)
            End Get
        End Property
        ''' <summary>
        ''' The view model that contains a look-up collection of Orders for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpOrders As IEntitiesViewModel(Of Order)
            Get
                Return GetLookUpEntitiesViewModel(propertyExpression:=Function(ByVal x As EmployeeViewModel) x.LookUpOrders, getRepositoryFunc:=Function(ByVal x) x.Orders)
            End Get
        End Property
        Public Overridable Property TerritoriesDetailEntities As AddRemoveDetailEntitiesViewModel(Of Employee, Int32, Territory, String, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' The view model for the EmployeeEmployees1 detail collection.
        ''' </summary>
        Public ReadOnly Property EmployeeEmployees1Details As CollectionViewModelBase(Of Employee, Employee, Integer, INorthwindEntitiesUnitOfWork)
            Get
                Return GetDetailsCollectionViewModel(propertyExpression:=Function(ByVal x As EmployeeViewModel) x.EmployeeEmployees1Details, getRepositoryFunc:=Function(ByVal x) x.Employees, foreignKeyExpression:=Function(ByVal x) x.ReportsTo, navigationExpression:=Function(ByVal x) x.Employee1)
            End Get
        End Property
        ''' <summary>
        ''' The view model for the EmployeeOrders detail collection.
        ''' </summary>
        Public ReadOnly Property EmployeeOrdersDetails As CollectionViewModelBase(Of Order, Order, Integer, INorthwindEntitiesUnitOfWork)
            Get
                Return GetDetailsCollectionViewModel(propertyExpression:=Function(ByVal x As EmployeeViewModel) x.EmployeeOrdersDetails, getRepositoryFunc:=Function(ByVal x) x.Orders, foreignKeyExpression:=Function(ByVal x) x.EmployeeID, navigationExpression:=Function(ByVal x) x.Employee)
            End Get
        End Property
    End Class
End Namespace

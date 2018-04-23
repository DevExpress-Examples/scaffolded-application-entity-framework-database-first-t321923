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
        ''' <summary>
        ''' The view model that contains a look-up collection of Employees for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpEmployees As IEntitiesViewModel(Of Employee)
            Get
                Return GetLookUpEntitiesViewModel(Function(ByVal x As EmployeeViewModel) x.LookUpEmployees, Function(ByVal x) x.Employees)
            End Get
        End Property
        Protected Overrides Sub RefreshLookUpCollections(ByVal raisePropertyChanged As Boolean)
            MyBase.RefreshLookUpCollections(raisePropertyChanged)
            TerritoriesDetailEntities = CreateAddRemoveDetailEntitiesViewModel(Function(ByVal x) x.Territories, Function(ByVal x) x.Territories)
        End Sub
        Public Overridable Property TerritoriesDetailEntities As AddRemoveDetailEntitiesViewModel(Of Employee, Int32, Territory, String, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' The view model for the EmployeeEmployees1 detail collection.
        ''' </summary>
        Public ReadOnly Property EmployeeEmployees1Details As CollectionViewModel(Of Employee, Integer, INorthwindEntitiesUnitOfWork)
            Get
                Return GetDetailsCollectionViewModel(Function(ByVal x As EmployeeViewModel) x.EmployeeEmployees1Details, Function(ByVal x) x.Employees, Function(ByVal x) x.ReportsTo, Sub(ByVal x, ByVal key) x.ReportsTo = key)
            End Get
        End Property
        ''' <summary>
        ''' The view model for the EmployeeOrders detail collection.
        ''' </summary>
        Public ReadOnly Property EmployeeOrdersDetails As CollectionViewModel(Of Order, Integer, INorthwindEntitiesUnitOfWork)
            Get
                Return GetDetailsCollectionViewModel(Function(ByVal x As EmployeeViewModel) x.EmployeeOrdersDetails, Function(ByVal x) x.Orders, Function(ByVal x) x.EmployeeID, Sub(ByVal x, ByVal key) x.EmployeeID = key)
            End Get
        End Property
    End Class
End Namespace

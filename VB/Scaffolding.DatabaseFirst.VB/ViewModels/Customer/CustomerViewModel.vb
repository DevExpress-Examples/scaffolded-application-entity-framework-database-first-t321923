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
    ''' Represents the single Customer object view model.
    ''' </summary>
    Public Partial Class CustomerViewModel
        Inherits SingleObjectViewModel(Of Customer, String, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of CustomerViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As CustomerViewModel
            Return ViewModelSource.Create(Function() New CustomerViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the CustomerViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the CustomerViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Customers, Function(ByVal x) x.CompanyName)
        End Sub
        Protected Overrides Sub RefreshLookUpCollections(ByVal raisePropertyChanged As Boolean)
            MyBase.RefreshLookUpCollections(raisePropertyChanged)
            CustomerDemographicsDetailEntities = CreateAddRemoveDetailEntitiesViewModel(Function(ByVal x) x.CustomerDemographics, Function(ByVal x) x.CustomerDemographics)
        End Sub
        ''' <summary>
        ''' The view model that contains a look-up collection of Orders for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpOrders As IEntitiesViewModel(Of Order)
            Get
                Return GetLookUpEntitiesViewModel(propertyExpression:=Function(ByVal x As CustomerViewModel) x.LookUpOrders, getRepositoryFunc:=Function(ByVal x) x.Orders)
            End Get
        End Property
        Public Overridable Property CustomerDemographicsDetailEntities As AddRemoveDetailEntitiesViewModel(Of Customer, String, CustomerDemographic, String, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' The view model for the CustomerOrders detail collection.
        ''' </summary>
        Public ReadOnly Property CustomerOrdersDetails As CollectionViewModelBase(Of Order, Order, Integer, INorthwindEntitiesUnitOfWork)
            Get
                Return GetDetailsCollectionViewModel(propertyExpression:=Function(ByVal x As CustomerViewModel) x.CustomerOrdersDetails, getRepositoryFunc:=Function(ByVal x) x.Orders, foreignKeyExpression:=Function(ByVal x) x.CustomerID, navigationExpression:=Function(ByVal x) x.Customer)
            End Get
        End Property
    End Class
End Namespace

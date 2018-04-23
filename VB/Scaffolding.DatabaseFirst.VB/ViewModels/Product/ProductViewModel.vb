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
    ''' Represents the single Product object view model.
    ''' </summary>
    Public Partial Class ProductViewModel
        Inherits SingleObjectViewModel(Of Product, Integer, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of ProductViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As ProductViewModel
            Return ViewModelSource.Create(Function() New ProductViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the ProductViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the ProductViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Products, Function(ByVal x) x.ProductName)
        End Sub
        ''' <summary>
        ''' The view model that contains a look-up collection of Categories for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpCategories As IEntitiesViewModel(Of Category)
            Get
                Return GetLookUpEntitiesViewModel(Function(ByVal x As ProductViewModel) x.LookUpCategories, Function(ByVal x) x.Categories)
            End Get
        End Property
        ''' <summary>
        ''' The view model that contains a look-up collection of Order_Details for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpOrder_Details As IEntitiesViewModel(Of Order_Detail)
            Get
                Return GetLookUpEntitiesViewModel(Function(ByVal x As ProductViewModel) x.LookUpOrder_Details, Function(ByVal x) x.Order_Details)
            End Get
        End Property
        ''' <summary>
        ''' The view model that contains a look-up collection of Suppliers for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpSuppliers As IEntitiesViewModel(Of Supplier)
            Get
                Return GetLookUpEntitiesViewModel(Function(ByVal x As ProductViewModel) x.LookUpSuppliers, Function(ByVal x) x.Suppliers)
            End Get
        End Property
        ''' <summary>
        ''' The view model for the ProductOrder_Details detail collection.
        ''' </summary>
        Public ReadOnly Property ProductOrder_DetailsDetails As CollectionViewModelBase(Of Order_Detail, Order_Detail, Tuple(Of Integer, Integer), INorthwindEntitiesUnitOfWork)
            Get
                Return GetDetailsCollectionViewModel(Function(ByVal x As ProductViewModel) x.ProductOrder_DetailsDetails, Function(ByVal x) x.Order_Details, Function(ByVal x) x.ProductID, Sub(ByVal x, ByVal key) x.ProductID = key)
            End Get
        End Property
    End Class
End Namespace

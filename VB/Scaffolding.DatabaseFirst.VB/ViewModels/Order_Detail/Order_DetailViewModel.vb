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
    ''' Represents the single Order_Detail object view model.
    ''' </summary>
    Public Partial Class Order_DetailViewModel
        Inherits SingleObjectViewModel(Of Order_Detail, Tuple(Of Integer, Integer), INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of Order_DetailViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As Order_DetailViewModel
            Return ViewModelSource.Create(Function() New Order_DetailViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the Order_DetailViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the Order_DetailViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Order_Details, Function(ByVal x) x.OrderID)
        End Sub
        ''' <summary>
        ''' The view model that contains a look-up collection of Orders for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpOrders As IEntitiesViewModel(Of Order)
            Get
                Return GetLookUpEntitiesViewModel(propertyExpression:=Function(ByVal x As Order_DetailViewModel) x.LookUpOrders, getRepositoryFunc:=Function(ByVal x) x.Orders)
            End Get
        End Property
        ''' <summary>
        ''' The view model that contains a look-up collection of Products for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpProducts As IEntitiesViewModel(Of Product)
            Get
                Return GetLookUpEntitiesViewModel(propertyExpression:=Function(ByVal x As Order_DetailViewModel) x.LookUpProducts, getRepositoryFunc:=Function(ByVal x) x.Products)
            End Get
        End Property
    End Class
End Namespace

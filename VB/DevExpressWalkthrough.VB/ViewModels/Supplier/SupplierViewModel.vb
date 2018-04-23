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
    ''' Represents the single Supplier object view model.
    ''' </summary>
    Public Partial Class SupplierViewModel
        Inherits SingleObjectViewModel(Of Supplier, Integer, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of SupplierViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As SupplierViewModel
            Return ViewModelSource.Create(Function() New SupplierViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the SupplierViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the SupplierViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Suppliers, Function(ByVal x) x.CompanyName)
        End Sub
        ''' <summary>
        ''' The view model for the SupplierProducts detail collection.
        ''' </summary>
        Public ReadOnly Property SupplierProductsDetails As CollectionViewModel(Of Product, Integer, INorthwindEntitiesUnitOfWork)
            Get
                Return GetDetailsCollectionViewModel(Function(ByVal x As SupplierViewModel) x.SupplierProductsDetails, Function(ByVal x) x.Products, Function(ByVal x) x.SupplierID, Sub(ByVal x, ByVal key) x.SupplierID = key)
            End Get
        End Property
    End Class
End Namespace

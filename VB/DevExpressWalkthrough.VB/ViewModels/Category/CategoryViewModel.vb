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
    ''' Represents the single Category object view model.
    ''' </summary>
    Public Partial Class CategoryViewModel
        Inherits SingleObjectViewModel(Of Category, Integer, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of CategoryViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As CategoryViewModel
            Return ViewModelSource.Create(Function() New CategoryViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the CategoryViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the CategoryViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Categories, Function(ByVal x) x.CategoryName)
        End Sub
        ''' <summary>
        ''' The view model for the CategoryProducts detail collection.
        ''' </summary>
        Public ReadOnly Property CategoryProductsDetails As CollectionViewModel(Of Product, Integer, INorthwindEntitiesUnitOfWork)
            Get
                Return GetDetailsCollectionViewModel(Function(ByVal x As CategoryViewModel) x.CategoryProductsDetails, Function(ByVal x) x.Products, Function(ByVal x) x.CategoryID, Sub(ByVal x, ByVal key) x.CategoryID = key)
            End Get
        End Property
    End Class
End Namespace

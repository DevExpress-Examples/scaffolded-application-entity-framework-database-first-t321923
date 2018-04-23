Imports System
Imports System.Linq
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.Mvvm.ViewModel
Imports Scaffolding.DatabaseFirst.VB.NorthwindEntitiesDataModel
Imports Scaffolding.DatabaseFirst.VB.Common
Imports Scaffolding.DatabaseFirst
Namespace Global.Scaffolding.DatabaseFirst.VB.ViewModels
    ''' <summary>
    ''' Represents the Category_Sales_for_1997 collection view model.
    ''' </summary>
    Public Partial Class Category_Sales_for_1997CollectionViewModel
        Inherits ReadOnlyCollectionViewModel(Of Category_Sales_for_1997, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of Category_Sales_for_1997CollectionViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As Category_Sales_for_1997CollectionViewModel
            Return ViewModelSource.Create(Function() New Category_Sales_for_1997CollectionViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the Category_Sales_for_1997CollectionViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the Category_Sales_for_1997CollectionViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Category_Sales_for_1997)
        End Sub
    End Class
End Namespace

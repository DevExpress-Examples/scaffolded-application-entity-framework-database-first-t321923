Imports System
Imports System.Linq
Imports DevExpress.Mvvm.POCO
Imports DevExpressWalkthrough.VB.Common.Utils
Imports DevExpressWalkthrough.VB.NorthwindEntitiesDataModel
Imports DevExpressWalkthrough.VB.Common.DataModel
Imports DevExpressWalkthrough.VB
Imports DevExpressWalkthrough.VB.Common.ViewModel
Namespace Global.DevExpressWalkthrough.VB.ViewModels
    ''' <summary>
    ''' Represents the Product_Sales_for_1997 collection view model.
    ''' </summary>
    Public Partial Class Product_Sales_for_1997CollectionViewModel
        Inherits ReadOnlyCollectionViewModel(Of Product_Sales_for_1997, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of Product_Sales_for_1997CollectionViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As Product_Sales_for_1997CollectionViewModel
            Return ViewModelSource.Create(Function() New Product_Sales_for_1997CollectionViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the Product_Sales_for_1997CollectionViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the Product_Sales_for_1997CollectionViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Product_Sales_for_1997)
        End Sub
    End Class
End Namespace

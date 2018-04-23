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
    ''' Represents the Products_Above_Average_Prices collection view model.
    ''' </summary>
    Public Partial Class Products_Above_Average_PriceCollectionViewModel
        Inherits ReadOnlyCollectionViewModel(Of Products_Above_Average_Price, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of Products_Above_Average_PriceCollectionViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As Products_Above_Average_PriceCollectionViewModel
            Return ViewModelSource.Create(Function() New Products_Above_Average_PriceCollectionViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the Products_Above_Average_PriceCollectionViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the Products_Above_Average_PriceCollectionViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Products_Above_Average_Prices)
        End Sub
    End Class
End Namespace

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
    ''' Represents the Products_by_Categories collection view model.
    ''' </summary>
    Public Partial Class Products_by_CategoryCollectionViewModel
        Inherits ReadOnlyCollectionViewModel(Of Products_by_Category, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of Products_by_CategoryCollectionViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As Products_by_CategoryCollectionViewModel
            Return ViewModelSource.Create(Function() New Products_by_CategoryCollectionViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the Products_by_CategoryCollectionViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the Products_by_CategoryCollectionViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Products_by_Categories)
        End Sub
    End Class
End Namespace

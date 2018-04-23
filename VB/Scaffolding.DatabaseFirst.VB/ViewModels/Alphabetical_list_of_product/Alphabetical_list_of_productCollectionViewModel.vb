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
    ''' Represents the Alphabetical_list_of_products collection view model.
    ''' </summary>
    Public Partial Class Alphabetical_list_of_productCollectionViewModel
        Inherits ReadOnlyCollectionViewModel(Of Alphabetical_list_of_product, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of Alphabetical_list_of_productCollectionViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As Alphabetical_list_of_productCollectionViewModel
            Return ViewModelSource.Create(Function() New Alphabetical_list_of_productCollectionViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the Alphabetical_list_of_productCollectionViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the Alphabetical_list_of_productCollectionViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Alphabetical_list_of_products)
        End Sub
    End Class
End Namespace

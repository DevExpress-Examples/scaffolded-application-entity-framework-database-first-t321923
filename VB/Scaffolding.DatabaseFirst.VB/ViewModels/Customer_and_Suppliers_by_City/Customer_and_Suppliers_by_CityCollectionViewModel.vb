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
    ''' Represents the Customer_and_Suppliers_by_Cities collection view model.
    ''' </summary>
    Public Partial Class Customer_and_Suppliers_by_CityCollectionViewModel
        Inherits ReadOnlyCollectionViewModel(Of Customer_and_Suppliers_by_City, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of Customer_and_Suppliers_by_CityCollectionViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As Customer_and_Suppliers_by_CityCollectionViewModel
            Return ViewModelSource.Create(Function() New Customer_and_Suppliers_by_CityCollectionViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the Customer_and_Suppliers_by_CityCollectionViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the Customer_and_Suppliers_by_CityCollectionViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Customer_and_Suppliers_by_Cities)
        End Sub
    End Class
End Namespace

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
    ''' Represents the Summary_of_Sales_by_Quarters collection view model.
    ''' </summary>
    Public Partial Class Summary_of_Sales_by_QuarterCollectionViewModel
        Inherits ReadOnlyCollectionViewModel(Of Summary_of_Sales_by_Quarter, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of Summary_of_Sales_by_QuarterCollectionViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As Summary_of_Sales_by_QuarterCollectionViewModel
            Return ViewModelSource.Create(Function() New Summary_of_Sales_by_QuarterCollectionViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the Summary_of_Sales_by_QuarterCollectionViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the Summary_of_Sales_by_QuarterCollectionViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Summary_of_Sales_by_Quarters)
        End Sub
    End Class
End Namespace

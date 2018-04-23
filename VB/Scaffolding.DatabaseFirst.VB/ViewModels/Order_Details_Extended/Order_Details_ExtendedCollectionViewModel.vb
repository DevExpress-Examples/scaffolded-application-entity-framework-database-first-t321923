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
    ''' Represents the Order_Details_Extendeds collection view model.
    ''' </summary>
    Public Partial Class Order_Details_ExtendedCollectionViewModel
        Inherits ReadOnlyCollectionViewModel(Of Order_Details_Extended, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of Order_Details_ExtendedCollectionViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As Order_Details_ExtendedCollectionViewModel
            Return ViewModelSource.Create(Function() New Order_Details_ExtendedCollectionViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the Order_Details_ExtendedCollectionViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the Order_Details_ExtendedCollectionViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Order_Details_Extendeds)
        End Sub
    End Class
End Namespace

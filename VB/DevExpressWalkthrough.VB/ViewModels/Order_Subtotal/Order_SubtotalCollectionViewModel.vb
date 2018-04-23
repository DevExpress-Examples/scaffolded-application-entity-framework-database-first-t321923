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
    ''' Represents the Order_Subtotals collection view model.
    ''' </summary>
    Public Partial Class Order_SubtotalCollectionViewModel
        Inherits ReadOnlyCollectionViewModel(Of Order_Subtotal, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of Order_SubtotalCollectionViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As Order_SubtotalCollectionViewModel
            Return ViewModelSource.Create(Function() New Order_SubtotalCollectionViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the Order_SubtotalCollectionViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the Order_SubtotalCollectionViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Order_Subtotals)
        End Sub
    End Class
End Namespace

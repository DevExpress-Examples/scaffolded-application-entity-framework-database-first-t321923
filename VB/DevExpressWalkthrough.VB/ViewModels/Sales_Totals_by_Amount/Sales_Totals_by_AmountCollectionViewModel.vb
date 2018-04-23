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
    ''' Represents the Sales_Totals_by_Amounts collection view model.
    ''' </summary>
    Public Partial Class Sales_Totals_by_AmountCollectionViewModel
        Inherits ReadOnlyCollectionViewModel(Of Sales_Totals_by_Amount, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of Sales_Totals_by_AmountCollectionViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As Sales_Totals_by_AmountCollectionViewModel
            Return ViewModelSource.Create(Function() New Sales_Totals_by_AmountCollectionViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the Sales_Totals_by_AmountCollectionViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the Sales_Totals_by_AmountCollectionViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Sales_Totals_by_Amounts)
        End Sub
    End Class
End Namespace

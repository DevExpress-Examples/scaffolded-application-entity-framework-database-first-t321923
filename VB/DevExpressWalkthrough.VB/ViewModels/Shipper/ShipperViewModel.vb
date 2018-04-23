Imports System
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DevExpressWalkthrough.VB.Common.Utils
Imports DevExpressWalkthrough.VB.NorthwindEntitiesDataModel
Imports DevExpressWalkthrough.VB.Common.DataModel
Imports DevExpressWalkthrough.VB
Imports DevExpressWalkthrough.VB.Common.ViewModel
Namespace Global.DevExpressWalkthrough.VB.ViewModels
    ''' <summary>
    ''' Represents the single Shipper object view model.
    ''' </summary>
    Public Partial Class ShipperViewModel
        Inherits SingleObjectViewModel(Of Shipper, Integer, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of ShipperViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As ShipperViewModel
            Return ViewModelSource.Create(Function() New ShipperViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the ShipperViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the ShipperViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Shippers, Function(ByVal x) x.CompanyName)
        End Sub
        ''' <summary>
        ''' The view model for the ShipperOrders detail collection.
        ''' </summary>
        Public ReadOnly Property ShipperOrdersDetails As CollectionViewModel(Of Order, Integer, INorthwindEntitiesUnitOfWork)
            Get
                Return GetDetailsCollectionViewModel(Function(ByVal x As ShipperViewModel) x.ShipperOrdersDetails, Function(ByVal x) x.Orders, Function(ByVal x) x.ShipVia, Sub(ByVal x, ByVal key) x.ShipVia = key)
            End Get
        End Property
    End Class
End Namespace

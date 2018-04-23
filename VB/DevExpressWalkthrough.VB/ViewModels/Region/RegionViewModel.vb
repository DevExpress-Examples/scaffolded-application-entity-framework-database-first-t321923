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
    ''' Represents the single Region object view model.
    ''' </summary>
    Public Partial Class RegionViewModel
        Inherits SingleObjectViewModel(Of Region, Integer, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of RegionViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As RegionViewModel
            Return ViewModelSource.Create(Function() New RegionViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the RegionViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the RegionViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Regions, Function(ByVal x) x.RegionDescription)
        End Sub
        ''' <summary>
        ''' The view model for the RegionTerritories detail collection.
        ''' </summary>
        Public ReadOnly Property RegionTerritoriesDetails As CollectionViewModel(Of Territory, String, INorthwindEntitiesUnitOfWork)
            Get
                Return GetDetailsCollectionViewModel(Function(ByVal x As RegionViewModel) x.RegionTerritoriesDetails, Function(ByVal x) x.Territories, Function(ByVal x) x.RegionID, Sub(ByVal x, ByVal key) x.RegionID = key)
            End Get
        End Property
    End Class
End Namespace

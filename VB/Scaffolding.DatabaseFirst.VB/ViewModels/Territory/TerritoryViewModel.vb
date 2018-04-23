Imports System
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.Mvvm.ViewModel
Imports Scaffolding.DatabaseFirst.VB.NorthwindEntitiesDataModel
Imports Scaffolding.DatabaseFirst.VB.Common
Imports Scaffolding.DatabaseFirst
Namespace Global.Scaffolding.DatabaseFirst.VB.ViewModels
    ''' <summary>
    ''' Represents the single Territory object view model.
    ''' </summary>
    Public Partial Class TerritoryViewModel
        Inherits SingleObjectViewModel(Of Territory, String, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of TerritoryViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As TerritoryViewModel
            Return ViewModelSource.Create(Function() New TerritoryViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the TerritoryViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the TerritoryViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Territories, Function(ByVal x) x.TerritoryDescription)
        End Sub
        Protected Overrides Sub RefreshLookUpCollections(ByVal raisePropertyChanged As Boolean)
            MyBase.RefreshLookUpCollections(raisePropertyChanged)
            EmployeesDetailEntities = CreateAddRemoveDetailEntitiesViewModel(Function(ByVal x) x.Employees, Function(ByVal x) x.Employees)
        End Sub
        ''' <summary>
        ''' The view model that contains a look-up collection of Regions for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpRegions As IEntitiesViewModel(Of Region)
            Get
                Return GetLookUpEntitiesViewModel(propertyExpression:=Function(ByVal x As TerritoryViewModel) x.LookUpRegions, getRepositoryFunc:=Function(ByVal x) x.Regions)
            End Get
        End Property
        Public Overridable Property EmployeesDetailEntities As AddRemoveDetailEntitiesViewModel(Of Territory, String, Employee, Int32, INorthwindEntitiesUnitOfWork)
    End Class
End Namespace

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
    ''' Represents the single CustomerDemographic object view model.
    ''' </summary>
    Public Partial Class CustomerDemographicViewModel
        Inherits SingleObjectViewModel(Of CustomerDemographic, String, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of CustomerDemographicViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As CustomerDemographicViewModel
            Return ViewModelSource.Create(Function() New CustomerDemographicViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the CustomerDemographicViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the CustomerDemographicViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.CustomerDemographics, Function(ByVal x) x.CustomerDesc)
        End Sub
        Protected Overrides Sub RefreshLookUpCollections(ByVal raisePropertyChanged As Boolean)
            MyBase.RefreshLookUpCollections(raisePropertyChanged)
            CustomersDetailEntities = CreateAddRemoveDetailEntitiesViewModel(Function(ByVal x) x.Customers, Function(ByVal x) x.Customers)
        End Sub
        Public Overridable Property CustomersDetailEntities As AddRemoveDetailEntitiesViewModel(Of CustomerDemographic, String, Customer, String, INorthwindEntitiesUnitOfWork)
    End Class
End Namespace

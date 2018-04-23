﻿Imports System
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
    ''' Represents the single Customer object view model.
    ''' </summary>
    Public Partial Class CustomerViewModel
        Inherits SingleObjectViewModel(Of Customer, String, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of CustomerViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As CustomerViewModel
            Return ViewModelSource.Create(Function() New CustomerViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the CustomerViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the CustomerViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Customers, Function(ByVal x) x.CompanyName)
        End Sub
        Protected Overrides Sub RefreshLookUpCollections(ByVal raisePropertyChanged As Boolean)
            MyBase.RefreshLookUpCollections(raisePropertyChanged)
            CustomerDemographicsDetailEntities = CreateAddRemoveDetailEntitiesViewModel(Function(ByVal x) x.CustomerDemographics, Function(ByVal x) x.CustomerDemographics)
        End Sub
        Public Overridable Property CustomerDemographicsDetailEntities As AddRemoveDetailEntitiesViewModel(Of Customer, String, CustomerDemographic, String, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' The view model for the CustomerOrders detail collection.
        ''' </summary>
        Public ReadOnly Property CustomerOrdersDetails As CollectionViewModel(Of Order, Integer, INorthwindEntitiesUnitOfWork)
            Get
                Return GetDetailsCollectionViewModel(Function(ByVal x As CustomerViewModel) x.CustomerOrdersDetails, Function(ByVal x) x.Orders, Function(ByVal x) x.CustomerID, Sub(ByVal x, ByVal key) x.CustomerID = key)
            End Get
        End Property
    End Class
End Namespace

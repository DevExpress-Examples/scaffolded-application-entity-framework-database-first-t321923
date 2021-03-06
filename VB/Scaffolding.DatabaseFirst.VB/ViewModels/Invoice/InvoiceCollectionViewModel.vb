﻿Imports System
Imports System.Linq
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.Mvvm.ViewModel
Imports Scaffolding.DatabaseFirst.VB.NorthwindEntitiesDataModel
Imports Scaffolding.DatabaseFirst.VB.Common
Imports Scaffolding.DatabaseFirst
Namespace Global.Scaffolding.DatabaseFirst.VB.ViewModels
    ''' <summary>
    ''' Represents the Invoices collection view model.
    ''' </summary>
    Public Partial Class InvoiceCollectionViewModel
        Inherits ReadOnlyCollectionViewModel(Of Invoice, INorthwindEntitiesUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of InvoiceCollectionViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing) As InvoiceCollectionViewModel
            Return ViewModelSource.Create(Function() New InvoiceCollectionViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the InvoiceCollectionViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the InvoiceCollectionViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of INorthwindEntitiesUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Invoices)
        End Sub
    End Class
End Namespace

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Supplier
    Public Property SupplierID As Integer
    Public Property CompanyName As String
    Public Property ContactName As String
    Public Property ContactTitle As String
    Public Property Address As String
    Public Property City As String
    Public Property Region As String
    Public Property PostalCode As String
    Public Property Country As String
    Public Property Phone As String
    Public Property Fax As String
    Public Property HomePage As String

    Public Overridable Property Products As ICollection(Of Product) = New HashSet(Of Product)

End Class

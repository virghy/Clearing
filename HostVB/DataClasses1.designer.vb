﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión del motor en tiempo de ejecución:2.0.50727.1434
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<System.Data.Linq.Mapping.DatabaseAttribute(Name:="Franquicia")>  _
Partial Public Class DataClasses1DataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertCategoria(instance As Categoria)
    End Sub
  Partial Private Sub UpdateCategoria(instance As Categoria)
    End Sub
  Partial Private Sub DeleteCategoria(instance As Categoria)
    End Sub
  #End Region
	
	Public Sub New()
        MyBase.New(HostVB.My.MySettings.Default.FranquiciaConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Categoria() As System.Data.Linq.Table(Of Categoria)
		Get
			Return Me.GetTable(Of Categoria)
		End Get
	End Property
End Class

<Table(Name:="dbo.Categoria")>  _
Partial Public Class Categoria
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _IdCategoria As Integer
	
	Private _Categoria As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdCategoriaChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdCategoriaChanged()
    End Sub
    Partial Private Sub OnCategoriaChanging(value As String)
    End Sub
    Partial Private Sub OnCategoriaChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Column(Storage:="_IdCategoria", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property IdCategoria() As Integer
		Get
			Return Me._IdCategoria
		End Get
		Set
			If ((Me._IdCategoria = value)  _
						= false) Then
				Me.OnIdCategoriaChanging(value)
				Me.SendPropertyChanging
				Me._IdCategoria = value
				Me.SendPropertyChanged("IdCategoria")
				Me.OnIdCategoriaChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Categoria", DbType:="VarChar(50)")>  _
	Public Property Categoria() As String
		Get
			Return Me._Categoria
		End Get
		Set
			If (String.Equals(Me._Categoria, value) = false) Then
				Me.OnCategoriaChanging(value)
				Me.SendPropertyChanging
				Me._Categoria = value
				Me.SendPropertyChanged("Categoria")
				Me.OnCategoriaChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

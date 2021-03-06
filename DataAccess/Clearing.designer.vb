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


<System.Data.Linq.Mapping.DatabaseAttribute(Name:="Clearing")>  _
Partial Public Class ClearingDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertCiudad(instance As Ciudad)
    End Sub
  Partial Private Sub UpdateCiudad(instance As Ciudad)
    End Sub
  Partial Private Sub DeleteCiudad(instance As Ciudad)
    End Sub
  Partial Private Sub InsertRegion(instance As Region)
    End Sub
  Partial Private Sub UpdateRegion(instance As Region)
    End Sub
  Partial Private Sub DeleteRegion(instance As Region)
    End Sub
  Partial Private Sub InsertCategoria(instance As Categoria)
    End Sub
  Partial Private Sub UpdateCategoria(instance As Categoria)
    End Sub
  Partial Private Sub DeleteCategoria(instance As Categoria)
    End Sub
  Partial Private Sub InsertVisitas(instance As Visitas)
    End Sub
  Partial Private Sub UpdateVisitas(instance As Visitas)
    End Sub
  Partial Private Sub DeleteVisitas(instance As Visitas)
    End Sub
  Partial Private Sub InsertEstados(instance As Estados)
    End Sub
  Partial Private Sub UpdateEstados(instance As Estados)
    End Sub
  Partial Private Sub DeleteEstados(instance As Estados)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.DataAccess.My.MySettings.Default.FranquiciaConnectionString, mappingSource)
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
	
	Public ReadOnly Property Ciudad() As System.Data.Linq.Table(Of Ciudad)
		Get
			Return Me.GetTable(Of Ciudad)
		End Get
	End Property
	
	Public ReadOnly Property Region() As System.Data.Linq.Table(Of Region)
		Get
			Return Me.GetTable(Of Region)
		End Get
	End Property
	
	Public ReadOnly Property Categoria() As System.Data.Linq.Table(Of Categoria)
		Get
			Return Me.GetTable(Of Categoria)
		End Get
	End Property
	
	Public ReadOnly Property Visitas() As System.Data.Linq.Table(Of Visitas)
		Get
			Return Me.GetTable(Of Visitas)
		End Get
	End Property
	
	Public ReadOnly Property Estados() As System.Data.Linq.Table(Of Estados)
		Get
			Return Me.GetTable(Of Estados)
		End Get
	End Property
End Class

<Table(Name:="dbo.Ciudad")>  _
Partial Public Class Ciudad
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _idCiudad As Integer
	
	Private _Descripcion As String
	
	Private _idRegion As System.Nullable(Of Integer)
	
	Private _Region As EntityRef(Of Region)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnidCiudadChanging(value As Integer)
    End Sub
    Partial Private Sub OnidCiudadChanged()
    End Sub
    Partial Private Sub OnDescripcionChanging(value As String)
    End Sub
    Partial Private Sub OnDescripcionChanged()
    End Sub
    Partial Private Sub OnidRegionChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnidRegionChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Region = CType(Nothing, EntityRef(Of Region))
		OnCreated
	End Sub
	
	<Column(Storage:="_idCiudad", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property idCiudad() As Integer
		Get
			Return Me._idCiudad
		End Get
		Set
			If ((Me._idCiudad = value)  _
						= false) Then
				Me.OnidCiudadChanging(value)
				Me.SendPropertyChanging
				Me._idCiudad = value
				Me.SendPropertyChanged("idCiudad")
				Me.OnidCiudadChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Descripcion", DbType:="VarChar(50)")>  _
	Public Property Descripcion() As String
		Get
			Return Me._Descripcion
		End Get
		Set
			If (String.Equals(Me._Descripcion, value) = false) Then
				Me.OnDescripcionChanging(value)
				Me.SendPropertyChanging
				Me._Descripcion = value
				Me.SendPropertyChanged("Descripcion")
				Me.OnDescripcionChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_idRegion", DbType:="Int")>  _
	Public Property idRegion() As System.Nullable(Of Integer)
		Get
			Return Me._idRegion
		End Get
		Set
			If (Me._idRegion.Equals(value) = false) Then
				If Me._Region.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException
				End If
				Me.OnidRegionChanging(value)
				Me.SendPropertyChanging
				Me._idRegion = value
				Me.SendPropertyChanged("idRegion")
				Me.OnidRegionChanged
			End If
		End Set
	End Property
	
	<Association(Name:="Region_Ciudad", Storage:="_Region", ThisKey:="idRegion", IsForeignKey:=true)>  _
	Public Property Region() As Region
		Get
			Return Me._Region.Entity
		End Get
		Set
			Dim previousValue As Region = Me._Region.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Region.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Region.Entity = Nothing
					previousValue.Ciudad.Remove(Me)
				End If
				Me._Region.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Ciudad.Add(Me)
					Me._idRegion = value.idRegion
				Else
					Me._idRegion = CType(Nothing, Nullable(Of Integer))
				End If
				Me.SendPropertyChanged("Region")
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

<Table(Name:="dbo.Region")>  _
Partial Public Class Region
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _idRegion As Integer
	
	Private _Descripcion As String
	
	Private _Ciudad As EntitySet(Of Ciudad)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnidRegionChanging(value As Integer)
    End Sub
    Partial Private Sub OnidRegionChanged()
    End Sub
    Partial Private Sub OnDescripcionChanging(value As String)
    End Sub
    Partial Private Sub OnDescripcionChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Ciudad = New EntitySet(Of Ciudad)(AddressOf Me.attach_Ciudad, AddressOf Me.detach_Ciudad)
		OnCreated
	End Sub
	
	<Column(Storage:="_idRegion", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property idRegion() As Integer
		Get
			Return Me._idRegion
		End Get
		Set
			If ((Me._idRegion = value)  _
						= false) Then
				Me.OnidRegionChanging(value)
				Me.SendPropertyChanging
				Me._idRegion = value
				Me.SendPropertyChanged("idRegion")
				Me.OnidRegionChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Descripcion", DbType:="VarChar(20)")>  _
	Public Property Descripcion() As String
		Get
			Return Me._Descripcion
		End Get
		Set
			If (String.Equals(Me._Descripcion, value) = false) Then
				Me.OnDescripcionChanging(value)
				Me.SendPropertyChanging
				Me._Descripcion = value
				Me.SendPropertyChanged("Descripcion")
				Me.OnDescripcionChanged
			End If
		End Set
	End Property
	
	<Association(Name:="Region_Ciudad", Storage:="_Ciudad", OtherKey:="idRegion")>  _
	Public Property Ciudad() As EntitySet(Of Ciudad)
		Get
			Return Me._Ciudad
		End Get
		Set
			Me._Ciudad.Assign(value)
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
	
	Private Sub attach_Ciudad(ByVal entity As Ciudad)
		Me.SendPropertyChanging
		entity.Region = Me
	End Sub
	
	Private Sub detach_Ciudad(ByVal entity As Ciudad)
		Me.SendPropertyChanging
		entity.Region = Nothing
	End Sub
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

<Table(Name:="dbo.Visitas")>  _
Partial Public Class Visitas
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _idvisita As Integer
	
	Private _idreunion As System.Nullable(Of Integer)
	
	Private _idfranquiciado As System.Nullable(Of Integer)
	
	Private _Atendidopor As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnidvisitaChanging(value As Integer)
    End Sub
    Partial Private Sub OnidvisitaChanged()
    End Sub
    Partial Private Sub OnidreunionChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnidreunionChanged()
    End Sub
    Partial Private Sub OnidfranquiciadoChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnidfranquiciadoChanged()
    End Sub
    Partial Private Sub OnAtendidoporChanging(value As String)
    End Sub
    Partial Private Sub OnAtendidoporChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Column(Storage:="_idvisita", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property idvisita() As Integer
		Get
			Return Me._idvisita
		End Get
		Set
			If ((Me._idvisita = value)  _
						= false) Then
				Me.OnidvisitaChanging(value)
				Me.SendPropertyChanging
				Me._idvisita = value
				Me.SendPropertyChanged("idvisita")
				Me.OnidvisitaChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_idreunion", DbType:="Int")>  _
	Public Property idreunion() As System.Nullable(Of Integer)
		Get
			Return Me._idreunion
		End Get
		Set
			If (Me._idreunion.Equals(value) = false) Then
				Me.OnidreunionChanging(value)
				Me.SendPropertyChanging
				Me._idreunion = value
				Me.SendPropertyChanged("idreunion")
				Me.OnidreunionChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_idfranquiciado", DbType:="Int")>  _
	Public Property idfranquiciado() As System.Nullable(Of Integer)
		Get
			Return Me._idfranquiciado
		End Get
		Set
			If (Me._idfranquiciado.Equals(value) = false) Then
				Me.OnidfranquiciadoChanging(value)
				Me.SendPropertyChanging
				Me._idfranquiciado = value
				Me.SendPropertyChanged("idfranquiciado")
				Me.OnidfranquiciadoChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Atendidopor", DbType:="VarChar(100)")>  _
	Public Property Atendidopor() As String
		Get
			Return Me._Atendidopor
		End Get
		Set
			If (String.Equals(Me._Atendidopor, value) = false) Then
				Me.OnAtendidoporChanging(value)
				Me.SendPropertyChanging
				Me._Atendidopor = value
				Me.SendPropertyChanged("Atendidopor")
				Me.OnAtendidoporChanged
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

<Table(Name:="dbo.Estados")>  _
Partial Public Class Estados
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _cod_estado As Integer
	
	Private _nombre_estado As String
	
	Private _tabla As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub Oncod_estadoChanging(value As Integer)
    End Sub
    Partial Private Sub Oncod_estadoChanged()
    End Sub
    Partial Private Sub Onnombre_estadoChanging(value As String)
    End Sub
    Partial Private Sub Onnombre_estadoChanged()
    End Sub
    Partial Private Sub OntablaChanging(value As String)
    End Sub
    Partial Private Sub OntablaChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Column(Storage:="_cod_estado", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property cod_estado() As Integer
		Get
			Return Me._cod_estado
		End Get
		Set
			If ((Me._cod_estado = value)  _
						= false) Then
				Me.Oncod_estadoChanging(value)
				Me.SendPropertyChanging
				Me._cod_estado = value
				Me.SendPropertyChanged("cod_estado")
				Me.Oncod_estadoChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_nombre_estado", DbType:="VarChar(10) NOT NULL", CanBeNull:=false)>  _
	Public Property nombre_estado() As String
		Get
			Return Me._nombre_estado
		End Get
		Set
			If (String.Equals(Me._nombre_estado, value) = false) Then
				Me.Onnombre_estadoChanging(value)
				Me.SendPropertyChanging
				Me._nombre_estado = value
				Me.SendPropertyChanged("nombre_estado")
				Me.Onnombre_estadoChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_tabla", DbType:="VarChar(20) NOT NULL", CanBeNull:=false)>  _
	Public Property tabla() As String
		Get
			Return Me._tabla
		End Get
		Set
			If (String.Equals(Me._tabla, value) = false) Then
				Me.OntablaChanging(value)
				Me.SendPropertyChanging
				Me._tabla = value
				Me.SendPropertyChanged("tabla")
				Me.OntablaChanged
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

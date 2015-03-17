Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Validation
Imports Microsoft.Practices.EnterpriseLibrary.Validation.Validators
Imports System.ComponentModel


<HasSelfValidation()> _
Partial Public Class Lecturas
    Implements IEditableObject
    Implements System.ComponentModel.IDataErrorInfo
    Implements System.Xml.Serialization.IXmlSerializable


    '  Implements INotifyPropertyChanged

    Private mEditing As Boolean
    Private OldLectura As Lecturas
    Private _conError As Boolean = False
    Private _Errores As List(Of Errores)
    Private _NroError As Integer = 0
    Public ExisteCHITCI As Boolean
    Dim _EsCabecera As Boolean = True



    <SelfValidation()> _
    Public Sub DoValidate(ByVal results As ValidationResults)
        Me.Errores.Clear()
        If Me.monto <= 0 Then
            Me.CORREGIDO = False
            Me.AgregarError(1, "El Importe debe ser Mayor a 0")
            results.AddResult(New ValidationResult("El Importe debe ser Mayor a 0", GetType(Lecturas), "monto", "", Nothing))
        End If

        If Me.cadena_captura IsNot Nothing AndAlso Me.cadena_captura.Length > 100 Then
            Me.CORREGIDO = False
            results.AddResult(New ValidationResult("La cadena de Captura es mayor a lo requerido.", GetType(Lecturas), "cadena_captura", "", Nothing))
        End If

        'Se realiza solo para los cheques y no para las cabeceras
        If "00-01-02-03-04-05".Contains(Me.cod_tipdoc) Then

            If (Me.cod_proceso = 2 Or Me.cod_proceso = 1) Then
                If Me.cod_banco_emisor = Me.cod_banco_receptor Then ''Enviado y Devuelto
                    Me.CORREGIDO = False
                    Me.AgregarError(2, "El banco emisor no puede ser igual a receptor")
                    results.AddResult(New ValidationResult("El banco emisor no puede ser igual a receptor", GetType(Lecturas), "cod_banco_receptor", "", Nothing))

                End If
                'If Me.cod_proceso = 2 Or Me.cod_proceso = 1 Then
                If Me.cod_banco <> Me.cod_banco_emisor Then
                    Me.CORREGIDO = False
                    Me.AgregarError(3, "El banco receptor debe ser igual al banco actual")
                    results.AddResult(New ValidationResult("El banco receptor debe ser igual al banco actual", GetType(Lecturas), "cod_banco_emisor", "", Nothing))
                End If
            End If


            If Me.cod_proceso = 3 Or Me.cod_proceso = 4 Then
                If Me.cod_banco <> Me.cod_banco_receptor Then
                    Me.CORREGIDO = False
                    Me.AgregarError(4, "El banco emisor debe ser igual al banco actual")
                    results.AddResult(New ValidationResult("El banco emisor debe ser igual al banco actual", GetType(Lecturas), "cod_banco_receptor", "", Nothing))
                End If
                If Me.cod_banco = Me.cod_banco_emisor Then
                    Me.CORREGIDO = False
                    Me.AgregarError(5, "El banco receptor no puede ser igual al banco actual")
                    results.AddResult(New ValidationResult("El banco receptor no puede ser igual al banco actual", GetType(Lecturas), "cod_banco_emisor", "", Nothing))
                    _errors.Add("cod_banco_emisor", "El banco emisor no puede ser igual a receptor.")

                End If
            End If

            If Me.cuenta_cheque <= 0 Then
                Me.CORREGIDO = False
                Me.AgregarError(13, "El Nro de Cuenta no puede ser 0.")
                results.AddResult(New ValidationResult("El Nro de Cuenta no puede ser 0.", GetType(Lecturas), "cuenta_cheque", "", Nothing))

            End If

            _conError = Errores.Count > 0

        End If




        '  results.AddResult(New ValidationResult("No se puede validar", GetType(Lecturas), "", "", Nothing))

    End Sub

    Public Property ConError() As Boolean
        Get
            Return _conError
        End Get
        Set(ByVal value As Boolean)
            _conError = value
            OnPropertyChanged("ConError")

            '    RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("ConError"))

        End Set
    End Property

    Public Sub AgregarError(ByVal NroError As Integer, ByVal Descripcion As String)
        Me.Errores.Add(New Errores(NroError, Descripcion))
        Me.NroError = NroError
    End Sub

    Public Sub AgregarError(Campo As String, ByVal NroError As Integer)
        Me.Errores.Add(New Errores(NroError, Dic.Errores(NroError)))

        Me.NroError = NroError

        If Campo.Length > 0 Then
            Me.AddError(Campo, Dic.Errores(NroError))
        End If

    End Sub

    Public ReadOnly Property Errores() As List(Of Errores)
        Get
            If _Errores Is Nothing Then
                _Errores = New List(Of Errores)
            End If

            Return _Errores
        End Get
    End Property

    Public ReadOnly Property EsCabecera() As Boolean
        Get
            'Return _EsCabecera

            If Me.cod_tipdoc Is Nothing Then
                Return True
            End If

            If "00-01-02-03-04-05".Contains(Me.cod_tipdoc) Then
                Return False
            Else
                Return True
            End If
        End Get
    End Property


    Public Property MontoDetalle As Double





    Public Sub BeginEdit() Implements System.ComponentModel.IEditableObject.BeginEdit
        If Me.OldLectura Is Nothing Then
            Me.OldLectura = New Lecturas
            Me.OldLectura.numero_cheque = Me.numero_cheque
            Me.OldLectura.cabecera = Me.cabecera
            Me.OldLectura.cod_banco_receptor = Me.cod_banco_receptor
            Me.OldLectura.cod_banco_emisor = Me.cod_banco_emisor
            Me.OldLectura.monto = Me.monto
            Me.OldLectura.cod_camara = Me.cod_camara
            Me.OldLectura.cod_tipdoc = Me.cod_tipdoc
            Me.OldLectura.numero_cheque = Me.numero_cheque


        End If

    End Sub

    Public Sub CancelEdit() Implements System.ComponentModel.IEditableObject.CancelEdit
        If Not Me.OldLectura Is Nothing Then
            Me.numero_cheque = Me.OldLectura.numero_cheque
            Me.cabecera = Me.OldLectura.cabecera
            Me.cod_banco_receptor = Me.OldLectura.cod_banco_receptor
            Me.cod_banco_emisor = Me.OldLectura.cod_banco_emisor
            Me.monto = Me.OldLectura.monto
            Me.cod_camara = Me.OldLectura.cod_camara
            Me.cod_tipdoc = Me.OldLectura.cod_tipdoc
            Me.numero_cheque = Me.OldLectura.numero_cheque
        End If
    End Sub

    Public Sub EndEdit() Implements System.ComponentModel.IEditableObject.EndEdit
        Me.OldLectura = Nothing
    End Sub
    Public Property NroError() As Integer
        Get
            Return _NroError
        End Get
        Set(ByVal value As Integer)
            _NroError = value
        End Set
    End Property
#Region " Validacion"
    Private _errors As New Dictionary(Of String, String)()

    Public Sub AddError(ByVal Campo As String, ByVal ErrorInfo As String)
        _errors.Remove(Campo)
        _errors.Add(Campo, ErrorInfo)
    End Sub
    Public Sub ClearError()
        _errors.Clear()
    End Sub

    Private Sub Oncod_tipdocChanging(ByVal value As String)
        _errors.Remove("cod_tipdoc")
        If value = "@@" Then
            _errors.Add("cod_tipdoc", "Doc no valido")
        End If

        'VG 10-11-2011
        'Marcamos aqui si el registro es una cabecera
        'If value IsNot Nothing AndAlso "00-01-02-03-04-05".Contains(value) Then
        '    Me._EsCabecera = False
        'Else
        '    Me._EsCabecera = True
        'End If

    End Sub

    'Private Sub Oncod_banco_emisorChanging(ByVal value As String)
    '    _errors.Remove("cod_banco_emisor")

    '    If (Me.cod_proceso = 2 Or Me.cod_proceso = 1) Then

    '        'If Me.cod_proceso = 2 Or Me.cod_proceso = 1 Then
    '        If Me.cod_banco <> value Then
    '            Me.CORREGIDO = False
    '            Me.AgregarError(3, "El banco receptor debe ser igual al banco actual")
    '            _errors.Add("cod_banco_emisor", "El banco receptor debe ser igual al banco actual.")

    '        End If
    '    End If
    '    If Me.cod_proceso = 3 Or Me.cod_proceso = 4 Then

    '        If Me.cod_banco = value Then
    '            Me.CORREGIDO = False
    '            Me.AgregarError(5, "El banco receptor no puede ser igual al banco actual")
    '            _errors.Add("cod_banco_emisor", "El banco receptor no puede ser igual al banco actual.")

    '        End If
    '    End If
    'End Sub


    Public ReadOnly Property [Error]() As String Implements System.ComponentModel.IDataErrorInfo.Error
        Get
            Return String.Empty

        End Get
    End Property

    Default Public ReadOnly Property Item(ByVal columnName As String) As String Implements System.ComponentModel.IDataErrorInfo.Item
        Get
            If _errors.ContainsKey(columnName) Then
                Return _errors(columnName)
            End If
            Return String.Empty

        End Get
    End Property
#End Region

#Region "Implements IXmlSerializable"
    Public Function GetSchema() As System.Xml.Schema.XmlSchema Implements System.Xml.Serialization.IXmlSerializable.GetSchema
        Return Nothing
    End Function

    Public Sub ReadXml(ByVal reader As System.Xml.XmlReader) Implements System.Xml.Serialization.IXmlSerializable.ReadXml
        Dim _XmlReader As New CustomXmlSerializer
        _XmlReader.ReadXml(reader, Me)
    End Sub

    Public Sub WriteXml(ByVal writer As System.Xml.XmlWriter) Implements System.Xml.Serialization.IXmlSerializable.WriteXml
        Dim _XmlWriter As New CustomXmlSerializer
        _XmlWriter.WriteXml(Me, writer)
    End Sub
#End Region
End Class


Public Class Errores
    Private _Codigo As Integer
    Private _Error As String

    Sub New()

    End Sub

    Sub New(ByVal CodigoError As Integer, ByVal MensajeError As String)
        _Codigo = CodigoError
        _Error = MensajeError
    End Sub

    Public Property Codigo() As Integer
        Get
            Return _Codigo
        End Get
        Set(ByVal value As Integer)
            _Codigo = value
        End Set
    End Property
    Public Property [Error]() As String
        Get
            Return _Error
        End Get
        Set(ByVal value As String)
            _Error = value
        End Set
    End Property

End Class

Partial Public Class CRECDet
    Dim _Existe As String
    Public Property Existe() As String
        Get
            Return _Existe
        End Get
        Set(ByVal value As String)
            _Existe = value
        End Set
    End Property


End Class
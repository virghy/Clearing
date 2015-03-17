Imports System.Text

Public Class MICRGeneral
    Private _cabecera As MICRCabecera
    Private _detalle As MICRDetalle
    Private _tipo As TipoMICR
    Sub New(ByVal data As String, ByVal moneda As Moneda, ByVal Config As DataAccess.ConfigMICR)

        Try
            If data.Length > 0 Then

                ' MsgBox(data)
                'If data.Substring(3, 2) = "00" Or data.Length > 44 Then
                '    _detalle = New MICRDetalle(data, moneda)
                '    _tipo = TipoMICR.Detalle
                'Else
                '    _cabecera = New MICRCabecera(data, moneda, Config)
                '    _tipo = TipoMICR.Cabecera
                'End If
                If "00-01-02-03-04-05".Contains(data.Substring(3, 2)) Then
                    _detalle = New MICRDetalle(data, moneda)
                    _tipo = TipoMICR.Detalle
                ElseIf data.Substring(3, 2) = "90" OrElse data.Length <= 44 Then
                    _cabecera = New MICRCabecera(data, moneda, Config)
                    _tipo = TipoMICR.Cabecera
                Else
                    _detalle = New MICRDetalle(data, moneda)
                    _tipo = TipoMICR.Detalle
                End If


            Else
                _detalle = New MICRDetalle
                _tipo = TipoMICR.Detalle
            End If

        Catch ex As Exception
            _detalle = New MICRDetalle
            _tipo = TipoMICR.Detalle

        End Try


    End Sub

    Public Sub AsignarImagen(ByVal NombreImagen As String)
        If _tipo = TipoMICR.Cabecera Then
            If _cabecera.Imagen Is Nothing Then
                _cabecera.Imagen = IO.Path.GetFileName(NombreImagen)
            End If
        Else
            If _detalle.Imagen Is Nothing Then
                _detalle.Imagen = IO.Path.GetFileName(NombreImagen)
            Else
                _detalle.Imagen1 = IO.Path.GetFileName(NombreImagen)
            End If
        End If
    End Sub

    Public Property Cabecera() As MICRCabecera
        Get
            Return _cabecera
        End Get
        Set(ByVal value As MICRCabecera)
            _cabecera = value
        End Set
    End Property
    Public Property Detalle() As MICRDetalle
        Get
            Return _detalle
        End Get
        Set(ByVal value As MICRDetalle)
            _detalle = value
        End Set
    End Property
    Public Property Tipo() As MICR.TipoMICR
        Get
            Return _tipo
        End Get
        Set(ByVal value As MICR.TipoMICR)
            _tipo = value
        End Set
    End Property
End Class
Public Enum TipoMICR
    Cabecera
    Detalle
    Ninguno
End Enum

'Public Class MICRInfo

'End Class
Public Class MICRCabecera
    '     Las boletas de depósitos son reemplazadas por cabeceras, en las que se magnetiza: 
    '17*90*000000000000*00000000         00000000000000
    '17: código de banco
    '90: tipo de comprobante, en este caso cheque
    '000000000000: dígitos disponibles para el número de cuenta de depósito
    '00000000000000: dígitos disponibles para el monto en guaraníes
    'C3990E000000000001E00000007800523B


    Private _Banco As String
    Private _cpbt As String
    Private _cuenta As Double
    Private _importe As Double
    Private _cadena As String
    Private _imagen As String
    Private _moneda As Moneda
    Private _cheque As Double
    Private Dim _sucursal As String


    Private Function Extrar(ByVal valor As String, ByVal rango As String) As String
        Try

            Dim aRango(1) As String
            aRango = rango.Split(",")
            Extrar = valor.Substring(CInt(aRango(0)), CInt(aRango(1)))
            aRango = Nothing
            'Return valor.Substring(CInt(aRango(0)), CInt(aRango(1)))
        Catch ex As Exception
            Extrar = ""
        End Try
    End Function

    Sub New()

    End Sub
    Sub New(ByVal valor As String, ByVal moneda As Moneda, ByVal Config As DataAccess.ConfigMICR)
        Try
            _moneda = moneda
            _cadena = valor

            '_Banco = valor.Substring(1, 2)
            '_cpbt = valor.Substring(3, 2)
            '_cuenta = valor.Substring(6, 12)
            ''Transformamos el valor de acuerdo a la moneda
            '_importe = _moneda.Transform(CDbl(valor.Substring(19, 14)))

            ''VG 12/04/2010
            ''Si es que no fue codificado el banco y el tipo de Doc.
            ''insertamos espacios vacios
            If valor.StartsWith("E") Then
                valor += "C0090"
            End If

            _Banco = Me.Extrar(valor, Config.BancoReceptor)
            _cpbt = Me.Extrar(valor, Config.TipoDoc)

            Dim nCuenta As String = Me.Extrar(valor, Config.Cuenta)
            If IsNumeric(nCuenta) Then
                _cuenta = CDbl(nCuenta)
            Else
                _cuenta = 0
            End If

            If _cuenta > 999999999999 Then
                _cuenta = 0
            End If
            'Transformamos el valor de acuerdo a la moneda
            If Not Config.NroDoc Is Nothing AndAlso Config.NroDoc.TrimEnd.Length > 0 Then
                Dim nCheque As String = Me.Extrar(valor, Config.NroDoc)
                If IsNumeric(nCheque) Then
                    _cheque = IIf(IsNumeric(nCheque), CDbl(nCheque), 0)
                Else
                    _cheque = 0
                End If

            End If

            'Extraemos la Sucursal
            If Not Config.Sucursal Is Nothing AndAlso Config.Sucursal.TrimEnd.Length > 0 Then
                _sucursal = Me.Extrar(valor, Config.Sucursal)
            End If

            If Config.Longitud IsNot Nothing AndAlso valor.Length > Config.Longitud Then
                _importe = _moneda.Transform(CDbl(Me.Extrar(valor, Config.Importe2)))
            Else
                _importe = _moneda.Transform(CDbl(Me.Extrar(valor, Config.Importe)))
            End If


        Catch ex As Exception

        End Try
    End Sub
    Public Property Banco() As String
        Get
            Return _Banco
        End Get
        Set(ByVal value As String)
            _Banco = value
        End Set
    End Property

    Public Property Cheque() As Double
        Get
            Return _cheque
        End Get
        Set(ByVal value As Double)
            _cheque = value
        End Set
    End Property
    Public Property Cpbt() As String
        Get
            Return _cpbt
        End Get
        Set(ByVal value As String)
            _cpbt = value
        End Set
    End Property
    Public Property Cuenta() As String
        Get
            Return _cuenta
        End Get
        Set(ByVal value As String)
            _cuenta = value
        End Set
    End Property
    Public Property Importe() As Double
        Get
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value
        End Set
    End Property

    Public Property Imagen() As String
        Get
            Return _imagen
        End Get
        Set(ByVal value As String)
            _imagen = value
        End Set
    End Property
    Public ReadOnly Property Cadena() As String
        Get
            Return _cadena
        End Get
    End Property
    Public Property Moneda() As Moneda
        Get
            Return _moneda
        End Get
        Set(ByVal value As Moneda)
            _moneda = value
        End Set
    End Property
    Public Property Sucursal() As String
        Get
            Return _sucursal
        End Get
        Set(ByVal value As String)
            _sucursal = value
        End Set
    End Property

End Class

Public Class MICRDetalle
    '•	Código de banco emisor.
    '•	Número de documento = 00.
    '•	Número de cuenta.
    '•	Número de cheque.
    '•	Código de banco receptor.
    '•	Código de cámara compensadora = 02.
    '•	Monto.
    'C0700 E 010001137718 E 00785623 A 3901 00000002500000B

    Private _BancoEmisor As String
    Private _cpbt As String
    Private _cuenta As Double
    Private _cheque As Double
    Private _BancoReceptor As String
    Private _Camara As String
    Private _importe As Double
    Private _cadenaDet As String
    Private _imagen As String
    Private _imagen1 As String
    Private Dim _moneda As Moneda

    Sub New()
        _cadenaDet = ""
        _BancoEmisor = ""
        _cpbt = ""
        _cuenta = 0
        _cheque = 0
        _BancoReceptor = ""
        _Camara = ""
        _importe = 0

    End Sub
    Sub New(ByVal valor As String, ByVal moneda As Moneda)
        Try
            Dim inicio As Integer, fin As Integer, final As Integer
            _moneda = moneda
            _cadenaDet = valor
            _BancoEmisor = valor.Substring(1, 2)
            _cpbt = valor.Substring(3, 2)

            inicio = valor.IndexOf("E", 0, 8) + 1

            If inicio = 1 Then
                inicio = 6
            End If

            fin = valor.IndexOf("E", inicio)
            If fin = 0 Then
                fin = 18
            End If
            final = fin - inicio

            'Por si supere la longitud maxima permitida, le asignamos el maximo
            If final > 12 Then
                final = 12
            End If

            If IsNumeric(valor.Substring(inicio, final)) Then
                _cuenta = valor.Substring(inicio, final)
            Else
                _cuenta = 0
            End If

            'Nro de Cheque
            inicio = valor.IndexOf("E", inicio) + 1
            If inicio = 0 Then
                inicio = 19
            End If

            fin = valor.IndexOf("A", 0)
            If fin = 0 Then
                fin = 27
            End If
            final = fin - inicio

            'Por si supere la longitud maxima permitida, le asignamos el maximo
            If final > 8 Then
                final = 8
            End If

            If IsNumeric(valor.Substring(inicio, final)) Then
                _cheque = valor.Substring(inicio, final)
            Else
                _cheque = 0
            End If

            'Banco, Camara e Importe

            inicio = valor.IndexOf("A", 6) + 1
            If inicio = 0 Then
                inicio = 28
            End If
            'Si la longitud restante es mayor a 19
            'entonces hay un @ agregado al string

            valor = Limpiar(valor.Substring(inicio), 19)
            inicio = 0
            _BancoReceptor = valor.Substring(inicio, 2)
            _Camara = valor.Substring(inicio + 2, 2)



            '    If valor.Length - inicio < 18 Then
            If valor.Length < 18 Then
                'fin = (valor.Length - inicio) - 1
                fin = (valor.Length) - 1
                If fin > 14 Then
                    fin = 14
                End If

            Else
                inicio += 4
                fin = 14
            End If

            'Hacemos la conversion del importe
            'de acuerdo a la moneda
            If IsNumeric(valor.Substring(inicio, fin)) Then
                _importe = _moneda.Transform(CDbl(valor.Substring(inicio, fin)))
            Else
                _importe = 0
            End If


        Catch ex As Exception

        End Try

    End Sub
    Public Property BancoE() As String
        Get
            Return _BancoEmisor
        End Get
        Set(ByVal value As String)
            _BancoEmisor = value
        End Set
    End Property

    Public Property Cpbt() As String
        Get
            Return _cpbt
        End Get
        Set(ByVal value As String)
            _cpbt = value
        End Set
    End Property
    Public Property Cuenta() As String
        Get
            Return _cuenta
        End Get
        Set(ByVal value As String)
            _cuenta = value
        End Set
    End Property
    Public Property Cheque() As String
        Get
            Return _cheque
        End Get
        Set(ByVal value As String)
            _cheque = value
        End Set
    End Property
    Public Property BancoR() As String
        Get
            Return _BancoReceptor
        End Get
        Set(ByVal value As String)
            _BancoReceptor = value
        End Set
    End Property

    Public Property Camara() As String
        Get
            Return _Camara
        End Get
        Set(ByVal value As String)
            _Camara = value
        End Set
    End Property

    Public Property Importe() As Double
        Get
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value
        End Set
    End Property

    Public Property Imagen() As String
        Get
            Return _imagen
        End Get
        Set(ByVal value As String)
            _imagen = value
        End Set
    End Property
    Public Property Imagen1() As String
        Get
            Return _imagen1
        End Get
        Set(ByVal value As String)
            _imagen1 = value
        End Set
    End Property
    Public ReadOnly Property CadenaDet() As String
        Get
            Return _cadenaDet
        End Get
    End Property
    Public Property Moneda() As Moneda
        Get
            Return _moneda
        End Get
        Set(ByVal value As Moneda)
            _moneda = value
        End Set
    End Property
    Function Limpiar(ByVal cadena As String, ByVal Longitud As Int16) As String
        Dim nueva As String = cadena
        While cadena.Length > Longitud
            If cadena.IndexOf("@") < 0 Then
                Exit While
            End If
            cadena = cadena.Remove(cadena.IndexOf("@"), 1)
        End While
        Return cadena
    End Function
End Class


Public Class Moneda
    Private _codMoneda As String
    Private _decimales As Double
    Private _Constante As Double
    Sub New(ByVal Codigo As String, ByVal NroDecimales As Double)
        _codMoneda = Codigo
        Decimales = NroDecimales
    End Sub

    Public Property CodMoneda() As String
        Get
            Return _codMoneda
        End Get
        Set(ByVal value As String)
            _codMoneda = value
        End Set
    End Property
    Public Property Decimales() As Double
        Get
            Return _decimales
        End Get
        Set(ByVal value As Double)
            _decimales = value
            If value > 0 Then
                _Constante = CDbl("1" + Replicate("0", value))
            Else
                _Constante = 1
            End If
        End Set

    End Property

    Public Function Transform(ByVal valor As Double) As Double
        'Si es 1 no hacemos nada
        If _Constante = 1 Then
            Return valor
        Else
            Return Decimal.Round(CDec(valor / _Constante), CInt(_decimales))
        End If
    End Function

#Region " Replicate                 "
    ''' <summary>
    ''' Replicates the specified item.
    ''' </summary>
    ''' <param name="item">The item to replicate.</param>
    ''' <param name="repeat">The number of times repeat item.</param>
    ''' <returns>Replicated string</returns>
    Public Shared Function Replicate(ByVal item As String, ByVal repeat As Integer) As String
        If item Is Nothing Then Return String.Empty
        If repeat <= 0 Then Return String.Empty
        Dim work As StringBuilder = New StringBuilder(repeat * item.Length)
        For i As Integer = 0 To repeat - 1
            work.Append(item)
        Next
        Return work.ToString()
    End Function



#End Region

   

End Class

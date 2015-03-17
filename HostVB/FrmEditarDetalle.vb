
Imports DataAccess
Imports System.IO

Public Class FrmEditarDetalle
    ' Private Shared frm As FrmEditarDetalle
    Private Lectura As DataAccess.Lecturas
    'Private imagen As Image
    Public SoloLectura As Boolean = False
    'Dim dxe As Sorteable.FilteredBindingList(Of Lecturas)
    Private Moneda As New MICR.Moneda(My.Application.Moneda.cod_moneda, My.Application.Moneda.decimales)

    'Public Shared Function Instancia(ByVal dataSource As BindingSource) As FrmEditarDetalle
    '    If frm Is Nothing Then
    '        frm = New FrmEditarDetalle(dataSource, Nothing)
    '    End If
    '    frm.LecturasBindingSource = dataSource
    '    frm.Lectura = frm.LecturasBindingSource.Current
    '    Return frm
    'End Function

    Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Sub New(ByRef dataSource As Lecturas)
        ', ByVal dx As Sorteable.FilteredBindingList(Of Lecturas))
        MyBase.New()
        Me.InitializeComponent()
        Me.LecturasBindingSource.DataSource = dataSource
        ' Me.dxe = dx
        Me.Lectura = Me.LecturasBindingSource.Current

        txtCab.DataBindings.Add("text", Me.LecturasBindingSource, "Cabecera", _
        True, DataSourceUpdateMode.OnPropertyChanged)
        txtBanco.DataBindings.Add("text", Me.LecturasBindingSource, "cod_banco_receptor", _
                True, DataSourceUpdateMode.OnPropertyChanged)
        txtCuenta.DataBindings.Add("text", Me.LecturasBindingSource, "cuenta_cheque", _
                True, DataSourceUpdateMode.OnPropertyChanged, 0)
        txtDoc.DataBindings.Add("text", Me.LecturasBindingSource, "cod_tipdoc", _
        True, DataSourceUpdateMode.OnPropertyChanged)
        txtSerie.DataBindings.Add("text", Me.LecturasBindingSource, "numero_cheque", _
                True, DataSourceUpdateMode.OnPropertyChanged, 0)
        txtCamara.DataBindings.Add("text", Me.LecturasBindingSource, "cod_camara", _
                True, DataSourceUpdateMode.OnPropertyChanged)
        txtReceptor.DataBindings.Add("text", Me.LecturasBindingSource, "cod_banco_emisor", _
        True, DataSourceUpdateMode.OnPropertyChanged)
        txtMonto.DataBindings.Add("text", Me.LecturasBindingSource, "monto", _
True, DataSourceUpdateMode.OnPropertyChanged, 0, "N" + My.Application.Moneda.decimales.ToString)
        lblCadena.DataBindings.Add("text", Me.LecturasBindingSource, "cadena_captura", _
True, DataSourceUpdateMode.OnPropertyChanged)

        'CType(Me.LecturasBindingSource.Current, Lecturas).BeginEdit()




        '        Me.LecturasBindingSource.ResetBindings(False)

    End Sub

    'Sub New(ByVal obj As DataAccess.Lecturas)
    '    MyBase.New()
    '    InitializeComponent()
    '    Lectura = obj

    '    'Es cuando inserta un nuevo registro
    '    If obj.cabecera Is Nothing Then
    '        Return
    '    End If

    '    Me.txtCab.Text = obj.cabecera
    '    Me.txtBanco.Text = obj.cod_banco_receptor
    '    Me.txtCuenta.Text = obj.cuenta_cheque
    '    Me.txtDoc.Text = obj.cod_tipdoc
    '    Me.txtSerie.Text = obj.numero_cheque
    '    Me.txtMonto.Text = CDbl(obj.monto).ToString("N" + My.Application.Moneda.decimales.ToString)
    '    Me.txtReceptor.Text = obj.cod_banco_emisor
    '    Me.txtCamara.Text = obj.cod_camara
    '    Me.lblCadena.Text = obj.cadena_captura

    'End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.LecturasBindingSource.CancelEdit()
        Me.Close()
    End Sub
    Function grabar() As Integer
        Try
            ' dxe.SaveChanges("Lecturas")
            Return 1
        Catch ex As Exception
            MsgBox(Util.EnumErrors(ex))
            Return -1
        End Try
    End Function

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If Me.SoloLectura Then
            Me.LecturasBindingSource.CancelEdit()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
            Return
        End If

        If Me.ActiveControl.Name = "txtMonto" Then
            Me.txtMonto_Leave(Nothing, Nothing)
        End If

        If Me.ValidateChildren() And Me.Validar() Then
            Lectura = Me.LecturasBindingSource.Current
            Lectura.CORREGIDO = True
            Lectura.Editado = True
            Lectura.audit_fecha = Date.Now

            If Me.grabar() > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If

        'Me.LecturasBindingSource.EndEdit()


        'If Me.txtCab.Text.Length > 0 Then
        '    Lectura.cabecera = CInt(Me.txtCab.Text)
        'Else

        '    Lectura.cabecera = 0
        'End If

        'Lectura.cod_banco_receptor = Me.txtBanco.Text
        'Lectura.cuenta_cheque = Me.txtCuenta.Text
        'Lectura.cod_tipdoc = Me.txtDoc.Text
        'Lectura.numero_cheque = Me.txtSerie.Text
        'Lectura.monto = Me.txtMonto.Text
        'Lectura.cod_banco_emisor = Me.txtReceptor.Text
        'Lectura.cod_camara = Me.txtCamara.Text
        'Lectura.CORREGIDO = True
        'Lectura.audit_fecha = Date.Now

        '    Me.Close()
    End Sub

    Private Sub FrmEditarDetalle_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Not Me.Lectura.imagen_frontal Is Nothing Then
            cargarImagen(Lectura.imagen_frontal)
        End If

        If Me.Lectura.NroError <> 0 Then

            Select Case Lectura.NroError
                Case 2
                    Me.txtBanco.Focus()
                Case 10 'No existe el banco indicado
                    Me.txtBanco.Focus()
                Case 5
                    Me.txtBanco.Focus()
                Case 11 'No existe el tipo de documento indicado
                    Me.txtDoc.Focus()
                Case 6
                    Me.txtSerie.Focus()
                Case 3
                    Me.txtReceptor.Focus()
                Case 8
                    Me.txtReceptor.Focus()
                Case 4
                    Me.txtBanco.Focus()
                Case 12 'No existe la camara indicada
                    Me.txtCamara.Focus()
                Case 13 'Cuenta 0
                    Me.txtCuenta.Focus()

                Case 1
                    Me.txtMonto.Focus()
                Case 7  'Diferencia en cabecera
                Case 9 'El registro no tiene cabecera
            End Select

        End If
    End Sub

    Private Sub FrmEditarDetalle_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Me.PictureBox1.Image IsNot Nothing Then
            Me.PictureBox1.Image = Nothing
        End If
    End Sub

    Private Sub FrmEditarDetalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Enter Then
            e.Handled = True
            Dim actual As Control = Me.ActiveControl

            Me.SelectNextControl(actual, True, True, True, True)
            'SendKeys.Send("{TAB}")
        End If
        ' MyBase.OnKeyDown(e)
    End Sub

    Private Sub FrmEditarDetalle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.Lectura.imagen_frontal Is Nothing Then
            '    cargarImagen(Lectura.imagen_frontal)
        End If

    End Sub

    Sub cargarImagen(ByVal nombre As String)

        Try
            If Not nombre Is Nothing Then
                Dim FilePath As String = Util.ConfigCarpetaImagen

                If IO.File.Exists(Path.Combine(FilePath, nombre)) Then
                    If Me.PictureBox1.Image IsNot Nothing Then
                        Me.PictureBox1.Image = Nothing
                    End If
                    Me.PictureBox1.Image = Image.FromFile(Path.Combine(FilePath, nombre))
                    'Me.PictureBox1.Image = imagen
                End If
            End If

            'If Me.PictureBox1.Image Is Nothing Then
            '    Me.PictureBox1.Image = Image.FromFile(FileName)
            'Else
            '    Me.PictureBox2.Image = Image.FromFile(FileName)


            'End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Not Me.Lectura.imagen_reverso Is Nothing Then
            cargarImagen(Lectura.imagen_reverso)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not Me.Lectura.imagen_frontal Is Nothing Then
            cargarImagen(Lectura.imagen_frontal)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Not Me.PictureBox1.Image Is Nothing Then
            Me.PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
            Me.PictureBox1.Refresh()
            'Me.PictureBox1.Image = imagen
        End If
    End Sub

    Private Sub LecturasBindingSource_BindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.BindingCompleteEventArgs) Handles LecturasBindingSource.BindingComplete
        ' If the BindingComplete state is anything other than success, 
        ' set the ErrorProvider to the error message.
        If e.BindingCompleteState <> BindingCompleteState.Success Then
            ErrorProvider1.SetError( _
              CType(e.Binding.BindableComponent, Control), e.ErrorText)
        Else
            ErrorProvider1.SetError( _
              CType(e.Binding.BindableComponent, Control), "")
        End If

    End Sub

    Private Sub txtMonto_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.Enter
        ' If txtMonto.Text.Contains(",") Then
        txtMonto.Text = txtMonto.Text.Replace(",", "")
        txtMonto.Text = txtMonto.Text.Replace(".", "")
        ' End If
    End Sub

    Private Sub txtMonto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        If IsNumeric(Me.txtMonto.Text) Then
            txtMonto.Text = Moneda.Transform(txtMonto.Text)
        End If
    End Sub

    Private Sub FrmEditarDetalle_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Validating
        If Me.txtSerie.Text.Length = 0 Then
            MsgBox("Indique la serie del documento")
            e.Cancel = True
        End If
    End Sub

    Function Validar() As Boolean
        If Me.txtBanco.Text.Length = 0 Then
            MsgBox("Indique el Banco")
            Return False
        End If

        If Me.txtDoc.Text.Length = 0 Then
            MsgBox("Indique el tipo de Documento")
            Return False
        End If
        'If Me.txtSerie.Text.Length = 0 Then
        If Me.txtSerie.Text.Length = 0 Or (Me.txtSerie.Text = "0" And Me.txtDoc.Text <> "90") Then
            MsgBox("Indique la serie del documento")
            Return False
        End If

        If Me.txtReceptor.Text.Length = 0 Then
            MsgBox("Indique el Receptor")
            Return False
        End If

        If Me.txtMonto.Text.Length = 0 Or Me.txtMonto.Text = 0 Then
            MsgBox("Indique en Monto")
            Return False
        End If




        Return True
    End Function


End Class
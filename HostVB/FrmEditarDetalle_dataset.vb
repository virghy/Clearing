
Imports DataAccess
Public Class FrmEditarDetalle_Dataset
    Friend Lectura As ClearingDataSets.LecturasRow
    Private imagen As Image
    Dim dxe As Sorteable.FilteredBindingList(Of Lecturas)
    Private Moneda As New MICR.Moneda(My.Application.Moneda.cod_moneda, My.Application.Moneda.decimales)
    Private Shared _frm As FrmEditarDetalle

    Public Shared Function Instancia() As FrmEditarDetalle
        If _frm Is Nothing Then
            _frm = New FrmEditarDetalle
        End If
        Return _frm
    End Function
    Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        txtMonto.DataBindings.Add("text", Me.LecturasBindingSource, "monto", _
True, DataSourceUpdateMode.OnPropertyChanged, 0, "N" + My.Application.Moneda.decimales.ToString)

    End Sub

    Sub New(ByVal dataSource As BindingSource, ByVal dx As Sorteable.FilteredBindingList(Of Lecturas))
        MyBase.New()
        Me.InitializeComponent()
        Me.LecturasBindingSource = dataSource
        Me.dxe = dx
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

    Sub New(ByVal obj As DataAccess.Lecturas)
        MyBase.New()
        InitializeComponent()
        '  Lectura = obj

        'Es cuando inserta un nuevo registro
        If obj.cabecera Is Nothing Then
            Return
        End If

        Me.txtCab.Text = obj.cabecera
        Me.txtBanco.Text = obj.cod_banco_receptor
        Me.txtCuenta.Text = obj.cuenta_cheque
        Me.txtDoc.Text = obj.cod_tipdoc
        Me.txtSerie.Text = obj.numero_cheque
        Me.txtMonto.Text = CDbl(obj.monto).ToString("N" + My.Application.Moneda.decimales.ToString)
        Me.txtReceptor.Text = obj.cod_banco_emisor
        Me.txtCamara.Text = obj.cod_camara
        Me.lblCadena.Text = obj.cadena_captura

    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.LecturasBindingSource.CancelEdit()
        Me.Close()
    End Sub
    Function grabar() As Integer
        Try
            Me.Validate()
            Me.LecturasBindingSource.EndEdit()
            ' Me.TableAdapterManager.UpdateAll(Me.LecturasBindingSource.DataSource)

            Return 1
        Catch ex As Exception
            MsgBox(Util.EnumErrors(ex))
            Return -1
        End Try


    End Function
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Me.txtMonto_Leave(Nothing, Nothing)
        If Me.ValidateChildren() And Me.Validar() Then
            Lectura = CType(Me.LecturasBindingSource.Current, DataRowView).Row
            Lectura.CORREGIDO = True
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

    Private Sub FrmEditarDetalle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.Lectura.Isimagen_frontalNull Then
            cargarImagen(Lectura.imagen_frontal)
        End If

    End Sub

    Sub cargarImagen(ByVal nombre As String)

        Try
            If Not nombre Is Nothing Then
                imagen = Image.FromFile(My.Application.Info.DirectoryPath + "\Images\" + nombre)
                Me.PictureBox1.Image = imagen
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
        If Not Me.Lectura.Isimagen_reversoNull Then
            cargarImagen(Lectura.imagen_reverso)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not Me.Lectura.Isimagen_frontalNull Then
            cargarImagen(Lectura.imagen_frontal)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Not imagen Is Nothing Then
            imagen.RotateFlip(RotateFlipType.Rotate180FlipNone)
            Me.PictureBox1.Image = imagen
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
        If txtMonto.Text.Contains(",") Then
            txtMonto.Text = txtMonto.Text.Replace(",", "")
            txtMonto.Text = txtMonto.Text.Replace(".", "")
        End If
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

        If Me.txtMonto.Text.Length = 0 Then
            MsgBox("Indique en Monto")
            Return False
        End If



        Return True
    End Function
End Class
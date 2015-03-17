Imports MICR.CanonAPIbase
Imports System.IO

Public Class frmConfig
    Dim dm As New DataAccess.Entities
    Dim ConfigFilePath As String
    Private Sub frmConfig_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.BancosBindingSource.DataSource = (From b In dm.Bancos Select b Order By b.nombre_banco).ToList
        Me.CamaraBindingSource.DataSource = (From c In dm.Camaras Select c Order By c.Ciudad).ToList

        'Config Enviados
        Me.ConfigMICRBindingSource.DataSource = dm.ConfigMICR.Where(Function(p) p.IdBanco = My.Application.Banco.cod_banco And p.IdProceso = 2)

        If Me.ConfigMICRBindingSource.Count = 0 Then
            Dim oConfig As New DataAccess.ConfigMICR
            oConfig.IdBanco = My.Application.Banco.cod_banco
            oConfig.IdProceso = 2
            Me.ConfigMICRBindingSource.Add(oConfig)
            dm.AddToConfigMICR(oConfig)
        End If

        'Config Recibidos
        Me.ConfigRecibidosBindingSource.DataSource = dm.ConfigMICR.Where(Function(p) p.IdBanco = My.Application.Banco.cod_banco And p.IdProceso = 3)

        If Me.ConfigRecibidosBindingSource.Count = 0 Then
            Dim oConfig As New DataAccess.ConfigMICR
            oConfig.IdBanco = My.Application.Banco.cod_banco
            oConfig.IdProceso = 3
            Me.ConfigRecibidosBindingSource.Add(oConfig)
            dm.AddToConfigMICR(oConfig)
        End If


        If Not My.Application.Banco Is Nothing Then
            Me.cboEmpresa.SelectedValue = My.Application.Banco.cod_banco
        End If

        Me.cboCamara.SelectedValue = My.Settings.Camara
        Me.nudMaquina.Value = My.Settings.Maquina
        Me.txtCarpetaResultado.Text = My.Settings.Carpeta
        Me.txtCarpetaImagen.Text = My.Settings.CarpetaImagen
        Me.cboScanner.SelectedItem = My.Settings.Scanner

        If My.Settings.CalidadImpresion IsNot Nothing Then
            Me.cboCalidad.SelectedItem = IIf(My.Settings.CalidadImpresion = "F", "Final", "Borrador")
        Else
            Me.cboCalidad.SelectedItem = "Final"
        End If

        Me.ConfigScanner()

    End Sub

    Sub ConfigScanner()
        ConfigFilePath = Path.Combine(My.Application.Info.DirectoryPath, CONFIG_FILE)

        Dim NroOper As String = ""
        Select Case My.Application.IdProceso
            Case Operacion.Devuelto
                NroOper = "1"
            Case Operacion.Enviado
                NroOper = "2"
            Case Operacion.Recibido
                NroOper = "3"
            Case Operacion.Rechazado
                NroOper = "4"
            Case Operacion.Interna
                NroOper = "5"
        End Select

        Dim NewConfigFile As String = Path.Combine(My.Application.Info.DirectoryPath, String.Concat("Canon", NroOper, ".ini"))

        Dim fi1 As New FileInfo(NewConfigFile)
        If fi1.Exists Then
            ConfigFilePath = NewConfigFile
        End If

    End Sub



    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try
            My.Settings.IdEmpresa = Me.cboEmpresa.SelectedValue
            My.Settings.Camara = Me.cboCamara.SelectedValue.ToString.Trim(" ").PadLeft(2, "0")
            My.Settings.Maquina = Me.nudMaquina.Value.ToString
            My.Settings.Carpeta = Me.txtCarpetaResultado.Text
            My.Settings.CarpetaImagen = Me.txtCarpetaImagen.Text
            My.Settings.Scanner = Me.cboScanner.SelectedItem
            My.Settings.CalidadImpresion = IIf(Me.cboCalidad.SelectedItem = "Final", "F", "B")
            Me.Visible = False
            My.Settings.Save()
            dm.SaveChanges()
            My.Application.cargarInicial()
            Me.Close()

        Catch ex As Exception
            MsgBox(Util.EnumErrors(ex), MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdPredet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPredet.Click
        Me.BancoReceptorTextBox.Text = "1, 2"
        Me.TipoDocTextBox.Text = "3, 2"
        Me.CuentaTextBox.Text = "6, 12"
        Me.NroDocTextBox.Text = ""
        Me.SucursalTextBox.Text = ""
        Me.CajeroTextBox.Text = ""
        Me.ImporteTextBox.Text = "19, 14"
        Me.ConfigMICRBindingSource.EndEdit()

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.txtBanco.Text = "1, 2"
        Me.txtTipoDoc.Text = "3, 2"
        Me.txtCuenta.Text = "6, 12"
        Me.txtNroDoc.Text = ""
        Me.txtSucursal.Text = ""
        Me.txtCajero.Text = ""
        Me.txtImporte.Text = "19, 14"
        Me.ConfigRecibidosBindingSource.EndEdit()
    End Sub

    Private Sub cboEmpresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEmpresa.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim micr As MICR.CanonAPIbase = My.Application.Scanner
        Dim result As Integer = 0
        Dim hInstance As Long = System.Runtime.InteropServices.Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0)).ToInt32()
        result = micr.CsdProbe()

        result = micr.CsdParSet(CSDP_LOAD_CONFIG_FILE, ConfigFilePath)

        If micr.CsdDrvDialog(hInstance, Me.Handle.ToInt32, 0) = 0 Then
            result = micr.CsdParSet(CSDP_SAVE_CONFIG_FILE, ConfigFilePath)

        End If
    End Sub
End Class
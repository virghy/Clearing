Imports System.Windows.Forms

Public Class frmPrincipal

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewWindowToolStripMenuItem.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*" 

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
        SendKeys.Send("^X")
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
        SendKeys.Send("^C")
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
        SendKeys.Send("^V")
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        '    Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub CámaraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CámaraToolStripMenuItem.Click
        Me.AbrirForm(frmCamara)
    End Sub

    Sub AbrirForm(ByVal frm As Form)
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BancosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BancosToolStripMenuItem.Click
        Me.AbrirForm(frmBanco)
    End Sub

    Private Sub SucursalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SucursalesToolStripMenuItem.Click
        Me.AbrirForm(frmSucursal)
    End Sub

    Private Sub MáquinasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MáquinasToolStripMenuItem.Click
        Me.AbrirForm(frmMaquina)
    End Sub

    Private Sub MonedasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonedasToolStripMenuItem.Click
        Me.AbrirForm(frmMoneda)
    End Sub

    Private Sub PruebaMICRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PruebaMICRToolStripMenuItem.Click
        Me.AbrirForm(EjemploMICR)

    End Sub

    Private Sub EnviadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviadosToolStripMenuItem.Click
        '   Me.AbrirForm(frmLectura)
        'Dim frm As New frmRecibidoDataset(My.Settings.Camara, "01", Operacion.Enviado)
        Dim frm As New frmRecibido(My.Settings.Camara, "01", Operacion.Enviado)
        Me.AbrirForm(frm)
        frm.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub frmPrincipal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub



    Private Sub frmPrincipal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If My.Settings.IdEmpresa.Length = 0 Then
                ' Me.AbrirForm(frmConfig)
                Dim frm As New frmConfig
                If frm.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                    Application.Exit()
                End If
            End If

            My.Application.cargarInicial()
        Catch ex As Exception
            MsgBox(ex.Message)
            Application.Exit()
        End Try

        Me.lnkRechazos.Visible = My.Application.IdProceso = Operacion.Interna

        Me.ToolStripStatusLabel1.Text = My.User.Name
        Me.tssEmpresa.Text = String.Format("{0} {1}", My.Application.Banco.cod_banco, My.Application.Banco.nombre_banco)
        Me.lnkIniciarCaptura.Text = String.Format("Iniciar {0}", Util.NombreProceso(My.Application.IdProceso))
        Me.tssMoneda.Text = String.Format("Moneda {0} {1}", My.Application.Moneda.cod_moneda, My.Application.Moneda.descripcion)
    End Sub

    Private Sub RecibidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecibidosToolStripMenuItem.Click
        Dim frm As New frmRecibido(My.Settings.Camara, "01", Operacion.Recibido)
        Me.AbrirForm(frm)
        frm.WindowState = FormWindowState.Maximized
    End Sub

    'Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.AbrirForm(Form1)
    'End Sub

    Private Sub DevueltosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevueltosToolStripMenuItem.Click
        Dim frm As New frmRecibido(My.Settings.Camara, "01", Operacion.Devuelto)
        Me.AbrirForm(frm)
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub lnkIniciarCaptura_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkIniciarCaptura.LinkClicked
        'Using frm As New frmRecibido(My.Settings.Camara, "01", My.Application.IdProceso)
        '    Me.AbrirForm(frm)
        'End Using
        Dim frm As New frmRecibido(My.Settings.Camara, "01", My.Application.IdProceso)
        Me.AbrirForm(frm)
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ConfiguracionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguracionToolStripMenuItem.Click
        Me.AbrirForm(frmConfig)
    End Sub

    Private Sub VariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VariosToolStripMenuItem.Click
        Me.AbrirForm(Reportes)
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        SendKeys.Send("^A")
    End Sub

    Private Sub ArchivoASCIIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchivoASCIIToolStripMenuItem.Click
        Me.AbrirForm(frmInterfases)
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim frm As New frmCierre(My.Settings.Camara, "01", My.Application.IdProceso)
        Me.AbrirForm(frm)
    End Sub

    Private Sub DToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DToolStripMenuItem.Click
        Me.AbrirForm(frmBuscaCheque)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Me.AbrirForm(AcercaDe)
    End Sub

    Private Sub RechazadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechazadosToolStripMenuItem.Click
        Dim frm As New frmRecibido(My.Settings.Camara, "01", Operacion.Rechazado)
        Me.AbrirForm(frm)
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub MotivosDeRechazoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MotivosDeRechazoToolStripMenuItem.Click
        Me.AbrirForm(frmMotivosRechazo)
    End Sub

    Private Sub CuentasEspecialesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentasEspecialesToolStripMenuItem.Click
        Me.AbrirForm(frmCuentasEspeciales)
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuarioToolStripMenuItem.Click
        Me.AbrirForm(frmUserProfile)
    End Sub

    Private Sub ListaDeUsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaDeUsuariosToolStripMenuItem.Click
        Me.AbrirForm(frmUsuarios)
    End Sub

    Private Sub FormatoDeExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormatoDeExportToolStripMenuItem.Click
        Me.AbrirForm(frm_Ascii)
    End Sub

    Private Sub ClasificacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClasificacionToolStripMenuItem.Click
        Me.AbrirForm(frmClasificacion)
    End Sub

    Private Sub GruposYPermisosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GruposYPermisosToolStripMenuItem.Click
        Me.AbrirForm(frmGrupos)
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        Me.AbrirForm(frmUserSettings)
    End Sub

    Private Sub CamInternaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CamInternaToolStripMenuItem.Click
        Dim frm As New frmRecibido(My.Settings.Camara, "01", Operacion.Interna)
        Me.AbrirForm(frm)
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub EmpaquetarImagenesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpaquetarImagenesToolStripMenuItem.Click
        Me.AbrirForm(frmEmpaquetar)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkRechazos.LinkClicked
        Me.AbrirForm(frmRechazos)
    End Sub
End Class

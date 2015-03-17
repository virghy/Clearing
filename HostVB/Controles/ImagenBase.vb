Imports System.ComponentModel
Imports System.IO

Public Class ImagenBase
    Private _PosicionMenu As Posicion
    Private _NombreImagen As String
    Private _NombreImagen1 As String
    Dim ImagenFrontal As Boolean = False
    Public Event CambiarImagen()
    Public Property Imagen() As Image
        Get
            Return Me.PictureBox1.Image
        End Get
        Set(ByVal value As Image)
            Me.PictureBox1.Image = value
            '  Me.ToolStripContainer1.TopToolStripPanel

        End Set
    End Property

    Public Property NombreImagen() As String
        Get
            Return _NombreImagen
        End Get
        Set(ByVal value As String)
            _NombreImagen = value
            If value IsNot Nothing Then
                cargarImagen(value)
                ImagenFrontal = True
            Else
                'Si tiene imagen, limpiamos porque vino nulo
                If Imagen IsNot Nothing Then
                    Imagen = Nothing
                End If
            End If
        End Set
    End Property
    Public Property NombreImagen1() As String
        Get
            Return _NombreImagen1
        End Get
        Set(ByVal value As String)
            _NombreImagen1 = value
        End Set
    End Property
    <DefaultValue(4)> _
    Public Property PosicionMenu() As Posicion
        Get
            Return _PosicionMenu
        End Get
        Set(ByVal value As Posicion)
            _PosicionMenu = value
            Select Case value
                Case Posicion.Bottom
                    Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.ToolStrip1)
                Case Posicion.Left
                    Me.ToolStripContainer1.LeftToolStripPanel.Controls.Add(Me.ToolStrip1)
                Case Posicion.Right
                    Me.ToolStripContainer1.RightToolStripPanel.Controls.Add(Me.ToolStrip1)
                Case Posicion.Top
                    Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
            End Select
        End Set
    End Property

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If Not Imagen Is Nothing Then
            Imagen.RotateFlip(RotateFlipType.Rotate180FlipNone)
            Me.PictureBox1.Refresh()
        End If

    End Sub
    Public Enum Posicion
        Left = 1
        Top = 2
        Bottom = 3
        Right = 4
    End Enum

    Sub cargarImagen(ByVal nombre As String)

        Try
            If Not nombre Is Nothing Then
                Dim FilePath As String = Util.ConfigCarpetaImagen

                If IO.File.Exists(Path.Combine(FilePath, nombre)) Then
                    If Imagen IsNot Nothing Then
                        Imagen = Nothing
                    End If
                    Imagen = Image.FromFile(Path.Combine(FilePath, nombre))
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

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        RaiseEvent CambiarImagen()
        If ImagenFrontal = False Then
            If Me.NombreImagen IsNot Nothing Then
                cargarImagen(Me.NombreImagen)

            End If
            ImagenFrontal = True
        Else
            If Me.NombreImagen1 IsNot Nothing Then
                cargarImagen(Me.NombreImagen1)
            End If
            ImagenFrontal = False

        End If

    End Sub
End Class

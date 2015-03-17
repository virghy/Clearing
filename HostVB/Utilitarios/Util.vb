Imports System.IO
Imports Microsoft.Data.Extensions
Imports System.Text

Public Class Util
    Public Shared Function Image2Bytes(ByVal img As Image) As Byte()
        Dim sTemp As String = Path.GetTempFileName()
        Dim fs As New FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite)
        img.Save(fs, System.Drawing.Imaging.ImageFormat.Png)
        fs.Position = 0
        '
        Dim imgLength As Integer = CInt(fs.Length)
        Dim bytes(0 To imgLength - 1) As Byte
        fs.Read(bytes, 0, imgLength)
        fs.Close()
        Return bytes
    End Function

    Public Shared Function ConfigCarpetaImagen() As String
        Dim FilePath As String
        FilePath = My.Settings.CarpetaImagen
        If Not FilePath.StartsWith("\\") Then
            If FilePath.Substring(1, 1) <> ":" Then
                FilePath = Path.Combine(My.Application.Info.DirectoryPath, FilePath)
            End If

        End If
        ' MsgBox(FilePath)
        Dim di As DirectoryInfo = New DirectoryInfo(FilePath)
        Try
            ' Determine whether the directory exists.
            If di.Exists Then
                ' Indicate that it already exists.
                Return FilePath
            End If

            ' Try to create the directory.
            di.Create()
            'Console.WriteLine("The directory was created successfully.")

            '' Delete the directory.
            'di.Delete()
            'Console.WriteLine("The directory was deleted successfully.")

        Catch e As Exception
            MsgBox(String.Format("No se pudo crear o acceder a la carpeta: {0}", FilePath), MsgBoxStyle.Exclamation)
            Return False
        End Try

        Return FilePath
    End Function

    Public Shared Function NombreProceso(ByVal oper As Operacion) As String
        Dim Titulo As String = ""
        Select Case oper
            Case Operacion.Recibido
                Titulo = "Recibidos "
            Case Operacion.Enviado
                Titulo = "Enviados "
            Case Operacion.Rechazado
                Titulo = "Rechazados "
            Case Operacion.Devuelto
                Titulo = "Devueltos "
            Case Operacion.Interna
                Titulo = "Cam. Interna "
        End Select
        Return Titulo
    End Function

    Public Shared Function NombreMes(ByVal NroMes As Integer)
        Dim Mes As String = String.Empty
        Select Case NroMes
            Case 1
                Mes = "Enero"
            Case 2
                Mes = "Febrero"
            Case 3
                Mes = "Marzo"
            Case 4
                Mes = "Abril"
            Case 5
                Mes = "Mayo"
            Case 6
                Mes = "Junio"
            Case 7
                Mes = "Julio"
            Case 8
                Mes = "Agosto"
            Case 9
                Mes = "Setiembre"
            Case 10
                Mes = "Octubre"
            Case 11
                Mes = "Noviembre"
            Case 12
                Mes = "Diciembre"
        End Select
        Return Mes
    End Function
    Public Shared Function Bytes2Image(ByVal bytes() As Byte) As Image
        If bytes Is Nothing Then Return Nothing
        '
        Dim ms As New MemoryStream(bytes)
        Dim bm As Bitmap = Nothing
        Try
            bm = New Bitmap(ms)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        Return bm
    End Function

    Public Shared Function NEWID(ByVal dm As Objects.ObjectContext, ByVal Nombre As String) As Integer
        Dim valor As Integer = -1
        Try

            Dim cmd = dm.CreateStoreCommand("NewID", CommandType.StoredProcedure, New SqlClient.SqlParameter("Tabla", Nombre), New SqlClient.SqlParameter("IdValor", SqlDbType.Int))

            'Indicamos la direccion del parametro de salida
            cmd.Parameters("IdValor").Direction = ParameterDirection.Output

            'Ejecutamos el comando dentro de la conexion
            'Esto abre y cierra automaticamente la conexion
            Using dm.Connection.CreateConnectionScope
                cmd.ExecuteNonQuery()

            End Using


            'recuperamos el valor del parametro de salida
            valor = cmd.Parameters("IdValor").Value
            cmd.Dispose()
        Catch ex As SqlClient.SqlException
            If ex.Number = 3960 Then
                valor = NEWID(dm, Nombre)
            End If
        Catch ex As Exception

        End Try
        Return valor
    End Function

    Public Shared Function EnumErrors(ByVal ex As Exception) As String
        Dim msg As New System.Text.StringBuilder
        msg.AppendLine(ex.GetType.Name)
        Do While ex IsNot Nothing

            msg.AppendLine(ex.ToString)
            ex = ex.InnerException
        Loop
        Return msg.ToString
    End Function

    Public Shared Function Letras(ByVal numero As String) As String
        '********Declara variables de tipo cadena************
        Dim palabras As String = String.Empty
        Dim entero As String = String.Empty
        Dim dec As String = String.Empty
        Dim flag As String = String.Empty

        '********Declara variables de tipo entero***********
        Dim num, x, y As Integer

        flag = "N"

        '**********Número Negativo***********
        If Mid(numero, 1, 1) = "-" Then
            numero = Mid(numero, 2, numero.ToString.Length - 1).ToString
            palabras = "menos "
        End If

        '**********Si tiene ceros a la izquierda*************
        For x = 1 To numero.ToString.Length
            If Mid(numero, 1, 1) = "0" Then
                numero = Trim(Mid(numero, 2, numero.ToString.Length).ToString)
                If Trim(numero.ToString.Length) = 0 Then palabras = ""
            Else
                Exit For
            End If
        Next

        '*********Dividir parte entera y decimal************
        For y = 1 To Len(numero)
            If Mid(numero, y, 1) = "," Then
                flag = "S"
            Else
                If flag = "N" Then
                    entero = entero + Mid(numero, y, 1)
                Else
                    dec = dec + Mid(numero, y, 1)
                End If
            End If
        Next y

        If Len(dec) = 1 Then dec = dec & "0"

        '**********proceso de conversión***********
        flag = "N"

        If Val(numero) <= 999999999 Then
            For y = Len(entero) To 1 Step -1
                num = Len(entero) - (y - 1)
                Select Case y
                    Case 3, 6, 9
                        '**********Asigna las palabras para las centenas***********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" And Mid(entero, num + 2, 1) = "0" Then
                                    palabras = palabras & "cien "
                                Else
                                    palabras = palabras & "ciento "
                                End If
                            Case "2"
                                palabras = palabras & "doscientos "
                            Case "3"
                                palabras = palabras & "trescientos "
                            Case "4"
                                palabras = palabras & "cuatrocientos "
                            Case "5"
                                palabras = palabras & "quinientos "
                            Case "6"
                                palabras = palabras & "seiscientos "
                            Case "7"
                                palabras = palabras & "setecientos "
                            Case "8"
                                palabras = palabras & "ochocientos "
                            Case "9"
                                palabras = palabras & "novecientos "
                        End Select
                    Case 2, 5, 8
                        '*********Asigna las palabras para las decenas************
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    flag = "S"
                                    palabras = palabras & "diez "
                                End If
                                If Mid(entero, num + 1, 1) = "1" Then
                                    flag = "S"
                                    palabras = palabras & "once "
                                End If
                                If Mid(entero, num + 1, 1) = "2" Then
                                    flag = "S"
                                    palabras = palabras & "doce "
                                End If
                                If Mid(entero, num + 1, 1) = "3" Then
                                    flag = "S"
                                    palabras = palabras & "trece "
                                End If
                                If Mid(entero, num + 1, 1) = "4" Then
                                    flag = "S"
                                    palabras = palabras & "catorce "
                                End If
                                If Mid(entero, num + 1, 1) = "5" Then
                                    flag = "S"
                                    palabras = palabras & "quince "
                                End If
                                If Mid(entero, num + 1, 1) > "5" Then
                                    flag = "N"
                                    palabras = palabras & "dieci"
                                End If
                            Case "2"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "veinte "
                                    flag = "S"
                                Else
                                    palabras = palabras & "veinti"
                                    flag = "N"
                                End If
                            Case "3"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "treinta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "treinta y "
                                    flag = "N"
                                End If
                            Case "4"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "cuarenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "cuarenta y "
                                    flag = "N"
                                End If
                            Case "5"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "cincuenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "cincuenta y "
                                    flag = "N"
                                End If
                            Case "6"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "sesenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "sesenta y "
                                    flag = "N"
                                End If
                            Case "7"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "setenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "setenta y "
                                    flag = "N"
                                End If
                            Case "8"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "ochenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "ochenta y "
                                    flag = "N"
                                End If
                            Case "9"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "noventa "
                                    flag = "S"
                                Else
                                    palabras = palabras & "noventa y "
                                    flag = "N"
                                End If
                        End Select
                    Case 1, 4, 7
                        '*********Asigna las palabras para las unidades*********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If flag = "N" Then
                                    If y = 1 Then
                                        palabras = palabras & "uno "
                                    Else
                                        palabras = palabras & "un "
                                    End If
                                End If
                            Case "2"
                                If flag = "N" Then palabras = palabras & "dos "
                            Case "3"
                                If flag = "N" Then palabras = palabras & "tres "
                            Case "4"
                                If flag = "N" Then palabras = palabras & "cuatro "
                            Case "5"
                                If flag = "N" Then palabras = palabras & "cinco "
                            Case "6"
                                If flag = "N" Then palabras = palabras & "seis "
                            Case "7"
                                If flag = "N" Then palabras = palabras & "siete "
                            Case "8"
                                If flag = "N" Then palabras = palabras & "ocho "
                            Case "9"
                                If flag = "N" Then palabras = palabras & "nueve "
                        End Select
                End Select

                '***********Asigna la palabra mil***************
                If y = 4 Then
                    If Mid(entero, 6, 1) <> "0" Or Mid(entero, 5, 1) <> "0" Or Mid(entero, 4, 1) <> "0" Or _
                    (Mid(entero, 6, 1) = "0" And Mid(entero, 5, 1) = "0" And Mid(entero, 4, 1) = "0" And _
                    Len(entero) <= 6) Then palabras = palabras & "mil "
                End If

                '**********Asigna la palabra millón*************
                If y = 7 Then
                    If Len(entero) = 7 And Mid(entero, 1, 1) = "1" Then
                        palabras = palabras & "millón "
                    Else
                        palabras = palabras & "millones "
                    End If
                End If
            Next y

            '**********Une la parte entera y la parte decimal*************
            If dec <> "" Then
                Letras = palabras & "con " & dec
            Else
                Letras = palabras
            End If
        Else
            Letras = ""
        End If
    End Function


    Public Shared Function DiaProceso(ByVal Fecha As Date, ByVal Dias As Int32) As Date
        Dim nuevaFecha As Date = Fecha.AddDays(-1)
        Dim dm As New DataAccess.Entities
        Dim CuentaDias As Integer = 1

        'Verificamos si es fin de semana (Sabado, Domingo)
        If nuevaFecha.DayOfWeek = DayOfWeek.Saturday Or nuevaFecha.DayOfWeek = DayOfWeek.Sunday Then
            'Si es Feriado o Fin de semana, buscamos el dia anterior
            'haciendo recursividad
            nuevaFecha = DiaProceso(nuevaFecha, 1)
        End If

        'Buscamos si es feriado
        Dim EsFeriado = (Aggregate s In dm.Feriados _
Into Any(s.Dia = nuevaFecha.Day And s.Mes = nuevaFecha.Month And (s.MultiAnual = True Or s.Año = nuevaFecha.Year)))

        If EsFeriado Then
            'Si es Feriado o Fin de semana, buscamos el dia anterior
            'haciendo recursividad
            nuevaFecha = DiaProceso(nuevaFecha, 1)
        End If


        'Si hay que ir mas de 1 dia hacia atras
        While CuentaDias < Dias
            CuentaDias += 1
            nuevaFecha = DiaProceso(nuevaFecha, 1)
        End While


        Return nuevaFecha


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

    Public Shared Sub Exportar(ByVal grv As DataGridView)
        Try
            Dim strStreamW As Stream
            Dim strStreamWriter As StreamWriter
            Dim Filas = grv.Rows.Count
            Dim Columnas = grv.Columns.Count
            Dim Archivo As String = Application.StartupPath & "\" & grv.Name & ".csv"
            Dim Linea = ""
            Dim f, c

            File.Delete(Archivo)
            strStreamW = File.OpenWrite(Archivo)

            strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.UTF8)

            'CABECERA
            For c = 0 To Columnas - 1
                Linea = Linea & """" & grv.Columns(c).HeaderText & """;"

            Next

            Linea = Mid(Linea, 1, Linea.ToString.Length - 1)
            strStreamWriter.WriteLine(Linea)
            Linea = Nothing

            'FILAS
            For f = 0 To Filas - 1
                For c = 0 To Columnas - 1
                    Linea = Linea & """" & grv.Item(c, f).Value & """;"
                    'MsgBox(Grid.Item(c, f).Value)
                Next
                Linea = Mid(Linea, 1, Linea.ToString.Length - 1)
                strStreamWriter.WriteLine(Linea)
                Linea = Nothing
            Next
            strStreamWriter.Close()


            Process.Start(Archivo) 'Ejecuta el archivo creado
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical, Ex.Source)
        End Try

    End Sub
  

End Class


Public Enum Operacion
    Recibido = 3
    Enviado = 2
    Devuelto = 1
    Rechazado = 4
    Interna = 5

End Enum


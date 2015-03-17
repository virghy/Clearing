Imports System.IO
Imports Microsoft.Data.Extensions
Imports DataAccess

Public Class Cenv

    Public Shared Sub ArchivoCenv(ByVal dm As Objects.ObjectContext, ByVal vfecha As Date, ByVal vbanco As String)
        Dim cDetalle As New System.Text.StringBuilder
        Dim FileName As String = IO.Path.Combine(My.Settings.Carpeta, "CENV10" + vbanco + ".TXT")

        Try

            Dim cmd = dm.CreateStoreCommand("SP_DetalleCenv", CommandType.StoredProcedure, New SqlClient.SqlParameter("vfecha", vfecha), _
                                            New SqlClient.SqlParameter("vcodbanco", vbanco), _
                                            New SqlClient.SqlParameter("Cod_Moneda", My.Application.Moneda.cod_moneda))
            'Ejecutamos el comando dentro de la conexion
            'Esto abre y cierra automaticamente la conexion
            Using dm.Connection.CreateConnectionScope
                Dim dr = cmd.ExecuteReader()

                While dr.Read
                    If Not dr.IsDBNull(0) Then
                        cDetalle.AppendLine(dr.GetString(0))
                    End If

                End While
                dr.Close()


            End Using


            Dim txt As StreamWriter = New StreamWriter(FileName)

            txt.Write(cDetalle.ToString)

            'Eliminamos el caracter especial
            'a pedido de Laura M. 19/02/2010

            'If My.Application.Banco.cod_banco <> "06" Then
            '    txt.Write(Chr(26))
            'End If

            'txt.Write(cadena)
            txt.Close()
            Dim crc As New Security.Cryptography.CRC32
            MsgBox(String.Format("Archivo CENV Generado Exitosamente. Codigo CRC {0}", crc.FileCRC(FileName)))

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Public Shared Sub ArchivoENVASSDBF(ByVal dm As Objects.ObjectContext, ByVal vfecha As Date, ByVal vbanco As String)
        'Dim cDetalle As New System.Text.StringBuilder
        Dim cl_banco As Decimal, cl_doc As Decimal, cl_cta As String, _
        cl_ser As Decimal, cl_bcore As Decimal, cl_cam As Decimal, _
        cl_monto As Decimal, cl_suc As Decimal, cl_lote As Decimal, _
        cl_caj As Decimal, cl_ope As Decimal, cl_maq As Decimal, _
        cl_corr As Decimal, cl_bols As Decimal, cl_obs As String


        Try

            Dim cmd = dm.CreateStoreCommand("SP_ArchivoEnvas", CommandType.StoredProcedure, New SqlClient.SqlParameter("vfecha", vfecha), _
                                            New SqlClient.SqlParameter("vbanco", vbanco))
            'Ejecutamos el comando dentro de la conexion
            'Esto abre y cierra automaticamente la conexion
            Dim ta As New dsExportTableAdapters.EnvassTableAdapter



            Using dm.Connection.CreateConnectionScope
                Dim dr = cmd.ExecuteReader()

                ta.DeleteQuery()
                While dr.Read
                    'ta.InsertQuery(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), _
                    '               dr(7), dr(8), dr(9), dr(10), dr(11), dr(12), dr(13), dr(14))

                    'Validar datos
                    If dr.IsDBNull(0) Then
                        cl_banco = 0
                    Else
                        cl_banco = dr(0)
                    End If

                    If dr.IsDBNull(1) Then
                        cl_doc = 0
                    Else
                        cl_doc = dr(1)
                    End If

                    If dr.IsDBNull(2) Then
                        cl_cta = ""
                    Else
                        cl_cta = dr(2)
                    End If

                    If dr.IsDBNull(3) Then
                        cl_ser = 0
                    Else
                        cl_ser = dr(3)
                    End If

                    If dr.IsDBNull(4) Then
                        cl_bcore = 0
                    Else
                        cl_bcore = dr(4)
                    End If

                    If dr.IsDBNull(5) Then
                        cl_cam = 0
                    Else
                        cl_cam = dr(5)
                    End If

                    If dr.IsDBNull(6) Then
                        cl_monto = 0
                    Else
                        cl_monto = dr(6)
                    End If

                    If dr.IsDBNull(7) Then
                        cl_suc = 0
                    Else
                        cl_suc = dr(7)
                    End If

                    If dr.IsDBNull(8) Then
                        cl_lote = 0
                    Else
                        cl_lote = dr(8)
                    End If

                    If dr.IsDBNull(9) Then
                        cl_caj = 0
                    Else
                        cl_caj = dr(9)
                    End If

                    If dr.IsDBNull(10) Then
                        cl_ope = 0
                    Else
                        cl_ope = dr(10)
                    End If

                    If dr.IsDBNull(11) Then
                        cl_maq = 0
                    Else
                        cl_maq = dr(11)
                    End If

                    If dr.IsDBNull(12) Then
                        cl_corr = 0
                    Else
                        cl_corr = dr(12)
                    End If

                    If dr.IsDBNull(13) Then
                        cl_bols = 0
                    Else
                        cl_bols = dr(13)
                    End If

                    If dr.IsDBNull(14) Then
                        cl_obs = ""
                    Else
                        cl_obs = dr(14)
                    End If

                    ' ta.InsertQuery1(cl_cta)
                    ta.InsertQuery(cl_banco, cl_doc, cl_cta, cl_ser, cl_bcore, cl_cam, cl_monto, cl_suc, cl_lote, cl_caj, cl_ope, cl_maq, _
        cl_corr, cl_bols, cl_obs)

                End While
                dr.Close()
                MsgBox("Archivo ENVASS Generado Exitosamente")

            End Using

            '            Dim txt As StreamWriter = New StreamWriter("cenv1017.txt")
            '           txt.WriteLine(cDetalle.ToString)
            '          txt.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Public Shared Sub ArchivoMOVIDIDADBF(ByVal dm As Objects.ObjectContext, ByVal vfecha As Date, ByVal vbanco As String)
        'Dim cDetalle As New System.Text.StringBuilder
        Dim cl_cod_banco_receptor As Decimal, cl_cod_banco_emisor As Decimal, _
        cl_chenro As String, cl_monto As Decimal, cl_observ As String = " ", _
        cl_fecha_lectura As Date, cl_canche As Decimal

        Try

            Dim cmd = dm.CreateStoreCommand("SP_Movidia", CommandType.StoredProcedure, New SqlClient.SqlParameter("vfecha", vfecha), _
                                            New SqlClient.SqlParameter("vbanco", vbanco))
            'Ejecutamos el comando dentro de la conexion
            'Esto abre y cierra automaticamente la conexion
            Dim ta As New dsExportTableAdapters.movidiaTableAdapter


            Using dm.Connection.CreateConnectionScope
                Dim dr = cmd.ExecuteReader()

                ta.DeleteQuery()
                While dr.Read
                    'ta.InsertQuery(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), _
                    '               dr(7), dr(8), dr(9), dr(10), dr(11), dr(12), dr(13), dr(14))


                 
                    'Validar datos que pueden tener valores nulos.
                    If dr.IsDBNull(0) Then
                        cl_cod_banco_receptor = 0
                    Else
                        cl_cod_banco_receptor = dr(0)
                    End If

                    If dr.IsDBNull(1) Then
                        cl_cod_banco_emisor = 0
                    Else
                        cl_cod_banco_emisor = dr(1)
                    End If

                    If dr.IsDBNull(2) Then
                        cl_chenro = " "
                    Else
                        cl_chenro = dr(2)
                    End If

                    If dr.IsDBNull(3) Then
                        cl_monto = 0
                    Else
                        cl_monto = dr(3)
                    End If

                    cl_observ = ""

                    cl_fecha_lectura = dr(5)

                    If dr.IsDBNull(6) Then
                        cl_canche = 0
                    Else
                        cl_canche = dr(6)
                    End If


                    ' ta.InsertQuery1(cl_cta)
                    ta.InsertQuery(cl_cod_banco_receptor, cl_cod_banco_emisor, _
                                   cl_chenro, cl_monto, cl_observ, cl_fecha_lectura, _
                                   cl_canche)


                End While
                MsgBox("Archivo MOVIDIA Generado Exitosamente")
                dr.Close()
            End Using

            '            Dim txt As StreamWriter = New StreamWriter("cenv1017.txt")
            '           txt.WriteLine(cDetalle.ToString)
            '          txt.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Public Shared Sub Exportar(ByVal Fecha As Date, ByVal IdFormato As Integer, ByVal IdPaquete As Integer)
        Dim dm As New DataAccess.Entities
        Dim cDetalle As New System.Text.StringBuilder

        Try

            Dim asciiList As List(Of DataAccess.Ascii) = (From o In dm.Ascii Where o.idcabecera = IdFormato And o.cod_banco = My.Application.Banco.cod_banco Select o).ToList

            If asciiList.Count = 0 Then
                MsgBox(String.Format("No se encuentra el formato {0}", IdFormato))
                Return
            End If

            Dim ascii As Ascii = asciiList(0)
            asciiList(0).Ascii_det.Load()
            'Dim p(0) As System.Data.Objects.ObjectParameter
            'p(0) = New System.Data.Objects.ObjectParameter("Fecha", GetType(Date))
            'p(0).Value = Date.Today
            Dim cmd = dm.CreateStoreCommand(ascii.sql, New SqlClient.SqlParameter("Cod_Banco", My.Application.Banco.cod_banco), New SqlClient.SqlParameter("Fecha", Fecha), New SqlClient.SqlParameter("Fecha1", Util.DiaProceso(Fecha, 1)), New SqlClient.SqlParameter("Fecha2", Util.DiaProceso(Fecha, 2)), New SqlClient.SqlParameter("Cod_Moneda", My.Application.Moneda.cod_moneda), New SqlClient.SqlParameter("Paquete", IdPaquete))
            Dim Ascii_DetList As List(Of Ascii_det) = (From n In ascii.Ascii_det Order By n.tipo, n.orden).ToList

            Dim cadena As String = ""
            Dim sb As New System.Text.StringBuilder
            Dim det As Ascii_det
            Dim CadenaCabecera As String = ""
            Dim CadenaFin As String = ""
            Dim ArchivoDestino As String = ""
            Using dm.Connection.CreateConnectionScope
                If ascii.registro_inicio IsNot Nothing AndAlso ascii.registro_inicio.Length > 0 Then
                    CadenaCabecera = dm.CreateStoreCommand(ascii.registro_inicio, New SqlClient.SqlParameter("Fecha", Fecha), New SqlClient.SqlParameter("Cod_Moneda", My.Application.Moneda.cod_moneda)).ExecuteScalar()
                End If

                If ascii.registro_fin IsNot Nothing AndAlso ascii.registro_fin.Length > 0 Then
                    CadenaFin = dm.CreateStoreCommand(ascii.registro_fin).ExecuteScalar()
                End If

                ArchivoDestino = ascii.ArchivoDestino
                If ascii.ArchivoDestino Is Nothing OrElse ascii.ArchivoDestino.Length = 0 Then
                    ArchivoDestino = dm.CreateStoreCommand(ascii.ArchivoDestino1, New SqlClient.SqlParameter("Fecha", Fecha), New SqlClient.SqlParameter("Cod_Moneda", My.Application.Moneda.cod_moneda), New SqlClient.SqlParameter("Paquete", IdPaquete)).ExecuteScalar()
                End If


            End Using

            'Solo insertamos la cabecera si contiene datos
            If CadenaCabecera.Length > 0 Then
                sb.AppendLine(CadenaCabecera)
            End If

            Using dm.Connection.CreateConnectionScope
                Dim dr = cmd.ExecuteReader()
                Dim Resultado As String
                While dr.Read

                    For Each det In Ascii_DetList
                        If det.tipo = dr("Tipo") Then
                            If det.valor.StartsWith("'") Then
                                If det.formato = "Z" Then
                                    cadena += ""
                                    sb.Insert(sb.Length, det.valor.Substring(1, det.valor.Length - 2), det.longitud)
                                Else

                                    sb.AppendFormat("{0" + det.formato + "}", det.valor.Substring(1, det.valor.Length - 2))
                                End If
                                '                                cadena += String.Format("{0:" + det.formato + "}", det.valor.Substring(1, det.valor.Length - 2))
                            Else
                                '                                cadena += String.Format("{0:" + det.formato + "}", dr(det.valor))
                                Resultado = String.Format("{0" + det.formato + "}", dr(det.valor))
                                If Resultado.Length > det.longitud Then
                                    MsgBox(String.Format("El valor {0} del campo {1} supera la longitud {2} establecida.", Resultado, det.valor, det.longitud))
                                    Return
                                Else
                                    sb.AppendFormat("{0" + det.formato + "}", dr(det.valor))
                                End If

                            End If

                        End If

                    Next
                    sb.AppendLine()
                End While
                dr.Close()
            End Using

            '   Dim txt As StreamWriter = New StreamWriter("ASCII.DAT")

            Dim txt As StreamWriter = New StreamWriter(IO.Path.Combine(My.Settings.Carpeta, ArchivoDestino))


            'Solo insertamos la cabecera si contiene datos
            If CadenaFin.Length > 0 Then
                sb.AppendLine(CadenaFin)
            End If


            txt.Write(sb.ToString)
            'txt.Write(cadena)
            txt.Close()
            MsgBox("Archivo Generado Exitosamente")
        Catch ex As Exception
            MsgBox(Util.EnumErrors(ex), MsgBoxStyle.Critical)
        End Try



    End Sub
    Public Shared Sub Exportar(ByVal Fecha As Date, ByVal IdFormato As Integer, ByVal IdPaquete As Integer, ByVal Tipo As String)
        Dim dm As New DataAccess.Entities
        Dim cDetalle As New System.Text.StringBuilder

        Try

            Dim asciiList As List(Of DataAccess.Ascii) = (From o In dm.Ascii Where o.idcabecera = IdFormato And o.cod_banco = My.Application.Banco.cod_banco Select o).ToList
            If asciiList.Count = 0 Then
                MsgBox(String.Format("No se encuentra el formato {0}", IdFormato))
                Return
            End If
            Dim ascii As Ascii = asciiList(0)
            asciiList(0).Ascii_det.Load()
            'Dim p(0) As System.Data.Objects.ObjectParameter
            'p(0) = New System.Data.Objects.ObjectParameter("Fecha", GetType(Date))
            'p(0).Value = Date.Today
            Dim cmd = dm.CreateStoreCommand(ascii.sql, New SqlClient.SqlParameter("Cod_Banco", My.Application.Banco.cod_banco), New SqlClient.SqlParameter("Fecha", Fecha), New SqlClient.SqlParameter("Cod_Moneda", My.Application.Moneda.cod_moneda))
            ' Dim Ascii_DetList As List(Of Ascii_det) = (From n In ascii.Ascii_det Order By n.tipo, n.orden).ToList

            Dim cadena As String = ""
            Dim sb As New System.Text.StringBuilder
            ' Dim det As Ascii_det
            'Dim CadenaCabecera As String = ""
            '  Dim CadenaFin As String = ""
            Dim ArchivoDestino As String = ""


            'Using dm.Connection.CreateConnectionScope
            '    If ascii.registro_inicio.Length > 0 Then
            '        CadenaCabecera = dm.CreateStoreCommand(ascii.registro_inicio, New SqlClient.SqlParameter("Fecha", Fecha), New SqlClient.SqlParameter("Cod_Moneda", My.Application.Moneda.cod_moneda)).ExecuteScalar()
            '    End If

            '    If ascii.registro_fin.Length > 0 Then
            '        CadenaFin = dm.CreateStoreCommand(ascii.registro_fin).ExecuteScalar()
            '    End If
            'End Using

            'sb.AppendLine(CadenaCabecera)
            Dim oArray As New List(Of Object)
            Dim nCampos As Integer
            Using dm.Connection.CreateConnectionScope
                Dim dr = cmd.ExecuteReader()

                nCampos = dr.FieldCount


                While dr.Read
                    Dim fila(nCampos) As Object
                    For i = 0 To nCampos - 1
                        fila(i) = dr(i)
                    Next
                    oArray.Add(fila)


                    'For Each det In Ascii_DetList
                    '    If det.tipo = dr("Tipo") Then
                    '        If det.valor.StartsWith("'") Then
                    '            If det.formato = "Z" Then
                    '                cadena += ""
                    '                sb.Insert(sb.Length, det.valor.Substring(1, det.valor.Length - 2), det.longitud)
                    '            Else
                    '                sb.AppendFormat("{0" + det.formato + "}", det.valor.Substring(1, det.valor.Length - 2))
                    '            End If
                    '            '                                cadena += String.Format("{0:" + det.formato + "}", det.valor.Substring(1, det.valor.Length - 2))
                    '        Else
                    '            '                                cadena += String.Format("{0:" + det.formato + "}", dr(det.valor))
                    '            sb.AppendFormat("{0" + det.formato + "}", dr(det.valor))
                    '        End If

                    '    End If

                    'Next
                    'sb.AppendLine()
                End While
                dr.Close()





            End Using

            Dim lista(oArray.Count - 1, nCampos - 1) As Object
            For i = 0 To oArray.Count - 1
                For x = 0 To nCampos - 1
                    lista(i, x) = oArray(i)(x)
                Next
            Next


            Dim export As New clearing.Export

            ArchivoDestino = ascii.ArchivoDestino
            If ascii.ArchivoDestino Is Nothing OrElse ascii.ArchivoDestino.Length = 0 Then
                Using dm.Connection.CreateConnectionScope
                    ArchivoDestino = dm.CreateStoreCommand(ascii.ArchivoDestino1, New SqlClient.SqlParameter("Fecha", Fecha), New SqlClient.SqlParameter("Cod_Moneda", My.Application.Moneda.cod_moneda), New SqlClient.SqlParameter("Paquete", IdPaquete)).ExecuteScalar()
                End Using
            End If

            'If ascii.ArchivoDestino Is Nothing Then
            '    ArchivoDestino = dm.CreateStoreCommand(ascii.ArchivoDestino1, New SqlClient.SqlParameter("Fecha", Fecha), New SqlClient.SqlParameter("Cod_Moneda", My.Application.Moneda.cod_moneda), New SqlClient.SqlParameter("Paquete", IdPaquete)).ExecuteScalar()
            'End If


            export.FORMATO = ascii.EstructuraDestino
            Dim result As Integer = export.Export(lista, IO.Path.Combine(My.Settings.Carpeta, ArchivoDestino), "FOX2X")
            If result = 0 Then
                MsgBox("Archivo Generado Exitosamente")
            Else
                MsgBox("El proceso finalizó con el error " + export.MENSAJE, MsgBoxStyle.Exclamation)
            End If

            'Dim txt As StreamWriter = New StreamWriter("EXPORTAR.TXT")
            'sb.AppendLine(CadenaFin)

            'txt.Write(sb.ToString)
            ''txt.Write(cadena)
            'txt.Close()

        Catch ex As Exception
            MsgBox(Util.EnumErrors(ex), MsgBoxStyle.Critical)
        End Try



    End Sub


    Public Shared Sub ArchivoASCII(ByVal dm As Objects.ObjectContext, ByVal vfecha As Date, ByVal vcodproceso As Integer, ByVal codBanco As String)
        Dim cAscii As New System.Text.StringBuilder

        Try

            Dim cmd = dm.CreateStoreCommand("SP_ArchivoASCCI", CommandType.StoredProcedure, New SqlClient.SqlParameter("vfecha", vfecha), _
                                            New SqlClient.SqlParameter("vcodproceso", vcodproceso), New SqlClient.SqlParameter("vcodBanco", codBanco))
            'Ejecutamos el comando dentro de la conexion
            'Esto abre y cierra automaticamente la conexion
            Using dm.Connection.CreateConnectionScope
                Dim dr = cmd.ExecuteReader()

                While dr.Read
                    If Not dr.IsDBNull(0) Then
                        cAscii.AppendLine(dr.GetString(0))
                    End If

                End While
                dr.Close()


            End Using

            Dim txt As StreamWriter = New StreamWriter(IO.Path.Combine(My.Settings.Carpeta, "ASCII.DAT"))
            txt.WriteLine(cAscii.ToString)
            txt.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    'Public Shared Sub ArchivoASCII(ByVal dm As Objects.ObjectContext, ByVal vfecha As Date, ByVal vcodproceso As Integer)
    '    Dim cAscii As New System.Text.StringBuilder

    '    Try

    '        Dim cmd = dm.CreateStoreCommand("SP_ArchivoASCCI", CommandType.StoredProcedure, New SqlClient.SqlParameter("vfecha", vfecha), _
    '                                        New SqlClient.SqlParameter("vcodproceso", vcodproceso))
    '        'Ejecutamos el comando dentro de la conexion
    '        'Esto abre y cierra automaticamente la conexion
    '        Using dm.Connection.CreateConnectionScope
    '            Dim dr = cmd.ExecuteReader()

    '            While dr.Read
    '                If Not dr.IsDBNull(0) Then
    '                    cAscii.AppendLine(dr.GetString(0))
    '                End If

    '            End While
    '            dr.Close()


    '        End Using

    '        Dim txt As StreamWriter = New StreamWriter("ASCII.DAT")
    '        txt.WriteLine(cAscii.ToString)
    '        txt.Close()

    '    Catch ex As Exception
    '        MsgBox(ex.Message)

    '    End Try

    'End Sub
    Public Shared Sub ArchivoMAYORES(ByVal dm As Objects.ObjectContext, ByVal vfecha As Date, ByVal vmonto As Double, _
                                     ByVal vcodbanco As Integer)
        Dim cMayores As New System.Text.StringBuilder

        Try

            Dim cmd = dm.CreateStoreCommand("SP_ArchivoMayores", CommandType.StoredProcedure, New SqlClient.SqlParameter("vfecha", vfecha), New SqlClient.SqlParameter("vmonto", vmonto), _
                                            New SqlClient.SqlParameter("vcodbanco", vcodbanco))
            'Ejecutamos el comando dentro de la conexion
            'Esto abre y cierra automaticamente la conexion
            Using dm.Connection.CreateConnectionScope
                Dim dr = cmd.ExecuteReader()

                While dr.Read
                    If Not dr.IsDBNull(0) Then
                        cMayores.AppendLine(dr.GetString(0))
                    End If

                End While
                dr.Close()


            End Using

            Dim txt As StreamWriter = New StreamWriter(My.Settings.Carpeta + "MAYOR.DAT")
            txt.WriteLine(cMayores.ToString)
            txt.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

End Class

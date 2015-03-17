Imports System.IO
Imports System.Text
Imports Ionic.Zip

Public Class Formalistica
    Dim dm As DataAccess.Entities
    Dim PathImages As String
    Dim PathFTP As String
    Const CantidadMin As Integer = 100
    Const CantidadMax As Integer = 800
    Dim Marcado As Boolean
    Dim Worker As ComponentModel.BackgroundWorker

    Sub New(ByVal PathOrigen As String, ByVal PathDestino As String, ByVal Marcar As Boolean, ByVal mWorker As ComponentModel.BackgroundWorker)
        PathImages = PathOrigen
        PathFTP = PathDestino
        Marcado = Marcar
        Worker = mWorker
    End Sub
    Sub New(ByVal PathOrigen As String, ByVal PathDestino As String, ByVal mWorker As ComponentModel.BackgroundWorker)
        PathImages = PathOrigen
        PathFTP = PathDestino
        Worker = mWorker
    End Sub

    Sub ExportarImagen(ByVal Banco As String, ByVal Proceso As String, ByVal Moneda As String, ByVal Fecha As Date)
        'Seleccionar Carpeta de Trabajo
        'Si es cabecera, crear carpeta con el nombre NroBoleta
        'Si es detalle, agregar la imagen en la carpeta
        '
        Dim PathDestino As String = Path.Combine(PathFTP, Fecha.ToString("ddMMyyyy"))
        If Directory.Exists(PathDestino) Then
            If MsgBox("La carpeta destino existe. Desea remplazarlo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Directory.Delete(PathDestino, True)
            Else
                Return
            End If
        End If


        Dim dm As New DataAccess.Entities
        Dim ld = dm.App_GetLecturas(Banco, Fecha, Proceso, Moneda, Nothing, Nothing).ToList()
        Dim tmpFolder As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, Fecha.ToString("ddMMyyyy"))
        Dim di = New DirectoryInfo(tmpFolder)
        Dim Indice As Integer
        Dim fi As FileInfo
        Dim FilePath As String = ""

        If Not di.Exists Then
            di.Create()
        Else
            di.Delete(True)
        End If

        For Each l In ld
            If l.EsCabecera Then
                FilePath = Path.Combine(tmpFolder, l.numero_cheque)
                Dim NewDir As New DirectoryInfo(FilePath)
                If Not NewDir.Exists Then
                    NewDir.Create()
                End If
            End If

            If l.imagen_frontal IsNot Nothing Then
                fi = New FileInfo(Path.Combine(PathImages, l.imagen_frontal))
            Else
                fi = New FileInfo(Path.Combine(PathImages, "_ss.jpg"))
            End If

            If fi.Exists Then
                Indice += 1
                If Worker IsNot Nothing Then
                    Worker.ReportProgress(Decimal.Round(CDec(Indice * 100 / ld.Count)))
                End If
                fi.CopyTo(Path.Combine(FilePath, "F" + Indice.ToString("00000") + ".JPG"), True)

                fi = Nothing

                If l.imagen_reverso IsNot Nothing Then
                    fi = New FileInfo(Path.Combine(PathImages, l.imagen_reverso))
                Else
                    fi = New FileInfo(Path.Combine(PathImages, "_ss.jpg"))
                End If

                If fi.Exists Then
                    fi.CopyTo(Path.Combine(FilePath, "R" + Indice.ToString("00000") + ".JPG"), True)
                End If

            End If
        Next

        Dim destDir As New DirectoryInfo(PathDestino)
        If destDir.Exists Then
            destDir.Delete(True)
        End If
        'di.MoveTo(PathDestino)
        Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(di.FullName, PathDestino)
        di.Delete(True)
    End Sub



    Function Procesar(ByVal Banco As String, ByVal Proceso As String, ByVal Moneda As String, ByVal Fecha As String) As Boolean
        Dim Final As Boolean = False
        Dim FechaLectura As Date
        Dim NombreCarpeta As String
        Dim FilePath As String
        Dim NombreZip As String
        Dim di As DirectoryInfo
        Dim fi As FileInfo
        Dim BancoActual As String = ""
        dm = New DataAccess.Entities
        If IsDate(Fecha) Then
            FechaLectura = CDate(Fecha)
        Else
            FechaLectura = Date.Today
        End If

        ' Dim Lecturas = (From s In dm.App_GetLecturas(Banco, FechaLectura, Proceso, Moneda, Nothing, Nothing)).ToList
        Dim ListaLecturas = TraerLecturas(Banco, Proceso, Moneda, FechaLectura)

        Console.WriteLine(String.Format("{0} Registros recuperados...", ListaLecturas.Count))

        Final = Cerrado(Banco, FechaLectura, Moneda, Proceso)

        'Aqui indicamos el nro minimo a enviar
        Dim Cant As Integer = 0
        For ii = 0 To ListaLecturas.Count - 1
            If ListaLecturas(ii).imagen_frontal IsNot Nothing Then
                fi = New FileInfo(Path.Combine(PathImages, ListaLecturas(ii).imagen_frontal))
            Else
                fi = New FileInfo(Path.Combine(PathImages, "_ss.jpg"))
            End If

            If fi.Exists And ListaLecturas(ii).numero_cheque > 0 And ListaLecturas(ii).cuenta_cheque > 0 And ListaLecturas(ii).monto > 0 And IsNumeric(ListaLecturas(ii).cod_banco_emisor) And IsNumeric(ListaLecturas(ii).cod_banco_receptor) _
                And (Final Or (ListaLecturas(ii).monto < 100000000000 And (ListaLecturas(ii).numero_cheque < 10000000 Or Banco <> "17"))) _
                And (ListaLecturas(ii).cod_banco_receptor = Banco Or Proceso <> 3) Then
                ''VG 19.09.12
                ''Agregamos nuevas validaciones

                Cant += 1

                If BancoActual.Length = 0 Then
                    BancoActual = ListaLecturas(ii).cod_banco_emisor
                End If

                'If Cant >= CantidadMin Then
                '    Exit For
                'End If
            End If
        Next

        If Cant < CantidadMin Then

            'Si no lluego al final y es marcado (Se ejecuta desde el form)
            If Not Final And Marcado = True Then
                Return False
            End If
        End If

        Dim Formalistica As DataAccess.Formalistica = Nothing

        If Marcado Then
            Formalistica = (From s In dm.Formalistica _
                          Where s.IdBanco = Banco And s.IdProceso = Proceso _
                          And s.IdMoneda = Moneda And s.Fecha = FechaLectura).FirstOrDefault
        End If

        If Formalistica Is Nothing Then
            Formalistica = New DataAccess.Formalistica With {.IdBanco = Banco, .IdProceso = Proceso, .IdMoneda = Moneda, .Fecha = FechaLectura, .Cheques = 0, .Lotes = 0, .Importe = 0}
            dm.AddToFormalistica(Formalistica)
        End If

        If Cant > 0 Then
            Formalistica.Lotes += 1

            Dim Detalle As New StringBuilder
            Dim Busqueda As New StringBuilder
            Dim Cabecera As New StringBuilder
            Dim Importe As Double = 0

            NombreCarpeta = String.Concat("R", FechaLectura.ToString("yyMMdd"), Formalistica.Lotes.Value.ToString("00"))

            FilePath = Path.Combine(My.Application.Info.DirectoryPath, NombreCarpeta)
            di = New DirectoryInfo(FilePath)

            If Not di.Exists Then
                di.Create()
            End If
            'BancoActual = ListaLecturas(0).cod_banco_emisor
            'Procesamos el zip
            Dim Contador As Integer = 0
            Dim ContadorBanco As Integer = 0
            ContadorBanco = Cant
            Using zip1 As ZipFile = New ZipFile
                For Each l In ListaLecturas
                    Contador += 1
                    If Worker IsNot Nothing Then
                        Worker.ReportProgress(Decimal.Round(CDec(Contador * 100 / ListaLecturas.Count)))
                    End If

                    If l.imagen_frontal IsNot Nothing Then
                        fi = New FileInfo(Path.Combine(PathImages, l.imagen_frontal))
                    Else
                        fi = New FileInfo(Path.Combine(PathImages, "_ss.jpg"))
                    End If

                    If fi.Exists And l.numero_cheque > 0 And l.cuenta_cheque > 0 And l.monto > 0 And IsNumeric(l.cod_banco_emisor) And IsNumeric(l.cod_banco_receptor) _
                        And (Final Or (l.monto < 100000000000 And (l.numero_cheque < 10000000 Or Banco <> "17"))) _
                                        And (l.cod_banco_receptor = Banco Or Proceso <> 3) Then
                        ''VG 19.09.12
                        ''Agregamos nuevas validaciones
                        ''VG 08/10/212
                        ''Enviamos solo los cheques con 7 digitos para itau

                        Formalistica.Cheques += 1
                        ''   ContadorBanco += 1
                        'Se hace el corte del banco
                        If BancoActual <> l.cod_banco_emisor Then
                            Cabecera.Append("001")
                            Cabecera.AppendFormat("{0:yyMMdd}", FechaLectura)
                            Cabecera.Append("0000")
                            Cabecera.AppendFormat("{0:00000000000000}", Importe)
                            Cabecera.Append(BancoActual)
                            Cabecera.AppendFormat("{0:0000000000}", ContadorBanco)
                            Cabecera.Append("000000000000000")
                            Busqueda.AppendLine(Cabecera.ToString)
                            Busqueda.Append(Detalle.ToString)

                            Cabecera = New StringBuilder
                            Detalle = New StringBuilder

                            ContadorBanco = 0
                            Importe = 0
                            BancoActual = l.cod_banco_emisor
                        End If

                        'Creamos el string del detalle

                        Detalle.Append("001")
                        Detalle.AppendFormat("{0:yyMMdd}", FechaLectura)
                        Detalle.Append("00")
                        Detalle.Append(l.cod_banco_emisor)
                        Detalle.AppendFormat("{0:00000000000000}", l.monto)
                        Detalle.Append(l.cod_banco_receptor)
                        Detalle.AppendFormat("{0:000000000000}", l.cuenta_cheque)
                        Detalle.AppendFormat("{0:00000}", Formalistica.Cheques)
                        Detalle.AppendFormat("{0:00000000}", l.numero_cheque)
                        Detalle.AppendLine()

                        Importe += l.monto
                        l.ENVIADO = True
                        fi.CopyTo(Path.Combine(FilePath, "FSWHITE" + Formalistica.Cheques.Value.ToString("00000") + ".JPG"), True)

                        fi = Nothing

                        If l.imagen_reverso IsNot Nothing Then
                            fi = New FileInfo(Path.Combine(PathImages, l.imagen_reverso))
                        Else
                            fi = New FileInfo(Path.Combine(PathImages, "_ss.jpg"))
                        End If

                        If fi.Exists Then
                            fi.CopyTo(Path.Combine(FilePath, "RSWHITE" + Formalistica.Cheques.Value.ToString("00000") + ".JPG"), True)
                        End If

                    End If


                Next
                Console.WriteLine("Generando archivo...")
                'Se hace el corte del ULTIMO banco
                Cabecera.Append("001")
                Cabecera.AppendFormat("{0:yyMMdd}", FechaLectura)
                Cabecera.Append("0000")
                Cabecera.AppendFormat("{0:00000000000000}", Importe)
                Cabecera.Append(BancoActual)
                '        Cabecera.Append("0000000000000000000000000")
                'Cabecera.AppendFormat("{0:0000000000000000000000000}", ContadorBanco)
                Cabecera.AppendFormat("{0:0000000000}", ContadorBanco)
                Cabecera.Append("000000000000000")
                Busqueda.AppendLine(Cabecera.ToString)
                Busqueda.AppendLine(Detalle.ToString)

                Dim txt As StreamWriter = New StreamWriter(Path.Combine(FilePath, "BUSQUEDA" + Formalistica.Lotes.Value.ToString("00") + ".TXT"))

                txt.Write(Busqueda.ToString)

                txt.Close()

                Console.WriteLine("Empaquetando...")

                zip1.AddDirectory(FilePath, NombreCarpeta)
                NombreZip = String.Concat(FilePath, ".zip")
                fi = New FileInfo(NombreZip)
                If fi.Exists Then
                    fi.Delete()
                End If
                zip1.Save(NombreZip)

                'intentamos borrar la carpeta generada
                'pero si no se borra, no hay problema
                Try
                    di.Delete(True)
                Catch ex As Exception

                End Try


            End Using

            Console.WriteLine("Guardando Cambios...")

            If Marcado Then
                dm.SaveChanges()
            End If

            Console.WriteLine(String.Format("Enviando lote {0}...", Formalistica.Lotes.Value))
            fi = New FileInfo(NombreZip)

            If fi.Exists Then
                Dim fi1 As New FileInfo(Path.Combine(PathFTP, Path.GetFileName(NombreZip)))
                If fi1.Exists Then
                    fi1.Delete()
                End If

                fi.MoveTo(Path.Combine(PathFTP, Path.GetFileName(NombreZip)))

            End If
        End If

        'Generamos el lote 99 para cerrar
        If (ListaLecturas.Count < CantidadMin And Final) Or Not Marcado Then

            '2012-01-01
            'A pedido de Andrea, se indica una carpeta fija

            NombreCarpeta = String.Concat("TRANSCANON/FIN/R", FechaLectura.ToString("yyMMdd"), "99")
            'NombreCarpeta = "TRANSCANON/FIN/"

            FilePath = Path.Combine(My.Application.Info.DirectoryPath, NombreCarpeta)
            di = New DirectoryInfo(FilePath)
            If Not di.Exists Then
                di.Create()
            End If

            Dim txt As StreamWriter = New StreamWriter(Path.Combine(FilePath, "BUSQUEDA99.TXT"))
            txt.Write(String.Concat(FechaLectura.ToString("ddMMyyyy"), Formalistica.Lotes.Value.ToString("000"), Formalistica.Cheques.Value.ToString("00000")))
            txt.Close()
            Using zip1 As New ZipFile
                zip1.AddDirectory(FilePath, "TRANSCANON/FIN/")
                NombreZip = String.Concat(FilePath, ".zip")

                zip1.Save(NombreZip)

                Try
                    di.Delete(True)
                Catch ex As Exception

                End Try


            End Using
            fi = New FileInfo(NombreZip)
            If fi.Exists Then

                Dim fi1 As New FileInfo(Path.Combine(PathFTP, Path.GetFileName(NombreZip)))
                If fi1.Exists Then
                    fi1.Delete()
                End If

                fi.MoveTo(Path.Combine(PathFTP, Path.GetFileName(NombreZip)))
            End If

            Return False

        End If

        Return True
    End Function

    Sub BorrarSiExiste(ByVal Archivo As String)
        Dim fi1 As New FileInfo(Archivo)
        If fi1.Exists Then
            fi1.Delete()
        End If
    End Sub

    Public Enum Operacion
        Recibido = 3
        Enviado = 2
        Devuelto = 1
        Rechazado = 4
        Interna = 5

    End Enum
    Function TraerLecturas(ByVal Banco As String, ByVal Proceso As String, ByVal Moneda As String, ByVal Fecha As Date) As List(Of DataAccess.Lecturas)
        'dm.log = Console.Out
        If Marcado Then
            TraerLecturas = (From s In dm.Lecturas _
                             Join b1 In dm.Bancos On s.cod_banco_emisor Equals b1.cod_banco _
                             Join b2 In dm.Bancos On s.cod_banco_receptor Equals b2.cod_banco _
                             Where s.cod_banco = Banco _
                                And s.cod_proceso = Proceso And s.cod_moneda = Moneda _
                                And s.fecha_lectura = Fecha And s.cod_tipdoc <> "90" _
                                And s.ENVIADO = False Take CantidadMax Order By s.cod_banco_emisor Select s).ToList
        Else
            TraerLecturas = (From s In dm.Lecturas _
                                Join b1 In dm.Bancos On s.cod_banco_emisor Equals b1.cod_banco _
                                Join b2 In dm.Bancos On s.cod_banco_receptor Equals b2.cod_banco _
                                Where s.cod_banco = Banco _
                                And s.cod_proceso = Proceso And s.cod_moneda = Moneda _
                                And s.fecha_lectura = Fecha And s.cod_tipdoc <> "90" _
                                Order By s.cod_banco_emisor Select s).ToList
        End If


    End Function
    Function Cerrado(ByVal IdBanco As String, ByVal Fecha As Date, ByVal Moneda As String, ByVal Proceso As Integer) As Boolean
        Dim dm As New DataAccess.Entities

        Dim ExisteCierre = (Aggregate word In dm.Cierres _
        Into Any(word.Fecha = Fecha And word.IdBanco = IdBanco And word.IdMoneda = Moneda _
        And word.IdProceso = Proceso And word.Cerrado = True))

        Return ExisteCierre

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
End Class

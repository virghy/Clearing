Imports Ionic.Zip
Imports System.IO
Imports System.Text
Imports Microsoft.Practices.EnterpriseLibrary.Logging
Imports Formalistica
Module Module1
    ' 1. Recuparar los registros no enviados
    ' 2. Verificar cantidad
    ' 3. Generar archivo zip. Paralelamente ir generando el txt
    ' 4. Copiar el archivo zip 
    ' 5. Marcar como enviado los registros
    ' 6. Generar el lote 99
    Dim dm As DataAccess.Entities
    Dim PathImages As String
    Dim PathFTP As String
    Const CantidadMin As Integer = 100
    Const CantidadMax As Integer = 800
    Sub Main()
        Using New Tracer("General")

            Try

                MostrarTitulo()

                Dim bancoArgument As String = "/banco:"
                Dim bancoName As String = ""
                Dim procesoArgument As String = "/proceso:"
                Dim procesoName As String = ""
                Dim monedaArgument As String = "/moneda:"
                Dim monedaName As String = ""
                Dim fechaArgument As String = "/fecha:"
                Dim fechaName As String = ""
                'Logger.Write("Iniciando Proceso")

                For Each s As String In My.Application.CommandLineArgs
                    If s.ToLower.StartsWith(bancoArgument) Then
                        bancoName = s.Remove(0, bancoArgument.Length)
                    End If
                    If s.ToLower.StartsWith(procesoArgument) Then
                        procesoName = s.Remove(0, procesoArgument.Length)
                    End If
                    If s.ToLower.StartsWith(monedaArgument) Then
                        monedaName = s.Remove(0, monedaArgument.Length)
                    End If
                    If s.ToLower.StartsWith(fechaArgument) Then
                        fechaName = s.Remove(0, fechaArgument.Length)
                    End If


                Next

                If bancoName.Length = 0 Or procesoName.Length = 0 Or monedaName.Length = 0 Then
                    MostrarError()
                    Return
                End If

                'Configuramos la carpeta de imagenes
                PathImages = My.Settings.CarpetaImagen
                If Not PathImages.StartsWith("\\") Then
                    If PathImages.Substring(1, 1) <> ":" Then
                        PathImages = Path.Combine(My.Application.Info.DirectoryPath, PathImages)
                    End If

                End If
                PathFTP = My.Settings.CarpetaFTP
                If Not PathFTP.StartsWith("\\") Then
                    If PathFTP.Substring(1, 1) <> ":" Then
                        PathFTP = Path.Combine(My.Application.Info.DirectoryPath, PathFTP)
                    End If

                End If

                Console.WriteLine("Iniciando proceso de Banco: " + bancoName)

                Dim fm As Formalistica
                fm = New Formalistica(PathImages, PathFTP, True, Nothing)

                While fm.Procesar(bancoName, procesoName, monedaName, fechaName)

                End While

            Catch ex As Exception

                Console.WriteLine(Formalistica.EnumErrors(ex))
                Logger.Write(Formalistica.EnumErrors(ex), "General", 0, 10, TraceEventType.Error)
            End Try
            'Logger.Write("Finalizando Proceso")
        End Using


    End Sub

    Sub MostrarTitulo()
        Console.WriteLine("Futura Software - (c) 2011")
        Console.WriteLine("Proceso de empaquetado de imagenes de Clearing")
        Console.WriteLine(String.Format("Versión {0}", My.Application.Info.Version.ToString))
        Console.WriteLine()

    End Sub
    Sub MostrarError()
        Console.WriteLine("Parametros requeridos:")
        Console.WriteLine()
        Console.WriteLine("     /banco:CodBanco          Codigo del Banco")
        Console.WriteLine("     /proceso:CodProceso      Codigo del Proceso [1=Devueltos, 2=Enviados, ")
        Console.WriteLine("                              3=Recibidos, 4=Rechazados, 5=Cam. Interna]")
        Console.WriteLine("     /moneda:CodMoneda        Codigo de Moneda")
        Console.WriteLine("     /fecha[:Fecha]           Fecha del proceso. Si se omite se asume")
        Console.WriteLine("                              la fecha actual")
        Console.WriteLine()
        Console.WriteLine("Ejemplo: ")
        Console.WriteLine("Realizar el proceso para el banco 05, proceso 3(Recibidos) y la Moneda PYG")
        Console.WriteLine()
        Console.WriteLine("empaquetar /banco:05 /proceso:3 /moneda:PYG")

    End Sub

    

End Module

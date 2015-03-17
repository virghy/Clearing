Imports DataAccess
Imports System.Configuration
Namespace My

    ' 907.13 Corrige validacion de bancos en cierre.


    ' Los siguientes eventos están disponibles para MyApplication:
    ' 
    ' Inicio: se desencadena cuando se inicia la aplicación, antes de que se cree el formulario de inicio.
    ' Apagado: generado después de cerrar todos los formularios de la aplicación. Este evento no se genera si la aplicación termina de forma anómala.
    ' UnhandledException: generado si la aplicación detecta una excepción no controlada.
    ' StartupNextInstance: se desencadena cuando se inicia una aplicación de instancia única y la aplicación ya está activa. 
    ' NetworkAvailabilityChanged: se desencadena cuando la conexión de red está conectada o desconectada.
    Partial Friend Class MyApplication

        Private _IdProceso As HostVB.Operacion
        Private _Banco As DataAccess.Bancos
        Private _Moneda As DataAccess.Monedas
        Private _Scanner As TipoScanner

        Private _constantes As Constantes

        Public ReadOnly Property Constantes() As Constantes
            Get
                If _constantes Is Nothing Then
                    _constantes = New Constantes
                    Dim dm As New DataAccess.Entities
                    Dim CodBanco As String = My.Application.Banco.cod_banco.PadRight(3)
                    Dim lista = (dm.sys_config.Where(Function(p) p.IdBanco = CodBanco)).ToList
                    _constantes.Comision = (From s In lista Where s.constante = MySettings.MontoComision Select s.valor).FirstOrDefault
                    _constantes.CodigoComision = (From s In lista Where s.constante = MySettings.TransComision Select s.valor).FirstOrDefault
                    _constantes.ComisionIVA = (From s In lista Where s.constante = MySettings.MontoComisionIva Select s.valor).FirstOrDefault
                    _constantes.CodigoComisionIVA = (From s In lista Where s.constante = MySettings.TransComisionIva Select s.valor).FirstOrDefault
                    _constantes.CodigoCHERFII = (From s In lista Where s.constante = MySettings.CodigoCHERFII Select s.valor).FirstOrDefault
                    _constantes.CUENTA_ADM_ITAU = (From s In lista Where s.constante = MySettings.CUENTA_ADM_ITAU Select s.valor).FirstOrDefault
                    _constantes.LONGITUD_CUENTA = (From s In lista Where s.constante = MySettings.LONGITUD_CUENTA Select s.valor).FirstOrDefault

                End If

                Return _constantes
            End Get
        End Property
        Public ReadOnly Property Scanner() As MICR.CanonAPIbase
            Get
                Select Case _Scanner
                    Case My.TipoScanner.CanonCR180
                        Return New MICR.CanonCR180
                    Case My.TipoScanner.CanonCR2555
                        Return New MICR.CANON55
                    Case TipoScanner.CanonCR180II
                        Return New MICR.CanonCR180II
                    Case Else
                        Return Nothing
                End Select
            End Get

        End Property

        Public ReadOnly Property Banco() As DataAccess.Bancos
            Get
                Return _Banco
            End Get
        End Property
        Public Property IdProceso() As HostVB.Operacion
            Get
                Return _IdProceso
            End Get
            Set(ByVal value As HostVB.Operacion)
                _IdProceso = value
            End Set
        End Property

        Public ReadOnly Property Moneda() As DataAccess.Monedas
            Get
                Return _Moneda
            End Get
        End Property

        Public Sub cargarInicial()
            Dim dm As New DataAccess.Entities

            If MySettings.Default.Scanner Is Nothing Then
                _Scanner = My.TipoScanner.CanonCR2555
            Else
                Select Case MySettings.Default.Scanner
                    Case "Canon CR25/55"
                        _Scanner = My.TipoScanner.CanonCR2555
                    Case "Canon CR180"
                        _Scanner = My.TipoScanner.CanonCR180
                    Case "Canon CR180II"
                        _Scanner = My.TipoScanner.CanonCR180II

                End Select
            End If

            _Banco = dm.Bancos.FirstOrDefault(Function(p) p.cod_banco = MySettings.Default.IdEmpresa)
            If _Banco Is Nothing Then
                Throw New Exception("No se encuentra el banco configurado " + MySettings.Default.IdEmpresa)
            End If

            _Moneda = dm.Monedas.FirstOrDefault(Function(p) p.cod_moneda = MySettings.Default.Moneda)
            If _Moneda Is Nothing Then
                Throw New Exception("No se encuentra la moneda configurada " + MySettings.Default.Moneda)
            End If
            'End If


        End Sub

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup

            ''VG
            ''04/08/2010
            'Actualiza la configuracion de la version anterior
            ' Add any initialization after the InitializeComponent() call.
            If My.Settings.CallUpgrade = True Then
                My.Settings.Upgrade()
                My.Settings.CallUpgrade = False
            End If


            System.Threading.Thread.CurrentThread.CurrentCulture = _
            New System.Globalization.CultureInfo("es-PY")

            ' The following line provides localization for the application's user interface. 
            System.Threading.Thread.CurrentThread.CurrentUICulture = _
                New System.Globalization.CultureInfo("es-PY")

            'System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
            'System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
            


            If e.CommandLine.Count > 0 Then
                Dim p As String = e.CommandLine(0)

                'Para encriptar
                If p = "E" Then
                    Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

                    Dim sect As ConnectionStringsSection = config.ConnectionStrings
                    sect.SectionInformation.ProtectSection("DPAPIProtection")
                    config.Save()
                End If

                'Para desencriptar
                If p = "D" Then
                    Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

                    Dim sect As ConnectionStringsSection = config.ConnectionStrings

                    If sect.SectionInformation.IsProtected Then
                        sect.SectionInformation.UnprotectSection()
                        config.Save()
                    End If

                End If
            End If
        End Sub
        Public Shared Function Cerrado(ByVal IdBanco As String, ByVal Fecha As Date, ByVal Moneda As String, ByVal Proceso As Integer) As Boolean
            'Dim dm As New DataAccess.Entities

            'Dim ExisteCierre = (Aggregate word In dm.Cierres _
            'Into Any(word.Fecha = Fecha And word.IdBanco = IdBanco And word.IdMoneda = Moneda _
            'And word.IdProceso = Proceso And word.Cerrado = True))

            'Return ExisteCierre
            Return Cerrado(IdBanco, Fecha, Moneda, Proceso, 1)

        End Function
        Public Shared Function Cerrado(ByVal IdBanco As String, ByVal Fecha As Date, ByVal Moneda As String, ByVal Proceso As Integer, ByVal Paquete As Integer) As Boolean
            Dim dm As New DataAccess.Entities

            Dim ExisteCierre = (Aggregate word In dm.Cierres _
            Into Any(word.Fecha = Fecha And word.IdBanco = IdBanco And word.IdMoneda = Moneda _
            And word.IdProceso = Proceso And word.Cerrado = True _
            And (word.Paquete = Paquete Or Paquete = 0)))

            Return ExisteCierre

        End Function


        Public Shared Sub CerrarProceso(ByVal IdBanco As String, ByVal Fecha As Date, ByVal Moneda As String, ByVal Proceso As Integer, ByVal Paquete As Integer)
            Dim dm As New DataAccess.Entities


            Dim cierre = (From word In dm.Cierres _
                         Where word.Fecha = Fecha And word.IdBanco = IdBanco And word.IdMoneda = Moneda _
            And word.IdProceso = Proceso _
            And word.Paquete = Paquete _
            Select word).FirstOrDefault

            If cierre Is Nothing Then
                cierre = New DataAccess.Cierres
                cierre.IdBanco = IdBanco
                cierre.IdMoneda = Moneda
                cierre.IdProceso = Proceso
                cierre.Fecha = Fecha
                cierre.HoraInicio = Date.Now
                cierre.Paquete = Paquete
                dm.AddToCierres(cierre)
            End If

            cierre.HoraCierre = Date.Now
            cierre.Cerrado = True

            dm.SaveChanges()



        End Sub
        Public Shared Sub AbrirProceso(ByVal IdBanco As String, ByVal Fecha As Date, ByVal Moneda As String, ByVal Proceso As Integer, ByVal Paquete As Integer)
            Dim dm As New DataAccess.Entities

            'Dim ExisteCierre = (Aggregate word In dm.Cierres _
            'Into Any(word.Fecha = Fecha And word.IdBanco = IdBanco And word.IdMoneda = Moneda _
            'And word.IdProceso = Proceso))

            'If Not ExisteCierre Then
            '    Dim cierre As New DataAccess.Cierres
            '    cierre.Cerrado = False
            '    cierre.IdBanco = IdBanco
            '    cierre.IdMoneda = Moneda
            '    cierre.IdProceso = Proceso
            '    cierre.Fecha = Fecha
            '    cierre.HoraInicio = Date.Now
            '    dm.AddToCierres(cierre)
            '    dm.SaveChanges()
            'End If

            Dim cierre = (From word In dm.Cierres _
                                     Where word.Fecha = Fecha And word.IdBanco = IdBanco And word.IdMoneda = Moneda _
                        And word.IdProceso = Proceso And word.Paquete = Paquete _
                        Select word).FirstOrDefault

            If cierre Is Nothing Then
                cierre = New DataAccess.Cierres
                cierre.IdBanco = IdBanco
                cierre.IdMoneda = Moneda
                cierre.IdProceso = Proceso
                cierre.Fecha = Fecha
                cierre.HoraInicio = Date.Now
                cierre.Paquete = Paquete
                dm.AddToCierres(cierre)
            End If

            cierre.HoraCierre = Nothing
            cierre.Cerrado = False
            cierre.UltimaEdicion = Date.Now

            dm.SaveChanges()

        End Sub
        Public Shared Function ProcesoUltimaEdicion(ByVal IdBanco As String, ByVal Fecha As Date, ByVal Moneda As String, ByVal Proceso As Integer) As DateTime
            Using dm As New DataAccess.Entities


                Dim cierre = (From word In dm.Cierres _
                                         Where word.Fecha = Fecha And word.IdBanco = IdBanco And word.IdMoneda = Moneda _
                            And word.IdProceso = Proceso _
                            Select word).FirstOrDefault

                If cierre Is Nothing Then
                    ProcesoUltimaEdicion = Date.Now
                Else
                    ProcesoUltimaEdicion = cierre.UltimaEdicion
                End If

            End Using

        End Function

        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            MsgBox("Ha ocurrido una excepcion no controlada y la aplicacion debe cerrarse." + Constants.vbCr + Util.EnumErrors(e.Exception))

        End Sub
    End Class

    Public Enum TipoScanner
        CanonCR2555 = 1
        CanonCR180 = 2
        CanonCR180II = 3
    End Enum

    Public Class Constantes
        Public Comision As Double
        Public ComisionIVA As Double
        Public CodigoComision As String
        Public CodigoComisionIVA As Double
        Public CodigoCHERFII As String
        Public CUENTA_ADM_ITAU As String
        Public LONGITUD_CUENTA As Double
    End Class
End Namespace


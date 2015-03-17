Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Text

Friend Class DynamicDllLoader

    Implements IDisposable

    <DllImport("kernel32.dll", _
        CallingConvention:=CallingConvention.Winapi, _
        CharSet:=CharSet.Auto, _
        EntryPoint:="LoadLibrary", _
        PreserveSig:=True)> _
    Friend Shared Function LoadLibrary(<[In]()> ByVal DllPath As String) As Integer



    End Function

    <DllImport("kernel32.dll", _
        CallingConvention:=CallingConvention.Winapi, _
        EntryPoint:="FreeLibrary", _
        PreserveSig:=True)> _
    Friend Shared Function FreeLibrary(<[In]()> ByVal Handle As Integer) As Integer



    End Function

    Private _HandleDll As Integer

    Sub New(ByVal FullPath As String, Optional ByVal fChangeDir As Boolean = False)

        'must change folder to loc of MSVBIDE so VSAssert and MSVBIDEui can be found

        Dim OrigCurdir = System.IO.Directory.GetCurrentDirectory

        If fChangeDir Then

            System.IO.Directory.SetCurrentDirectory(Path.GetDirectoryName(FullPath))

        End If

        Try

            If IO.File.Exists(FullPath) Then

                _HandleDll = LoadLibrary(FullPath)

                If _HandleDll = 0 Then

                    Throw New FileNotFoundException("No se pudo cargar " + FullPath)

                End If

            Else

                Throw New FileNotFoundException(FullPath)

            End If

        Catch ex As Exception

        Finally

            If fChangeDir Then

                Directory.SetCurrentDirectory(OrigCurdir)

            End If

        End Try

    End Sub

    Sub UnLoadDll()

        If _HandleDll Then

            FreeLibrary(_HandleDll)

            _HandleDll = 0

        End If

    End Sub



    Private disposedValue As Boolean = False    ' To detect redundant calls



    ' IDisposable

    Protected Overridable Sub Dispose(ByVal disposing As Boolean)

        If Not Me.disposedValue Then

            If disposing Then

                ' TODO: free other state (managed objects).

            End If

            UnLoadDll()



            ' TODO: free your own state (unmanaged objects).

            ' TODO: set large fields to null.

        End If

        Me.disposedValue = True

    End Sub



#Region " IDisposable Support "

    ' This code added by Visual Basic to correctly implement the disposable pattern.

    Public Sub Dispose() Implements IDisposable.Dispose

        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.

        Dispose(True)

        GC.SuppressFinalize(Me)

    End Sub

#End Region



End Class
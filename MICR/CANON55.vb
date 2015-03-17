Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Public Class CANON55
    Inherits CanonAPIbase
    Private Const Biblioteca As String = "CanoCrop.dll"

    Private Const REG_KEY As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\CR55"
    Sub New()

        Me.SetPath(REG_KEY)

    End Sub
#Region "Declaraciones API "


    <DllImport(Biblioteca, EntryPoint:="CsdProbe", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
    Private Shared Function _CsdProbe() As Int32

    End Function

    <DllImport(Biblioteca, EntryPoint:="CsdDrvDialog", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
    Private Shared Function _CsdDrvDialog(ByVal hInstance As Int32, ByVal hWnd As System.IntPtr, ByVal nDlgID As Int32) As Int32

    End Function
    <DllImport(Biblioteca, EntryPoint:="CsdStopScan", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
    Private Shared Function _CsdStopScan() As Int32


    End Function
    <DllImport(Biblioteca, EntryPoint:="CsdTerminate", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
Private Shared Function _CsdTerminate() As Int32


    End Function
    <DllImport(Biblioteca, EntryPoint:="CsdStartScan", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
        Private Shared Function _CsdStartScan(ByVal lpReserved0 As System.IntPtr, ByVal lpReserved1 As System.IntPtr, ByVal lpReserved As System.IntPtr) As Int32

    End Function
    <DllImport(Biblioteca, EntryPoint:="CsdReadPage", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
            Private Shared Function _CsdReadPage(ByRef ceiimageinfo As CEIIMAGEINFO) As Int32

    End Function

    <DllImport(Biblioteca, EntryPoint:="CsdReleaseImage", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
            Private Shared Function _CsdReleaseImage(ByRef ceiimageinfo As CEIIMAGEINFO) As Int32

    End Function
    <DllImport(Biblioteca, EntryPoint:="CsdParSet", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
            Private Shared Function _CsdParSet(ByVal par_no As Int32, ByVal par_value As Int32) As Int32

    End Function
    <DllImport(Biblioteca, EntryPoint:="CsdParSet", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
        Private Shared Function _CsdParSet(ByVal par_no As Int32, ByVal par_value As String) As Int32

    End Function

    'INT32 WINAPI CsdSaveImageEx(LPCEIIMAGEINFO ceiimageinfo, LPCEIIMAGEFILEINFO lpiFile, LPCSTR szFileName)
    <DllImport(Biblioteca, EntryPoint:="CsdSaveImageEx", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
        Private Shared Function _CsdSaveImageEx(ByRef ceiimageinfo As CEIIMAGEINFO, ByRef lpiFile As CEIIMAGEFILEINFO, ByVal szFileName As String) As Int32

    End Function
    'INT32 WINAPI CsdParGet(UINT par_no, LPVOID *par_value)
    <DllImport(Biblioteca, EntryPoint:="CsdParGet", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
            Private Shared Function _CsdParGet(ByVal par_no As Int32, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef par_value As String) As Int32

    End Function
    <DllImport(Biblioteca, EntryPoint:="CsdParGet", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
        Private Shared Function _CsdParGet(ByVal par_no As Int32, ByRef par_value As Long) As Int32

    End Function
    <DllImport(Biblioteca, EntryPoint:="CsdAbortScan", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
        Private Shared Function _CsdAbortScan() As Int32

    End Function
#End Region

#Region " Implementacion de API "


    Public Overrides Function CsdAbortScan() As Integer
        Return _CsdAbortScan()
    End Function

    Public Overrides Function CsdDrvDialog(ByVal hInstance As Integer, ByVal hWnd As System.IntPtr, ByVal nDlgID As Integer) As Integer
        Return _CsdDrvDialog(hInstance, hWnd, nDlgID)
    End Function

    Public Overrides Function CsdParGet(ByVal par_no As Integer, ByRef par_value As Long) As Integer
        Return _CsdParGet(par_no, par_value)
    End Function

    Public Overrides Function CsdParGet(ByVal par_no As Integer, ByRef par_value As String) As Integer
        Return _CsdParGet(par_no, par_value)
    End Function

    Public Overrides Function CsdParSet(ByVal par_no As Integer, ByVal par_value As Integer) As Integer
        Return _CsdParSet(par_no, par_value)
    End Function

    Public Overrides Function CsdParSet(ByVal par_no As Integer, ByVal par_value As String) As Integer
        Return _CsdParSet(par_no, par_value)
    End Function

    Public Overrides Function CsdProbe() As Integer
        Return _CsdProbe()
    End Function

    Public Overrides Function CsdReadPage(ByRef ceiimageinfo As CanonAPIbase.CEIIMAGEINFO) As Integer
        Return _CsdReadPage(ceiimageinfo)
    End Function

    Public Overrides Function CsdReleaseImage(ByRef ceiimageinfo As CanonAPIbase.CEIIMAGEINFO) As Integer
        Return _CsdReleaseImage(ceiimageinfo)
    End Function

    Public Overrides Function CsdSaveImageEx(ByRef ceiimageinfo As CanonAPIbase.CEIIMAGEINFO, ByRef lpiFile As CanonAPIbase.CEIIMAGEFILEINFO, ByVal szFileName As String) As Integer
        Return _CsdSaveImageEx(ceiimageinfo, lpiFile, szFileName)
    End Function

    Public Overrides Function CsdStartScan(ByVal lpReserved0 As System.IntPtr, ByVal lpReserved1 As System.IntPtr, ByVal lpReserved As System.IntPtr) As Integer
        Return _CsdStartScan(lpReserved0, lpReserved1, lpReserved)
    End Function

    Public Overrides Function CsdTerminate() As Integer
        Return _CsdTerminate()
    End Function
    Public Overrides Function CsdStopScan() As Integer
        Return _CsdStopScan()
    End Function
#End Region
End Class

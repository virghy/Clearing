Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Public MustInherit Class CanonAPIbase
    Public Const CSD_OK As Integer = 0
    Public Const CSD_NOPAPER As Integer = 6
    Public Const CSDP_START_VIEW As Integer = 229
    Public Const CSDP_LOAD_CONFIG_FILE As Integer = 186
    Public Const CSDP_DISPLAY_VIEW_FRONT As Integer = 231
    Public Const CONFIG_FILE As String = "Canon.ini"
    Public Const CSD_BMP_FILE As Integer = 8
    Public Const CSD_JPEG_FILE As Int32 = 2
    Public Const CSD_COMP_JPEG As Integer = 4
    Public Const CSD_COMP_NONE As Integer = 0
    Public Const CSDP_XRESOLUTION As Integer = 6
    Public Const CSDP_YRESOLUTION As Integer = 7
    Public Const CSDP_AUTOSIZE As Integer = 12
    Public Const CSDP_MODE As Integer = 22
    Public Const CSD_4BITGRAYSCALE As Integer = 3



    Public Const CSDP_MICRDATALEN As Int32 = 132
    Public Const CSDP_MICRDATA As Int32 = 133
    Public Const CSDP_SAVE_CONFIG_FILE As Int32 = 187
    Public Const CSDP_MAXDOCUMENT As Int32 = 172

    Public Const CSDP_OCRDATA As Int32 = 216
    Public Const CSDP_OCRDATALEN As Int32 = 217
    '#define CSD_OK                    0
    '#define CSD_NOPAGE                1
    '#define CSD_NODEVICE              2
    '#define CSD_BADPARMNO             3
    '#define CSD_BADFILE               4
    '#define CSD_BADPARM               5
    '#define CSD_NOPAPER               6
    '#define CSD_JAM                   7
    '#define CSD_COVEROPEN             8
    '#define CSD_POWERON               9
    '#define CSD_BADFILE0             10
    '#define CSD_BADFILE1             11
    '#define CSD_COUNTONLY            12
    '#define CSD_COUNTMISS            13
    '#define CSD_ABORTED              14
    '#define CSD_RESFAIL              15
    '#define CSD_NOTREADY             16
    '#define CSD_HARDERROR            17
    '#define CSD_NOTSELECTED          18
    '#define CSD_NEWFILE              19
    '#define CSD_DOUBLEFEED           20
    '#define CSD_SKEWFEED             21
    '#define CSD_FILMEND				 22
    '#define CSD_NOCAMERA			 23
    '#define CSD_BADLOGFILE			 24
    '#define CSD_FILMERROR			 25
    '#define CSD_NOMEM				 26
    '#define CSD_UNKNOWN				 27
    '#define CSD_ENDOFPAGE			 28
    '#define CSD_CANCEL				 29
    '#define CSD_NOCARTRIDGE			 30
    '#define CSD_COUNTMISSTOOMANY	 31
    '#define CSD_COUNTMISSTOOFEW		 32
    '#define CSD_STAPLEDETECTED		 33
    '#define CSD_DELIVERYFULL		 34

    Public Shared Function VarPtr(ByVal o As Object) As Integer
        Dim GC As System.Runtime.InteropServices.GCHandle = System.Runtime.InteropServices.GCHandle.Alloc(o, System.Runtime.InteropServices.GCHandleType.Pinned)
        Return GC.AddrOfPinnedObject.ToInt32
    End Function


    Friend Sub SetPath(ByVal Key As String)
        Dim regKey As RegistryKey
        Dim path As String
        regKey = Registry.LocalMachine.OpenSubKey(Key, False)
        If regKey Is Nothing Then
            Throw New Exception("No se encuentra los drivers del scanner seleccionado")
        End If

        path = regKey.GetValue("Path")

        If IO.Directory.Exists(path) Then
            IO.Directory.SetCurrentDirectory(path)
        Else
            Throw New Exception(String.Format("No se encuentra la carpeta de los drivers del scanner: {0}", path))

        End If
    End Sub

    Public Function SetCSDP_MODE(ByVal atributo As CSDP_MODEAttribute)
        Return CsdParSet(CSDP_MODE, atributo)
    End Function
    Public MustOverride Function CsdProbe() As Int32

    Public MustOverride Function CsdDrvDialog(ByVal hInstance As Int32, ByVal hWnd As System.IntPtr, ByVal nDlgID As Int32) As Int32

    Public MustOverride Function CsdTerminate() As Int32
    Public MustOverride Function CsdStopScan() As Int32

    Public MustOverride Function CsdStartScan(ByVal lpReserved0 As System.IntPtr, ByVal lpReserved1 As System.IntPtr, ByVal lpReserved As System.IntPtr) As Int32

    Public MustOverride Function CsdReadPage(ByRef ceiimageinfo As CEIIMAGEINFO) As Int32

    Public MustOverride Function CsdReleaseImage(ByRef ceiimageinfo As CEIIMAGEINFO) As Int32

    Public MustOverride Function CsdParSet(ByVal par_no As Int32, ByVal par_value As Int32) As Int32

    Public MustOverride Function CsdParSet(ByVal par_no As Int32, ByVal par_value As String) As Int32

    Public MustOverride Function CsdSaveImageEx(ByRef ceiimageinfo As CEIIMAGEINFO, ByRef lpiFile As CEIIMAGEFILEINFO, ByVal szFileName As String) As Int32

    Public MustOverride Function CsdParGet(ByVal par_no As Int32, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef par_value As String) As Int32

    Public MustOverride Function CsdParGet(ByVal par_no As Int32, ByRef par_value As Long) As Int32

    Public MustOverride Function CsdAbortScan() As Int32



#Region " Estructuras"

    '    typedef struct tagVIEWOFIMAGE {
    '	DWORD cbSize;
    '	HWND hwndFrontSideImage;		/* displays the front side image */
    '	HWND hwndBackSideImage;			/* displays the back side image */
    '} VIEWOFIMAGE, *LPVIEWOFIMAGE;
    Public Structure VIEWOFIMAGE
        Public cbSize As Int32
        Public hwndFrontSideImage As Int32
        Public hwndBackSideImage As Int32
    End Structure

    Public Structure CEIIMAGEFILEINFO
        Public cbSize As Int32
        Public nFileType As Int32
        Public nCompType As Int32
        Public nPage As Int32
        Public nJpegQuality As Int32
    End Structure
    '   typedef struct tagCEIIMAGEFILEINFO {
    'size_t	cbSize;				/* size of CEIIMAGEFILEINFO */
    'long	nFileType;			/* File Format */
    'long	nCompType;			/* Compression Type */
    'long	nPage;				/* Page */
    'long	nJpegQuality;

    Public Structure CEIIMAGEINFO
        Public cbSize As Int32
        Public lpImage As Int32
        Public lXpos As Int32
        Public lYpos As Int32
        Public lWidth As Int32
        Public lHeight As Int32
        Public lSync As Int32
        Public tImageSize As Int32
        Public lBps As Int32
        Public lSpp As Int32
        Public dwRGBOrder As Int32
        Public lXResolution As Int32
        Public lYResolution As Int32
    End Structure
    'typedef struct tagCEIIMAGEINFO {
    '	size_t	cbSize;				/* size of CEIIMAGEINFO */
    '	BYTE	*lpImage;			/* ptr of Image buffer */
    '	long	lXpos;				/* start dot of image */
    '	long	lYpos;				/* start line of image */
    '	long	lWidth;				/* width of image (dot) */
    '	long	lHeight;			/* heigth of image (line) */
    '	long	lSync;				/* line bytes */
    '	size_t	tImageSize;			/* buffer size */
    '	long	lBps;				/* bits per sample */
    '	long	lSpp;				/* samples per pixel */
    '	DWORD	dwRGBOrder;			/*  */
    '	long	lXResolution;		/* resolution x */
    '	long	lYResolution;		/* resolution y */

#End Region


    Public Enum CSDP_MODEAttribute
        CSD_BINARY
        CSD_BINARY_ED
        CSD_4BITGRAYSCALE
        CSD_GRAYSCALE
        CSD_COLOR
        CSD_BINARY_FINE
        CSD_BINARY_PHOTO
        CSD_BINARY_TEXTENHANCED
        CSD_GRAYSCALE_SMOOTHING
        CSD_COLOR_SMOOTHING
        CSD_BINARY_AUTOTHRESHOLD

    End Enum

End Class
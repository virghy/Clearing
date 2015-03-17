Option Strict On
Option Explicit On

Imports System.Security.Cryptography
Imports System.IO

Namespace Security.Cryptography

    Public Class CRC32
        Inherits HashAlgorithm

        Private Const _DefaultPolynomial As Integer = &HEDB88320

#Region " Member Variables "
        Private _Table() As Integer
        Private _CRC32 As Integer = &HFFFFFFFF
        Private _Polynomial As Integer
#End Region

#Region " Contructors "
        Public Sub New()

            Me.HashSizeValue = 32 ' CRC32 is a 32bit hash

            _Polynomial = _DefaultPolynomial

            Initialize()

        End Sub

        Public Sub New(ByVal Polynomial As Integer)
            _Polynomial = Polynomial
        End Sub

#End Region

#Region " HashAlgorithm "

        Protected Overrides Sub HashCore(ByVal array() As Byte, ByVal ibStart As Integer, ByVal cbSize As Integer)

            Dim intLookup As Integer
            For i As Integer = 0 To cbSize - 1
                intLookup = (_CRC32 And &HFF) Xor array(i)
                'This is a workaround for a right bit-shift because vb.net
                'does not support unsigned Integers, so _CRC32 >> 8
                'gives the wrong value (any better fixes?)
                _CRC32 = ((_CRC32 And &HFFFFFF00) \ &H100) And &HFFFFFF
                _CRC32 = _CRC32 Xor _Table(intLookup)
            Next i
        End Sub

        Protected Overrides Function HashFinal() As Byte()
            Return BitConverter.GetBytes(Not _CRC32)
        End Function

        Public Overrides Sub Initialize()
            _CRC32 = &HFFFFFFFF
            _Table = BuildTable(_Polynomial)
        End Sub


#End Region

#Region " Helper Methods "
        ''' <summary>
        ''' Generates the CRC32 Table
        ''' </summary>
        ''' <param name="Polynomial">A polynomial that should be used to generate the table.</param>
        ''' <returns>The CRC32 Table based on the Polynomial given</returns>
        Private Shared Function BuildTable(ByVal Polynomial As Integer) As Integer()
            Dim Table(255) As Integer

            Dim Value As Integer

            For I As Integer = 0 To 255
                Value = I
                For X As Integer = 0 To 7
                    If (Value And 1) = 1 Then
                        'This is a workaround for a right bit-shift because vb.net
                        'does not support unsigned Integers, so _CRC32 >> 1
                        'gives the wrong value (any better fixes?)
                        Value = Convert.ToInt32(((Value And &HFFFFFFFE) \ 2&) And &H7FFFFFFF)
                        Value = Value Xor Polynomial
                    Else
                        'Same as above.
                        Value = Convert.ToInt32(((Value And &HFFFFFFFE) \ 2&) And &H7FFFFFFF)
                    End If
                Next
                Table(I) = Value
            Next

            Return Table
        End Function

#End Region

        Public Function FileCRC(ByVal FileName As String) As String
            Dim fs As New FileStream(FileName, FileMode.Open)

            Dim CRC32 As Integer = BitConverter.ToInt32(ComputeHash(CType(fs, Stream)), 0)

            fs.Close()

            ' MessageBox.Show(String.Format("The CRC is: {0:X8}", CRC32))
            Return CRC32.ToString("X8")
        End Function

    End Class

End Namespace

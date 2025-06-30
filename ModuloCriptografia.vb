Imports System.Security.Cryptography
Imports System.Text
Module ModuloCriptografia
    Public Function CriptografarSenha(senha As String) As String
        Dim sha256 As SHA256 = SHA256.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(senha)
        Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
        Dim hashString As New StringBuilder()
        For Each b As Byte In hashBytes
            hashString.Append(b.ToString("x2"))
        Next
        Return hashString.ToString()
    End Function
End Module

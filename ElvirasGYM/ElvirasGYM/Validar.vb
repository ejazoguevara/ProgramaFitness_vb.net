Imports System.Text.RegularExpressions
Public NotInheritable Class Validar

    Public Shared Sub numDecimal(ByRef key As Char)
        Select Case (Asc(key))
            Case 8  ' borrar
            Case 48 To 57     '  numeros
            Case Else
                key = Chr(0)
        End Select
    End Sub

    Public Shared Sub letrasAndDecimal(ByRef key As Char)
        Select Case (Asc(key))
            Case 8  ' borrar
            Case 13  ' enter
            Case 48 To 57     '  numeros
            Case 65 To 90     '  letra Mayusculas
            Case 67 To 122     '  letra Minusculas
            Case Else
                key = Chr(0)
        End Select
    End Sub

    Public Shared Sub letras(ByRef key As Char)
        Select Case (Asc(key))
            Case 8  ' borrar
            Case 32
            Case 65 To 90     '  letra Mayusculas
            Case 67 To 122     '  letra Minusculas
            Case Else
                key = Chr(0)
        End Select
    End Sub


    Public Shared Sub telefono(ByRef key As Char)
        Select Case (Asc(key))
            Case 8  ' borrar
            Case 48 To 57     ' numeros
            Case 40 To 41     '  parentesis
            Case 45 ' guion
            Case Else
                key = Chr(0)
        End Select
    End Sub

    Public Shared Sub correo(ByRef key As Char)
        Select Case (Asc(key))
            Case 8  ' borrar
            Case 48 To 57 ' numeros
            Case 65 To 90     '  letra Mayusculas
            Case 67 To 122     '  letra Minusculas
            Case 64 ' arroba
            Case 46 ' punto
            Case Else
                key = Chr(0)
        End Select
    End Sub

    Public Shared Sub comentario(ByRef key As Char)
        Select Case (Asc(key))
            Case 8  ' borrar
            Case 32
            Case 48 To 57 ' numeros
            Case 65 To 90     '  letra Mayusculas
            Case 67 To 122     '  letra Minusculas
            Case 64 ' arroba
            Case 46 ' punto
            Case Else
                key = Chr(0)
        End Select
    End Sub

    Public Shared Function validaCorreo(ByVal mail As String) As Boolean
        Return Regex.IsMatch(mail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

End Class

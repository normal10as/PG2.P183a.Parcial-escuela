Public Class Nota
    Public Property Valor As Byte

    Public Function isAprobado() As Boolean
        Return Valor >= 6
    End Function
End Class

Imports Entidades

Public Class Asistencia
    Public Sub New(alumno As Alumno, fecha As Date, presente As Boolean)
        Me.Alumno = alumno
        Me.Fecha = fecha
        Me.Presente = presente
    End Sub

    Private _alumno As Alumno
    Public Property Alumno As Alumno
        Set(value As Alumno)
            value.addAsistencia(Me)
            _alumno = value
        End Set
        Get
            Return _alumno
        End Get
    End Property
    Public Property Fecha As Date
    Public Property Presente As Boolean

    Public Overrides Function ToString() As String
        Return Alumno.ToString & " " & Fecha & " " &
            If(Presente, "Presente", "Ausente")
    End Function
End Class

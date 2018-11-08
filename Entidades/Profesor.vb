Imports Entidades

Public Class Profesor
    Inherits Persona

    Sub New(nombre As String, dni As UInteger, legajo As UShort)
        MyBase.New(nombre, dni)
        Me.Legajo = legajo
    End Sub

    Public Property Legajo As UShort

    Public Overrides Sub AddAsignatura(asignatura As Asignatura)
        asignatura.Profesor = Me
        _asignaturas.Add(asignatura)
    End Sub
    Public Overrides Sub RemoveAsignatura(asignatura As Asignatura)
        asignatura.Profesor = Nothing
        MyBase.RemoveAsignatura(asignatura)
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & " " & Legajo
    End Function
End Class

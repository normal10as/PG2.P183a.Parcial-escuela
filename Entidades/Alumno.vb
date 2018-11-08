Imports Entidades

Public Class Alumno
    Inherits Persona

    Public Sub New(nombre As String, dNI As UInteger)
        MyBase.New(nombre, dNI)
        _asistencias = New List(Of Asistencia)
    End Sub

    Public ReadOnly Property Promedio As Decimal

    Public Overrides Sub AddAsignatura(asignatura As Asignatura)
        asignatura.addAlumno(Me)
        _asignaturas.Add(asignatura)
    End Sub
    Public Overrides Sub RemoveAsignatura(asignatura As Asignatura)
        asignatura.removeAlumno(Me)
        MyBase.RemoveAsignatura(asignatura)
    End Sub

    Private _asistencias As List(Of Asistencia)
    Friend Sub addAsistencia(asistencia As Asistencia)
        _asistencias.Add(asistencia)
    End Sub
    Public Function getAllAsistencias() As List(Of Asistencia)
        Return _asistencias
    End Function
    Public ReadOnly Property TotalPresentes As Decimal
        Get
            Return TotalAsistencia(True)
        End Get
    End Property

    Public ReadOnly Property TotalAusentes As Decimal
        Get
            Return TotalAsistencia(False)
        End Get
    End Property

    Private Function TotalAsistencia(valor As Boolean) As Decimal
        Dim total As Decimal
        For Each asistencia In getAllAsistencias()
            If asistencia.Presente = valor Then
                total += 1
            End If
        Next
        Return total
    End Function
    Public Function GetPorcentajeAsistencia() As Decimal
        If getAllAsistencias.Count > 0 Then
            Return TotalPresentes * 100 / getAllAsistencias.Count
        Else
            Return 0
        End If
    End Function
    Public Function isRegular() As Boolean
        Return GetPorcentajeAsistencia() >= 70
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & " " & If(isRegular(), "Regular", "Libre")
    End Function
End Class

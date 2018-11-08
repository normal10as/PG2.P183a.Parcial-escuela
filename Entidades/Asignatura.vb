Public Class Asignatura

    Public Sub New(nombre As String)
        Me.Nombre = nombre
        _alumnos = New List(Of Alumno)
    End Sub

    Private _Nombre As String
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set
            If Value.Length >= 3 And Value.Length <= 30 Then
                _Nombre = Value
            End If
        End Set
    End Property

    Private _profesor As Profesor
    Public Property Profesor As Profesor
        Friend Set(value As Profesor)
            _profesor = value
        End Set
        Get
            Return _profesor
        End Get
    End Property

    Private _alumnos As List(Of Alumno)

    Friend Sub addAlumno(alumno As Alumno)
        _alumnos.Add(alumno)
    End Sub
    Friend Sub removeAlumno(alumno As Alumno)
        _alumnos.Remove(alumno)
    End Sub

    Public Overrides Function ToString() As String
        Return Nombre & ", Profesor: " & Profesor.ToString
    End Function
End Class

Public MustInherit Class Persona

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

    Public Property DNI As UInteger

    Protected _asignaturas As List(Of Asignatura)

    Public Sub New(nombre As String, dNI As UInteger)
        Me.Nombre = nombre
        Me.DNI = dNI
        _asignaturas = New List(Of Asignatura)
    End Sub

    Public MustOverride Sub AddAsignatura(asignatura As Asignatura)
    Public Overridable Sub RemoveAsignatura(asignatura As Asignatura)
        _asignaturas.Remove(asignatura)
    End Sub
    Public Function GetAllAsignaturas() As List(Of Asignatura)
        Return _asignaturas
    End Function

    Public Overrides Function ToString() As String
        Return Nombre & " " & DNI
    End Function
End Class

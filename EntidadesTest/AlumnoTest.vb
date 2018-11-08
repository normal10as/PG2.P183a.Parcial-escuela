Imports Entidades

Public Module AlumnoTest
    Sub main()
        Dim al1 As New Alumno("Pepe", 123)
        Console.WriteLine("Nombre: " & al1.Nombre)
        Console.WriteLine("DNI: " & al1.DNI)
        Console.WriteLine("ToString(): " & al1.ToString())

        Dim as1 As New Asignatura("Matematica 1")
        al1.AddAsignatura(as1)
        al1.AddAsignatura(New Asignatura("Biología"))
        al1.AddAsignatura(New Asignatura("Geografía"))

        ' para evitar referencia nula creo un profesor para las asignaturas del alumno
        Dim p1 As New Profesor("Pepe", 123, 987)
        For Each asignatura In al1.GetAllAsignaturas
            p1.AddAsignatura(asignatura)
        Next

        MostrarTodasLasAsignaturas(al1)

        Console.WriteLine("Eliminar " & as1.ToString)
        al1.RemoveAsignatura(as1)
        MostrarTodasLasAsignaturas(al1)

        MostrarAsistencia(al1)
        Dim asistencia As Asistencia
        asistencia = New Asistencia(al1, Now, True)
        asistencia = New Asistencia(al1, Now.AddDays(1), True)
        asistencia = New Asistencia(al1, Now.AddDays(-1), False)
        MostrarAsistencia(al1)
        asistencia = New Asistencia(al1, Now.AddDays(2), True)
        MostrarAsistencia(al1)

    End Sub

    Private Sub MostrarAsistencia(alumno As Alumno)
        For Each a In alumno.getAllAsistencias
            Console.WriteLine(a.ToString())
        Next
        Console.WriteLine("Total presentes: " & alumno.TotalPresentes)
        Console.WriteLine("Total ausentes: " & alumno.TotalAusentes)
        Console.WriteLine("% Asistencia : " & alumno.GetPorcentajeAsistencia)
        Console.WriteLine("Estado asistencia : " & alumno.isRegular)
        Console.WriteLine("ToString(): " & alumno.ToString())
    End Sub
End Module

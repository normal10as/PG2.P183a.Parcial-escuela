Imports Entidades

Module AsistenciaTest
    Sub main()
        Dim alumno As New Alumno("Pepe", 123)
        Dim asistencia As Asistencia
        asistencia = New Asistencia(alumno, Now, True)
        Console.WriteLine("Alumno: " & asistencia.Alumno.ToString)
        Console.WriteLine("Fecha: " & asistencia.Fecha)
        Console.WriteLine("Presente: " & asistencia.Presente)
        Console.WriteLine("Tostring: " & asistencia.ToString)
        asistencia.Presente = False
        Console.WriteLine("Presente: " & asistencia.Presente)
        Console.WriteLine("Tostring: " & asistencia.ToString)

    End Sub
End Module
